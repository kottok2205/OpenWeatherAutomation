using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace OpenWeatherApiTest
{
    public class ElementsHtml
    {
        public string[] dateArrayHtml()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");

            var driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://openweathermap.org/city/703448");

            string[] dateArray = new string[8];

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            for (int i = 0, j = 1; i < 8; i++, j++)
            {
                var dayElement = driver.FindElement(By.XPath(@$"//*[@id=""weather-widget""]/div[2]/div[2]/div[2]/ul/li[{j}]/span"));
                var dateText = dayElement.Text;
                dateArray[i] = dateText;
            }
            return dateArray;
        }
    }
}
