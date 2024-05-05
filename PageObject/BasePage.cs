using BaseDriverService;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace PageObject
{
    public class BasePage
    {

        protected static ChromeDriver Driver => BaseDriver.GetInstance();

        public By waitingLoaderSelector = By.CssSelector(".owm-loader-container");

        public void WaitForPageLoadedOff(By element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(element));
        }
        public void WaitForPageLoadedOn(By element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
        public void WaitForButtonClickable(By element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        public void Scrolling(IWebElement element)
        {
            WheelInputDevice.ScrollOrigin scroll = new WheelInputDevice.ScrollOrigin
            {
                Element = element
            };
            new Actions(Driver)
                .ScrollFromOrigin(scroll, 0, 200)
                .Perform();
        }
    }
}
