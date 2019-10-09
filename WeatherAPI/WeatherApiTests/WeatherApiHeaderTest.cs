using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeatherAPI.WeatherApi.HTTP_Management;

namespace WeatherAPI.WeatherApi.HTTP_Management
{
    [TestFixture]
    class WeatherApiHeaderTest
    {
        WeatherApiService WAS = new WeatherApiService();

        [Test]
        public void ApiHeadersNullCheck()
        {
            //if header is null
            Assert.IsNotNull(WAS.weatherResponse.Headers);
        }

        [Test]
        public void ApiHandlerCountCheck()
        {
            //if count of headers is 9
            Assert.AreEqual(9, WAS.weatherResponse.Headers.Count);
        }

        [Test]
        public void ApiHandlerContentTypeCheck()
        {
            //if the content type is as neccesary
            Assert.AreEqual("Content-Type=application/json; charset=utf-8", WAS.weatherResponse.Headers[6].ToString());
        }

        [Test]
        public void ApiHandlerServerCheck()
        {
            //if the server is as needed
            Assert.AreEqual("Server=openresty", WAS.weatherResponse.Headers[8].ToString());
        }

        [Test]
        public void ApiHandlerHTTPMethodsCheck()
        {
            //if needed methods are available
            Assert.AreEqual("Access-Control-Allow-Methods=GET, POST", WAS.weatherResponse.Headers[4].ToString());
        }

        [Test]
        public void ApiHandlerCacheKeyCheck()
        {
            //if cache key is correct
            Assert.AreEqual("X-Cache-Key=/data/2.5/weather?APPID=9454423d7ece5f6fac65100266220007&q=london", WAS.weatherResponse.Headers[1].ToString());
        }

    }


}
