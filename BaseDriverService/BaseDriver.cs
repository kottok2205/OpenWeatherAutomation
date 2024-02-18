using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseDriverService
{
    public class BaseDriver
    {
        // Приватне поле для зберігання єдиного екземпляра ChromeDriver
        public static IWebDriver driver;

        // Приватний конструктор, щоб не дозволити створення екземплярів ззовні
        private BaseDriver() { }

        // Метод для отримання єдиного екземпляра ChromeDriver
        public static IWebDriver GetInstance()
        {
            // Якщо екземпляр ще не було створено, створити його
            if (driver == null)
            {
                //ChromeOptions options = new ChromeOptions();
                //// Налаштування ChromeOptions (необов'язково)
                //options.AddArgument("--start-maximized"); // Наприклад, максимізувати вікно браузера

                driver = new ChromeDriver();
            }

            // Повернути єдиний екземпляр ChromeDriver
            return driver;
        }
        public static void QuitInstance()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
