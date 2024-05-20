using BaseDriverService;

namespace OpenWeatherApiTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();

        public string baseUrl = "http://openweathermap.org/";
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
