using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WeatherAPI.WeatherApi.HTTP_Management
{

    [TestFixture]
    public class WeatherApiTest
    {
        WeatherApiCall apiCall = new WeatherApiCall();
        public WeatherApiTest()
        {
            apiCall.WeatherApiRequest("London");
        }


        [Test]
        public void WeatherApiStatusCheck()
        {
            Assert.AreEqual("200", apiCall.WeatherApiResponse["cod"].ToString());
        }
    }
}
