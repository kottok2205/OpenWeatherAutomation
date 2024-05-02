using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using Network = OpenQA.Selenium.DevTools.V124.Network;
using DevToolsSessionDomains = OpenQA.Selenium.DevTools.V124.DevToolsSessionDomains;
using System.Globalization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace PageObject
{
    public class UiJsonElement : BasePage
    {
        //static ChromeDriver driver = new ChromeDriver();
        static IDevTools devTools = Driver;
        static IDevToolsSession session = devTools.GetDevToolsSession();
        static DevToolsSessionDomains domains = session.GetVersionSpecificDomains<DevToolsSessionDomains>();
        static string jsonUrl = null;

        public async Task TestAsync()
        {
            var contentType = new List<string>();
            //string jsonUrl = null;

            domains.Network.ResponseReceived += (sender, e) =>
            {
                if (e.Response.Url.Contains("onecall?"))
                {
                    // Виводимо URL запиту
                    Console.WriteLine("URL: " + e.Response.Url);
                    jsonUrl = e.Response.Url;
                }
            };

            await domains.Network.Enable(new Network.EnableCommandSettings());

            Driver.Navigate().GoToUrl("https://openweathermap.org/city/703448");
            await Task.Delay(5000);

        }
        public string[] dateArrayJson()
        {
            TestAsync();
            Thread.Sleep(10000);

            Driver.Navigate().GoToUrl(jsonUrl);

            string responseData = Driver.FindElement(By.TagName("body")).Text;

            var normalizedExpected = Regex.Replace(responseData, @"\s+", "");

            CultureInfo culture = new CultureInfo("en-US");

            JsonDocument jsonDoc = JsonDocument.Parse(normalizedExpected);

            var root = jsonDoc.RootElement;
            var dailyArray = root.GetProperty("daily");
            JsonElement[] dtArray = dailyArray.EnumerateArray().Select(x => x.GetProperty("dt")).ToArray();

            string[] dateArray = new string[8];

            for (int i = dtArray.Length - 8, j = 0; i < dtArray.Length; i++, j++)
            {
                long unixTime = dtArray[i].GetInt64();

                var dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;

                var formattedDate = dateTime.ToString("ddd, MMM dd", culture);
                dateArray[j] = formattedDate;
            }
            return dateArray;
        }
    }
}

