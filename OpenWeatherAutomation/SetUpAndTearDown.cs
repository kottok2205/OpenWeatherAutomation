using OpenQA.Selenium;
using BaseDriverService;

namespace OpenWeatherAutomation
{
    public class SetUpAndTearDown
    {
        protected IWebDriver Driver => BaseDriver.GetInstance();

        [SetUp]
        public void SetUp()
        {
            BaseDriver.GetInstance();
            Driver.Navigate().GoToUrl("https://openweathermap.org/");

        }

        //[OneTimeTearDown]
        //public void TearDown()
        //{
        //    BaseDriver.QuitInstance();
        //}
    }
}
