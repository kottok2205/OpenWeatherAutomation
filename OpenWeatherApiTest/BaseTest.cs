﻿using BaseDriverService;

namespace OpenWeatherApiTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();
        public string baseUrl = "https://openweathermap.org/";
        public string requestUrl = "data/2.5/onecall?lat=50&lon=36.25&units=metric&appid=439d4b804bc8187953eb36d2a8c26a02";
        [SetUp]
        public void Setup()
        {
            BaseHttpClient.GetInstance();
        }

        [TearDown]
        public void TearDown()
        {
            BaseHttpClient.QuitInstance();
        }
    }
}
