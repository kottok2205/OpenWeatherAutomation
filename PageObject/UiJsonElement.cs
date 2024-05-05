﻿using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using Network = OpenQA.Selenium.DevTools.V124.Network;
using DevToolsSessionDomains = OpenQA.Selenium.DevTools.V124.DevToolsSessionDomains;
using System.Globalization;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PageObject
{
    public class UiJsonElement : BasePage
    {
        private IDevTools devTools;
        private DevToolsSessionDomains domains;

        public UiJsonElement()
        {
            this.devTools = Driver as IDevTools;
            this.domains = devTools.GetDevToolsSession().GetVersionSpecificDomains<DevToolsSessionDomains>();
        }

        public async Task<string[]> GetDateArrayFromJsonAsync()
        {
            string jsonUrl = await FetchJsonUrlAsync();
            if (string.IsNullOrEmpty(jsonUrl))
            {
                throw new InvalidOperationException("JSON URL not found.");
            }

            Driver.Navigate().GoToUrl(jsonUrl);
            //await Task.Delay(5000); // Wait for page to load completely

            string responseData = Driver.FindElement(By.TagName("body")).Text;
            responseData = Regex.Replace(responseData, @"\s+", "");

            return ExtractDatesFromJson(responseData);
        }

        private async Task<string> FetchJsonUrlAsync()
        {
            string jsonUrl = null;
            await domains.Network.Enable(new Network.EnableCommandSettings());

            var responseListener = new TaskCompletionSource<string>();
            domains.Network.ResponseReceived += (sender, e) =>
            {
                if (e.Response.Url.Contains("onecall?"))
                {
                    responseListener.TrySetResult(e.Response.Url);
                }
            };

            Driver.Navigate().GoToUrl("https://openweathermap.org/city/703448");
            //await Task.Delay(5000); // Ensure the network request is captured
            return await responseListener.Task;
        }

        private string[] ExtractDatesFromJson(string jsonData)
        {
            JsonDocument jsonDoc = JsonDocument.Parse(jsonData);
            var dailyArray = jsonDoc.RootElement.GetProperty("daily");
            return dailyArray.EnumerateArray()
                             .Select(x => x.GetProperty("dt").GetInt64())
                             .Select(unixTime => DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime.ToString("ddd, MMM dd", new CultureInfo("en-US")))
                             .ToArray();
        }
    }
}