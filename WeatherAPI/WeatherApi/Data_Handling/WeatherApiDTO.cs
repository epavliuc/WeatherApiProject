using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.WeatherApi.Data_Handling
{
    public class WeatherApiDTO
    {
        public WeatherApiModel weatherApiModel { get; set; }
        public void DeserializeWeather(String WeatherApiResponse)
        {
            weatherApiModel = JsonConvert.DeserializeObject<WeatherApiModel>(WeatherApiResponse);
        }
    }
}
