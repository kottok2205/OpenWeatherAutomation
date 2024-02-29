using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseDriverService
{
    public class BaseDriver
    {
        public static IWebDriver driver;

        private BaseDriver() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }
        public static void QuitInstance()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
