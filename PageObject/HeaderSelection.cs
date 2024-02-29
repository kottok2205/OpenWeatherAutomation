using OpenQA.Selenium;

namespace PageObject
{
    public class HeaderSelection : BasePage
    {
        public void OpenMenuItem(string itemName) => Driver.FindElement(By.LinkText(itemName)).Click();
    }
}
