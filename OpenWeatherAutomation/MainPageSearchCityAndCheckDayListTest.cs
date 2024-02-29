using NUnit.Framework.Legacy;
using PageObject;

namespace OpenWeatherAutomation
{
    [TestFixture]
    public class MainPageSearchCityAndCheckDayListTest : BaseTest
    {
        private static readonly string[] Cities = { "Kyiv", "Odessa", "Kharkiv" };

        [Test]
        [TestCaseSource(nameof(Cities))]
        public void CheckingWeatherCities(string cityName)
        {
            MainPage mainPage = new MainPage();
            mainPage.WaitForPageLoadedOff(mainPage.waitingLoaderSelector);
            mainPage.SearchInputText(cityName);
            mainPage.SearchButtonClick();
            mainPage.WaitForPageLoadedOn(mainPage.dropDownMenuLocator);
            mainPage.DropDownMenuClick();
            mainPage.Scrolling(mainPage.DayList);

            ClassicAssert.AreEqual(8, mainPage.daysQuantity);
        }
    }
}
