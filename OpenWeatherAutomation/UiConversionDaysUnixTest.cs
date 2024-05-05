using NUnit.Framework.Legacy;
using PageObject;

namespace OpenWeatherAutomation
{
    class UiConversionDaysUnixTest : BaseTest
    {
        [Test]
        public async Task ConversionUnixTest()
        {
            var elementsJson = new UiJsonElement();
            var elementsHtml = new UiHtmlElement();

            var jsonDates = await elementsJson.GetDateArrayFromJsonAsync();
            var htmlDates = elementsHtml.GetDateArrayFromHtml();

            ClassicAssert.AreEqual(jsonDates, htmlDates);
        }
    }
}
