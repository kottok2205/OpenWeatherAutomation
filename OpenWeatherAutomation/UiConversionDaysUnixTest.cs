using NUnit.Framework.Legacy;
using PageObject;

namespace OpenWeatherAutomation
{
    class UiConversionDaysUnixTest : BaseTest
    {
        [Test]
        public void ConversionUnix()
        {
            UiJsonElement elementsJson = new UiJsonElement();
            UiHtmlElement elementsHtml = new UiHtmlElement();

            ClassicAssert.AreEqual(elementsJson.dateArrayJson(), elementsHtml.dateArrayHtml());

        }
    }
}
