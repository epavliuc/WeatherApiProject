using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.WeatherApi.Data_Handling
{
    public class WeatherApiModel
    {
        public Coord Coord { get; set; }
        public IList<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Rain rain { get; set; }
        public Snow snow { get; set; }
        public Sys Sys { get; set; }
        public string Base { get; set; }
        public int DT { get; set; }
        public int Visibility { get; set; }
        public int TimeZone { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

    }

    public class Main
    {
        public double Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Temp_min { get; set; }
        public double Temp_max { get; set; }
    }

    public class Coord
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }

    public class Weather
    {

    }
    public class Sys
    {
    }

    public class Snow
    {
    }

    public class Rain
    {
    }

    public class Clouds
    {
    }

    public class Wind
    {
    }
}
