using OpenQA.Selenium;

namespace PageObject
{
    public class UiHtmlElement : BasePage
    {
        public string[] GetDateArrayFromHtml()
        {
            Driver.Navigate().GoToUrl("https://openweathermap.org/city/698740");
            WaitForPageLoadedOn(By.XPath(@$"//*[@id=""weather-widget""]/div[3]/div[2]/div[2]/ul/li[1]/span")); // Assumes this is implemented in BasePage

            return Enumerable.Range(1, 8).Select(i =>
            {
                var dayElement = Driver.FindElement(By.XPath($"//*[@id='weather-widget']/div[3]/div[2]/div[2]/ul/li[{i}]/span"));
                return dayElement.Text;
            }).ToArray();
        }
    }
}
