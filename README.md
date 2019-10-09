# WeatherApiProject
Within the project, the aim was to establish connection with the OpenWeatherApi, to receive a response and create tests which check and validate the information received.

## Code Preview

This method is responsible for the request and returning of the response as string using RestSharp.
```c#
        public string WeatherApiRequest()
        {
            var request = new RestRequest();
            Client = new RestClient(ApiConfig.ApiUrl+ApiConfig.ApiUrlMod+ApiConfig.Location+ApiConfig.ApiKeyMod+ApiConfig.ApiKey);
            Response = Client.Execute(request);

            return Response.Content;
        }
````
This method is responsible for the deserialisation of received data, assigning the JSON string to the built object model containg the necessary properties.
```c#
        public void DeserializeWeather(String WeatherApiResponse)
        {
            weatherApiModel = JsonConvert.DeserializeObject<WeatherApiModel>(WeatherApiResponse);
        }
````
