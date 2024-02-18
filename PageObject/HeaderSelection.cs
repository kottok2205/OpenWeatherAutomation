using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class HeaderSelection : BasePage
    {
        //public HeaderSelection() : base() { }

        public void OpenMenuItem(string itemName) => Driver.FindElement(By.LinkText(itemName)).Click();
    }
}
