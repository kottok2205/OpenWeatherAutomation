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

            var nodes = doc.DocumentNode.SelectNodes("//*[@id='weather-widget']/div[2]/div[2]/div[2]/ul/li/span");

            if (nodes != null)
            {
                for (int i = 0; i < 8 && i < nodes.Count; i++)
                {
                    dateArray[i] = nodes[i].InnerText.Trim();
                }
            }

            return dateArray;
        }
    }
}
