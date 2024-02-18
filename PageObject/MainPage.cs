using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class MainPage : BasePage
    {
        private By searchInputLocator = By.CssSelector(".search-container > input");
        private By searchButtonLocatot = By.CssSelector(".button-round");
        private By dayListLocator = By.CssSelector(".day-list");
        public By dropDownMenuLocator = By.CssSelector(".search-dropdown-menu > li:nth-child(1)");

        //public MainPage(IWebDriver Driver) : base(Driver) { }

        private IWebElement SearchInput => Driver.FindElement(searchInputLocator);
        public IWebElement SearchButton => Driver.FindElement(searchButtonLocatot);
        public IWebElement DayList => Driver.FindElement(dayListLocator);
        public IWebElement DropDownMenu => Driver.FindElement(dropDownMenuLocator);
        public int daysQuantity => Driver.FindElements(By.CssSelector(".day-list > li:nth-child(n)")).Count;

        public void SearchInputText(string text) => SearchInput.SendKeys(text);
        public void SearchButtonClick() => SearchButton.Click();
        public void DropDownMenuClick() => DropDownMenu.Click();





        //[How.Css(".button-round")]
        //WebButton search;

        /*public void AmountOfDays()
        {
            int day = driver.FindElements(By.CssSelector(".day-list > li:nth-child(n)")).Count;
            if (day == 8) { }
            else
            {
                throw new Exception("Error: Invalid number of days");
            }
        }*/
    }
}
