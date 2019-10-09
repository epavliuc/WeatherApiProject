﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.WeatherApi.Data_Handling;
using WeatherAPI.WeatherApi.HTTP_Management;

namespace WeatherAPI.WeatherApi.HTTP_Management
{
    class WeatherApiMain
    {
        
        static void Main(string[] args)
        {
            WeatherApiService WAS = new WeatherApiService();
            Console.WriteLine(WAS.WeatherApiJObject.ToString());
            Console.Read();
        }

    }

    public class WeatherApiService
    {
        //Need DTO
        public WeatherApiDTO weatherApiDto = new WeatherApiDTO();
        //Need CallManager
        public WeatherApiCall weatherApiCall = new WeatherApiCall();
        //Need JObject
        public JObject WeatherApiJObject;
        

        public WeatherApiService()
        {
            weatherApiDto.DeserializeWeather(weatherApiCall.Response.Content);
            WeatherApiJObject = JObject.Parse(weatherApiCall.Response.Content);
        }
    }
}
