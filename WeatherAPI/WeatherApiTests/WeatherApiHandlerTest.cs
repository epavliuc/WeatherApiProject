using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPI.WeatherApi.HTTP_Management;

namespace WeatherAPI.WeatherApiTests
{
    [TestFixture]
    class WeatherApiHandlerTest
    {
        WeatherApiService WAS = new WeatherApiService();

        [Test]
        public void ApiHandlerNullCheck()
        {
            Assert.IsNotNull(WAS.weatherResponse.Headers.ToString());
        }

        [Test]
        public void ApiHandlerCountCheck()
        {
            Assert.AreEqual(9,WAS.weatherResponse.Headers.Count);
        }
    }


}
