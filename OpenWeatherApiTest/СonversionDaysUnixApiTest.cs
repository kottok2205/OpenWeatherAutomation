using NUnit.Framework.Legacy;

namespace OpenWeatherApiTest
{
    public class �onversionDaysUnixApiTest : BaseTest
    {
        [Test]
        public async Task �onversionDaysUnixTest()
        {
            HttpResponseMessage response = await Client.GetAsync(baseUrl + requestUrl);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}