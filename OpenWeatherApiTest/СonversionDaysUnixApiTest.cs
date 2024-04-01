using NUnit.Framework.Legacy;
using System.Text.RegularExpressions;

namespace OpenWeatherApiTest
{
    public class ConversionDaysUnixApiTest : BaseTest
    {
        [Test]
        public async Task ConversionDaysUnixTest()
        {
            ElementsJson elementsJson = new ElementsJson();
            ElementsHtml elementsHtml = new ElementsHtml();

            HttpResponseMessage response = await Client.GetAsync(requestUrl);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);

            string responseData = await response.Content.ReadAsStringAsync();
            System.Console.WriteLine(responseData);
            var normalizedExpected = Regex.Replace(responseData, @"\s+", "");

            ClassicAssert.AreEqual(elementsJson.dateArrayJson(normalizedExpected), elementsHtml.dateArrayHtml());
        }
    }
}