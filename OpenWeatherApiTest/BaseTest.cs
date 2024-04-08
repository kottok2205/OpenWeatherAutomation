using BaseDriverService;

namespace OpenWeatherApiTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();

        public string baseUrl = "http://openweathermap.org/";
        public string daysUnixUrl = "data/2.5/onecall?lat=50.4333&lon=30.5167&units=metric&appid=439d4b804bc8187953eb36d2a8c26a02";
        public string pricingUrl = "https://home.openweathermap.org/pricing";
        public string windSpeedUrl = "themes/openweathermap/assets/vendor/mosaic/data/wind-speed-new-data.json";

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
