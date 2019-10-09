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
    public class WeatherApiContentTest
    {
        WeatherApiService WAS = new WeatherApiService();

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

        [Test]
        public void ApiGaleWindsCheck()
        {
            //if wind are Strong gale worthy
            Assert.Less(WAS.weatherApiDto.weatherApiModel.Wind.Speed, 23.5);
        }

        [Test]
        public void ApiCloudyCheck()
        {
            //if its cloudy in london
            Assert.Greater(WAS.weatherApiDto.weatherApiModel.Clouds.All, 0);
        }

        [Test]
        public void ApiTimeZoneCheck()
        {
            //if in the right timezone
            Assert.AreEqual(3600, WAS.weatherApiDto.weatherApiModel.TimeZone);
        }

        [Test]
        public void ApiVisibilityOver1000Meters()
        {
            //if visibility is over 1000 meters
            Assert.Greater(WAS.weatherApiDto.weatherApiModel.Visibility,1000);
        }

        [Test]
        public void ApiCountryCheck()
        {
            //if in the right timezone
            Assert.AreEqual("GB", WAS.weatherApiDto.weatherApiModel.Sys.Country);
        }

        [Test]
        public void ApiRainingCheck()
        {
            //if its raining
            Assert.AreEqual("Rain", WAS.weatherApiDto.weatherApiModel.Weather[0].Main);
        }

        [Test]
        public void ApiTempBetweenMinMaxCheck()
        {
            //if current temp is between min and max temps
            Assert.Less(WAS.weatherApiDto.weatherApiModel.Main.Temp, WAS.weatherApiDto.weatherApiModel.Main.Temp_max);
            Assert.Greater(WAS.weatherApiDto.weatherApiModel.Main.Temp, WAS.weatherApiDto.weatherApiModel.Main.Temp_min);
        }


    }
}
