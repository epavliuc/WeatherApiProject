using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    public static class ApiConfig
    {
        //settup limits to london related data
        public static string ApiUrl = ConfigurationManager.AppSettings["BaseApiUrl"];
        public static string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        public static string ApiUrlMod = ConfigurationManager.AppSettings["UrlMod"];
        public static string Location = ConfigurationManager.AppSettings["Location"];
        public static string ApiKeyMod = ConfigurationManager.AppSettings["ApiMod"];
    }
}
