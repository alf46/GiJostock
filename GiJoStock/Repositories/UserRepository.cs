using RestSharp;
using System.Collections.Generic;

namespace GiJoStock.Repositories
{
    public class UserRepository : Repository<User>
    {
        public static User LoggedUser { get; private set; }

        public User ResetPassword(int userID, string pass, string newPass, string confirmNewPass)
        {
            var dic = new Dictionary<string, object>();
            dic["Password"] = pass;
            dic["NewPassword"] = newPass;
            dic["ConfirmNewPassword"] = confirmNewPass;

            var urlRequest = this._url + "user/reset/" + userID;

            var request = new RestRequest(urlRequest);
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", this.GetJson(dic), ParameterType.RequestBody);
            var response = new RestClient().Execute(request, Method.POST);
            return this.GetResposeMessage(response);
        }

        public void Login(string username, string password)
        {
            var dic = new Dictionary<string, object>();
            dic["Username"] = username;
            dic["Password"] = password;

            var urlRequest = this._url + "user/login";

            var request = new RestRequest(urlRequest);
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", this.GetJson(dic), ParameterType.RequestBody);
            var response = new RestClient().Execute(request, Method.POST);
            LoggedUser = this.GetResposeMessage(response);
        }
    }
}