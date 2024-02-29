using OpenQA.Selenium;
using BaseDriverService;

namespace OpenWeatherAutomation
{
    [SetUpFixture]
    public static class SetUpOneTime
    {
        private static IWebDriver Driver => BaseDriver.GetInstance();

        [OneTimeSetUp]
        public static void SetUp()
        {
            //BaseDriver.GetInstance();
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            BaseDriver.QuitInstance();
        }
    }
    public class BaseTest
    {
        protected IWebDriver Driver => BaseDriver.GetInstance();

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("https://openweathermap.org/");
        }
    }
}
