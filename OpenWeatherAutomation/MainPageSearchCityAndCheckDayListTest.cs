using NUnit.Framework;
using NUnit.Framework.Legacy;
using PageObject;

namespace OpenWeatherAutomation
{
    public class MainPageSearchCityAndCheckDayListTest : SetUpAndTearDown
    {
        [Test]
        public void Test1()
        {
            MainPage mainPage = new MainPage();
            mainPage.WaitForPageLoadedOff(mainPage.waitingLoaderSelector);
            mainPage.SearchInputText("Kyiv");
            //mainPage.WaitForPageLoaded();
            mainPage.SearchButtonClick();
            mainPage.WaitForPageLoadedOn(mainPage.dropDownMenuLocator);
            mainPage.DropDownMenuClick();
            mainPage.Scrolling(mainPage.DayList);

            ClassicAssert.AreEqual(8, mainPage.daysQuantity);
        }
    }
}
