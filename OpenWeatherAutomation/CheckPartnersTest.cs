using NUnit.Framework;
using PageObject;

namespace OpenWeatherAutomation
{
    public class CheckPartnersTest : SetUpAndTearDown
    {
        [Test]
        public void Test2()
        {
            PartnersPage partnersPage = new PartnersPage();
            HeaderSelection headerSelection = new HeaderSelection();

            partnersPage.WaitForPageLoadedOff(partnersPage.waitingLoaderSelector);
            headerSelection.OpenMenuItem("Partners");
            
            //Check partner Python
            partnersPage.PartnerClick(partnersPage.partner);
            Assert.That(partnersPage.PartnerCheck(partnersPage.pythonIdLocator));
        }
    }
}
