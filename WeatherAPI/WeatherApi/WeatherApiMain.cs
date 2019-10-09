using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.WeatherApi.HTTP_Management
{
    class WeatherApiMain
    {
        
        static void Main(string[] args)
        {
            WeatherApiCall WAC = new WeatherApiCall();
            WAC.WeatherApiRequest("London");
            Console.WriteLine(WAC.WeatherApiResponse.ToString());
            Console.Read();
        }
    }
}
