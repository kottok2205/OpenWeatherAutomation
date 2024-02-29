using PageObject;

namespace OpenWeatherAutomation
{
    [TestFixture]
    public class CheckPartnersTest : BaseTest
    {
        public static PartnersPage partnersPage;
        public static HeaderSelection headerSelection;

        public static PartnersPage Partners()
        {
            if (partnersPage == null)
            {
                partnersPage = new PartnersPage();
            }
            return partnersPage;
        }
        public static HeaderSelection Header()
        {
            if (headerSelection == null)
            {
                headerSelection = new HeaderSelection();
            }
            return headerSelection;
        }

        [Test]
        public void CheckPython()
        {
            Partners().WaitForPageLoadedOff(Partners().waitingLoaderSelector);
            Header().OpenMenuItem("Partners");

            //Check partner Python
            Partners().PartnerClick(Partners().partnerPython);
            Assert.That(Partners().PartnerCheck(Partners().pythonIdLocator));
        }
        [Test]
        public void CheckUbuntu()
        {
            partnersPage.WaitForPageLoadedOff(partnersPage.waitingLoaderSelector);
            Header().OpenMenuItem("Partners");

            //Check partner Ubuntu
            partnersPage.PartnerClick(partnersPage.partnerUbuntu);
            Assert.That(partnersPage.PartnerCheck(partnersPage.pythonIdLocator));
        }
    }

}
