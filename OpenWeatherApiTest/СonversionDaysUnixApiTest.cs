using NUnit.Framework.Legacy;

namespace OpenWeatherApiTest
{
    public class �onversionDaysUnixApiTest : BaseTest
    {
        [TestCase("city", "703448")]
        [TestCase("city", "698740")]
        [TestCase("city", "706483")]
        [Test]
        public async Task �onversionDaysUnixTest(string category, string idCity)
        {
            HttpResponseMessage response = await Client.GetAsync(baseUrl);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}