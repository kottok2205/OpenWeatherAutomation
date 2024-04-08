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

            for (int i = 0, j = 1; i < 8; i++, j++)
            {
                var dayElement = doc.DocumentNode.SelectSingleNode(@$"//*[@id=""weather-widget""]/div[3]/div[2]/div[2]/ul/li[{j}]/span");
                dateArray[i] = dayElement.InnerText;
            }

            return dateArray;
        }
    }
}
