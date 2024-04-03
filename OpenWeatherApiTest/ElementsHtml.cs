using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using HtmlAgilityPack;

namespace OpenWeatherApiTest
{
    public class ElementsHtml
    {
        public string[] dateArrayHtml()
        {
            var url = "https://openweathermap.org/city/703448";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            string[] dateArray = new string[8];

            // Очікуємо, доки не буде знайдений хоча б один елемент відповідно до виразу XPath
            for (int i = 0, j = 1; i < 8; i++, j++)
            {
                var dayElement = doc.DocumentNode.SelectNodes(@$"//*[@id=""weather-widget""]/div[2]/div[2]/div[2]/ul/li[{j}]/span");
                dateArray[i] = dayElement[i].InnerText.Trim();
            }

            return dateArray;
        }
    }
}
