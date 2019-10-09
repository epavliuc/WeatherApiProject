using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Configuration;

namespace WeatherAPI.WeatherApi.HTTP_Management
{
    public class WeatherApiCall
    { 
        public IRestClient Client { get; set; }
        public IRestResponse Response { get; set; }       

        public string WeatherApiRequest()
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.ApiUrl+ApiConfig.ApiUrlMod+ApiConfig.Location+ApiConfig.ApiKeyMod+ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }
    }
}
