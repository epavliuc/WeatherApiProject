using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPI.WeatherApi.Data_Handling;

namespace WeatherAPI.WeatherApi.HTTP_Management
{

    [TestFixture]
    public class WeatherApiTest
    {
        WeatherApiService WAS = new WeatherApiService();
        public WeatherApiTest()
        {
            
        }


        [Test]
        public void WeatherApiStatusCheck()
        {
            Assert.AreEqual("200", WAS.weatherApiDto.weatherApiModel.Cod);
        }
    }
}
