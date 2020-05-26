using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GiJoStock
{
    public class Repository<TSource> : IRepository<TSource> where TSource : IDisable
    {
        protected readonly string _url;

        public Repository()
        {
            this._url = "http://localhost:53988/";
        }

        public TSource Add(TSource source)
        {
            return this.AddOrUpdate(source);
        }

        public TSource Disable(int id)
        {
            var controller = Helpers.GetController<TSource>();
            var urlRequest = this._url + controller + "/" + id;

            var request = new RestRequest(urlRequest);
            var response = new RestClient().Execute(request, Method.DELETE);
            return this.GetResposeMessage(response);
        }

        public TSource Get(int id)
        {
            using (var web = new WebClient())
            {
                var json = web.DownloadString(this._url + Helpers.GetController<TSource>() + "/" + id);
                return JsonConvert.DeserializeObject<TSource>(json);
            }
        }

        public List<TSource> GetAll(Dictionary<string, object> filter = null)
        {
            using (var web = new WebClient())
            {
                var queryFilters = this.GetFilter(filter);
                var json = web.DownloadString(this._url + Helpers.GetController<TSource>() + queryFilters);
                return JsonConvert.DeserializeObject<List<TSource>>(json);
            }
        }

        public TSource Update(TSource source)
        {
            return this.AddOrUpdate(source, Method.PUT);
        }

        private TSource AddOrUpdate(TSource source, Method method = Method.POST)
        {
            var urlRequest = this._url + Helpers.GetController<TSource>();
            if (method == Method.PUT)
            {
                urlRequest += "/" + source.ID;
                method = Method.PUT;
            }

            var request = new RestRequest(urlRequest);
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", this.GetJson(source), ParameterType.RequestBody);
            var response = new RestClient().Execute(request, method);
            return this.GetResposeMessage(response);
        }

        protected string GetJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        protected TSource GetResposeMessage(IRestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                return JsonConvert.DeserializeObject<TSource>(response.Content);
            }
            else
            {
                var mapMessage = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                throw new System.Exception(mapMessage["title"]);
            }
        }

        public string GetFilter(Dictionary<string, object> filter)
        {
            if (filter != null && filter.Count > 0)
            {
                return "?" + string.Join("&", filter.Select(x => x.Key + "=" + x.Value?.ToString()));
            }
            else return null;
        }
    }
}