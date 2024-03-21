using NUnit.Framework.Legacy;

namespace OpenWeatherApiTest
{
    public class ÑonversionDaysUnixApiTest : BaseTest
    {
        [Test]
        public async Task ÑonversionDaysUnixTest()
        {
            HttpResponseMessage response = await Client.GetAsync(baseUrl + requestUrl);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}