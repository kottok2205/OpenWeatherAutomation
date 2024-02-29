using OpenQA.Selenium;

namespace PageObject
{
    public class PartnersPage : BasePage
    {
        private By partnerPythonLocator = By.LinkText("Python");
        private By partnerUbuntuLocator = By.LinkText("Ubuntu");
        public By pythonIdLocator = By.Id("python");

        public IWebElement partnerPython => Driver.FindElement(partnerPythonLocator);
        public IWebElement partnerUbuntu => Driver.FindElement(partnerUbuntuLocator);
        public void PartnerClick(IWebElement element) => element.Click();

        public bool PartnerCheck(By element)
        {
            bool partnerCheck = Driver.FindElement(element).Displayed;
            return partnerCheck;
        }
    }
}
