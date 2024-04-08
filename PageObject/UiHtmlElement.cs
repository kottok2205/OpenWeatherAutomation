using OpenQA.Selenium;

namespace PageObject
{
    public class UiHtmlElement : BasePage
    {
        public string[] dateArrayHtml()
        {
            Driver.Navigate().GoToUrl("https://openweathermap.org/city/698740");

            string[] dateArray = new string[8];

            WaitForPageLoadedOn(By.XPath(@$"//*[@id=""weather-widget""]/div[3]/div[2]/div[2]/ul/li[1]/span"));

            for (int i = 0, j = 1; i < 8; i++, j++)
            {
                var dayElement = Driver.FindElement(By.XPath(@$"//*[@id=""weather-widget""]/div[3]/div[2]/div[2]/ul/li[{j}]/span"));
                var dateText = dayElement.Text;
                dateArray[i] = dateText;
            }
            return dateArray;
        }
    }
}
