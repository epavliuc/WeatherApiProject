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
        public void ApiStatusCheck()
        {
            //status from api content code and from response status code 
            Assert.AreEqual(200, WAS.weatherApiDto.weatherApiModel.Cod);
            Assert.AreEqual("OK", WAS.weatherResponse.StatusCode.ToString());
        }

        [Test]
        public void ApiPositionCheck()
        {
            //position Longitude and Latitude
            Assert.AreEqual(-0.13, WAS.weatherApiDto.weatherApiModel.Coord.Lon);
            Assert.AreEqual(51.51, WAS.weatherApiDto.weatherApiModel.Coord.Lat);
        }
        
        [Test]
        public void ApiTempNotNull()
        {
            //if there is a temp value
            Assert.NotNull(WAS.weatherApiDto.weatherApiModel.Main.Temp);
        }

        [Test]
        public void ApiTempNotFreezingCheck()
        {
            //if current temp is above 0°C
            Assert.Greater(WAS.weatherApiDto.weatherApiModel.Main.Temp, 273.1);
        }

        [Test]
        public void ApiLocationNameCheck()
        {
            //if requested data is for city London
            Assert.AreEqual("London", WAS.weatherApiDto.weatherApiModel.Name);
        }

        [Test]
        public void ApiLocationIDCheck()
        {
            //if requested data is for city London
            Assert.AreEqual(2643743, WAS.weatherApiDto.weatherApiModel.ID);
        }

        [Test]
        public void ApiAtmosphereNormalCheck()
        {
            //if atmosphere is between normal values
            Assert.Greater(WAS.weatherApiDto.weatherApiModel.Main.Pressure, 1000);
            Assert.Less(WAS.weatherApiDto.weatherApiModel.Main.Pressure, 1030);
        }

        [Test]
        public void ApiHumidityNormalCheck()
        {
            //if humidity is between normal values
            Assert.Greater(WAS.weatherApiDto.weatherApiModel.Main.Humidity, 50);
            Assert.Less(WAS.weatherApiDto.weatherApiModel.Main.Humidity, 85);
        }

    }
}
