using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseDriverService
{
    public class BaseDriver
    {
        public static ChromeDriver driver;

        private BaseDriver() { }

        public static ChromeDriver GetInstance()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--window-size=1920,1080");
            if (driver == null)
            {
                driver = new ChromeDriver(options);
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
