using BaseDriverService;

namespace OpenWeatherApiTest
{
    public class BaseTest
    {
        public static HttpClient Client => BaseHttpClient.GetInstance();
        public string baseUrl = "https://openweathermap.org/";
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
