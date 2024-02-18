using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class PartnersPage : BasePage
    {
        //public PartnersPage(IWebDriver driver) : base(driver) { }
        private By partnerPythonLocator = By.LinkText("Python");
        public By pythonIdLocator = By.Id("python");
        public IWebElement partner => Driver.FindElement(partnerPythonLocator);
        public void PartnerClick(IWebElement element) => element.Click();

        public bool PartnerCheck(By element)
        {
            Boolean partnerCheck = Driver.FindElement(element).Displayed;
            return partnerCheck;
        }
        //public Boolean partnerCheck => Driver.FindElement(pythonIdLocator).Displayed;
    }
}
