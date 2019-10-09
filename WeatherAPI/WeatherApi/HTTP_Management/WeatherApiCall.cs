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

        public JObject WeatherApiResponse { get; set; }
        public IRestClient Client { get; set; }
        public IRestResponse Response { get; set; }

        public static class ApiConfig
        {
            //settup limits to searching by city only
            public static string ApiUrl = ConfigurationManager.AppSettings["BaseApiUrl"];
            public static string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
            public static string ApiMod = ConfigurationManager.AppSettings["ApiMod"];
        }
        public void WeatherApiRequest(string city)
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.ApiUrl + city + ApiConfig.ApiMod + ApiConfig.ApiKey);
            Response = Client.Execute(request, Method.GET);
        }
    }
}
