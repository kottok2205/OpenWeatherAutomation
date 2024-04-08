using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PageObject
{
    public class UiJsonElement
    {
        public string[] dateArrayJson(string jsonFile)
        {
            CultureInfo culture = new CultureInfo("en-US");

            JsonDocument jsonDoc = JsonDocument.Parse(jsonFile);

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
