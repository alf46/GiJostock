using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace GiJoStock
{
    public class ProductRepository : Repository<Product>
    {
        public Product WarehouseTransfer(int productID, int stock, int from, int to)
        {
            var filter = new Dictionary<string, object>();
            filter["stock"] = stock;
            filter["from"] = from;
            filter["to"] = to;

            var queryFilters = this.GetFilter(filter);

            var urlRequest = this._url + "product/transfer/" + productID + queryFilters;

            using (var web = new WebClient())
            {
                var json = web.DownloadString(urlRequest);
                return JsonConvert.DeserializeObject<Product>(json);
            }
        }
    }
}