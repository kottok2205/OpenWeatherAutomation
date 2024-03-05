using PageObject;

namespace OpenWeatherAutomation
{
    [TestFixture]
    public class CheckPartnersTest : BaseTest
    {
        private PartnersPage _partnersPage;
        private HeaderSelection _headerSelection;

        public PartnersPage PartnersPage
        {
            get
            {
                if (_partnersPage == null)
                {
                    _partnersPage = new PartnersPage();
                }
                return _partnersPage;
            }
        }

        public HeaderSelection HeaderSelection
        {
            get
            {
                if (_headerSelection == null)
                {
                    _headerSelection = new HeaderSelection();
                }
                return _headerSelection;
            }
        }

        [Test]
        public void CheckPython()
        {
            PartnersPage.WaitForPageLoadedOff(PartnersPage.waitingLoaderSelector);
            HeaderSelection.OpenMenuItem("Partners");

            //Check partner Python
            PartnersPage.PartnerClick(PartnersPage.partnerPython);
            Assert.That(PartnersPage.PartnerCheck(PartnersPage.pythonIdLocator));
        }

        [Test]
        public void CheckUbuntu()
        {
            PartnersPage.WaitForPageLoadedOff(PartnersPage.waitingLoaderSelector);
            HeaderSelection.OpenMenuItem("Partners");

            //Check partner Ubuntu
            PartnersPage.PartnerClick(PartnersPage.partnerUbuntu);
            Assert.That(PartnersPage.PartnerCheck(PartnersPage.pythonIdLocator));
        }
    }
}
