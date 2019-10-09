# WeatherApiProject
Within the project, the aim was to establish connection with the OpenWeatherApi, to receive a response and create tests which check and validate the information received.

## Premise of Tests
The aim of the tests were not only to test both the content received but also other things such as headers. For example, with the content there are tests designated to checking if we are receiving information based on the right location and with the headers, if we are receiving the right Content Type.

Nr of Tests: 22

## NuGet Packages used
```
 RestSharp
 NUnit
 NUnitTestAdapter
 Newtonsoft.Json
```
## Code Explanation
This project has a clear built structure with the use of folders, depending on it's purpose, code can be found in it's respective folder/area.

1. WeatherApi
   - Data_Handling
   - HTTP_Management
2. WeatherApiTests

Within Data_Handling you will find all he code relating to handling the data received as the API response(JSON string).

Within HTTP_Management you will find all the code relating to the client,request and response relating to the API.

Within WeatherApiTests we have all the built Unit Tests relating to the project.


## Code Preview
Preview of pivotal pieces of code

> This method is responsible for the request and returning of the response as string using RestSharp.
```c#
        public string WeatherApiRequest()
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.ApiUrl+ApiConfig.ApiUrlMod+ApiConfig.Location+ApiConfig.ApiKeyMod+ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }
````
> This method is responsible for the deserialisation of received data, assigning the JSON string to the built object model containg the necessary properties.
```c#
        public void DeserializeWeather(String WeatherApiResponse)
        {
            weatherApiModel = JsonConvert.DeserializeObject<WeatherApiModel>(WeatherApiResponse);
        }
````
## API JSON response example
```JSON
{
    "coord": {
        "lon": -0.13,
        "lat": 51.51
    },
    "weather": [
        {
            "id": 520,
            "main": "Rain",
            "description": "light intensity shower rain",
            "icon": "09n"
        }
    ],
    "base": "stations",
    "main": {
        "temp": 283.01,
        "pressure": 1006,
        "humidity": 93,
        "temp_min": 281.48,
        "temp_max": 284.82
    },
    "visibility": 10000,
    "wind": {
        "speed": 5.1,
        "deg": 220
    },
    "clouds": {
        "all": 40
    },
    "dt": 1570652489,
    "sys": {
        "type": 1,
        "id": 1412,
        "message": 0.0135,
        "country": "GB",
        "sunrise": 1570601610,
        "sunset": 1570641719
    },
    "timezone": 3600,
    "id": 2643743,
    "name": "London",
    "cod": 200
}
````
