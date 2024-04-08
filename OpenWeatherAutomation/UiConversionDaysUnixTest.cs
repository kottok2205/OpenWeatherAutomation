using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using PageObject;
using System.Text.RegularExpressions;

namespace OpenWeatherAutomation
{
    class UiConversionDaysUnixTest : BaseTest
    {
        [Test]
        public void ConversionUnix()
        {
            UiJsonElement elementsJson = new UiJsonElement();
            UiHtmlElement elementsHtml = new UiHtmlElement();
            Driver.Navigate().GoToUrl("https://openweathermap.org/data/2.5/onecall?lat=46.4775&lon=30.7326&units=metric&appid=439d4b804bc8187953eb36d2a8c26a02");

            // Чекаємо завантаження сторінки
            //await Task.Delay(5000); // Почекайте деякий час, щоб сторінка завантажилась (можливо, знадобиться налаштувати)

            // Отримуємо вміст сторінки
            string responseData = Driver.FindElement(By.TagName("body")).Text;

            // Нормалізуємо отриманий вміст (видаляємо зайві пробіли)
            var normalizedExpected = Regex.Replace(responseData, @"\s+", "");

            // Порівнюємо отримані дані з очікуваними
            ClassicAssert.AreEqual(elementsJson.dateArrayJson(normalizedExpected), elementsHtml.dateArrayHtml());

        }
    }
}
