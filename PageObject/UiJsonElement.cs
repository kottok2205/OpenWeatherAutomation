
namespace PageObject
{
    public class UiJsonElement : BasePage
    {
        //public static void SelDriver()
        //{
        //    var service = ChromeDriverService.CreateDefaultService();
        //    service.LogPath = AppDomain.CurrentDomain.BaseDirectory + "chromedriver.log";
        //    service.EnableVerboseLogging = true;

        //    var options = new ChromeOptions();

        //    var webDriver = new ChromeDriver(service, options);

        //    var devToolsSession = webDriver.GetDevToolsSession();
        //    devToolsSession.GetVersionSpecificDomains<NetworkDomain>(out var network).Enable(new EnableCommandSettings());
        //}






















        //public string[] dateArrayJson()
        //{
        //    Driver.Navigate().GoToUrl("https://openweathermap.org/data/2.5/onecall?lat=46.4775&lon=30.7326&units=metric&appid=439d4b804bc8187953eb36d2a8c26a02");

        //    string responseData = Driver.FindElement(By.TagName("body")).Text;

        //    var normalizedExpected = Regex.Replace(responseData, @"\s+", "");

        //    CultureInfo culture = new CultureInfo("en-US");

        //    JsonDocument jsonDoc = JsonDocument.Parse(normalizedExpected);

        //    var root = jsonDoc.RootElement;
        //    var dailyArray = root.GetProperty("daily");
        //    JsonElement[] dtArray = dailyArray.EnumerateArray().Select(x => x.GetProperty("dt")).ToArray();

        //    string[] dateArray = new string[8];

        //    for (int i = dtArray.Length - 8, j = 0; i < dtArray.Length; i++, j++)
        //    {
        //        long unixTime = dtArray[i].GetInt64();

        //        var dateTime = DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;

        //        var formattedDate = dateTime.ToString("ddd, MMM dd", culture);
        //        dateArray[j] = formattedDate;
        //    }
        //    return dateArray;
        //}
    }
}
