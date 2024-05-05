using OpenQA.Selenium;

namespace PageObject
{
    public class MainPage : BasePage
    {
        private By searchInputLocator = By.CssSelector(".search-container > input");
        public By searchButtonLocatot = By.CssSelector(".button-round");
        private By dayListLocator = By.CssSelector(".day-list");
        public By dropDownMenuLocator = By.CssSelector(".search-dropdown-menu > li:nth-child(1)");

        private IWebElement SearchInput => Driver.FindElement(searchInputLocator);
        public IWebElement SearchButton => Driver.FindElement(searchButtonLocatot);
        public IWebElement DayList => Driver.FindElement(dayListLocator);
        public IWebElement DropDownMenu => Driver.FindElement(dropDownMenuLocator);
        public int daysQuantity => Driver.FindElements(By.CssSelector(".day-list > li:nth-child(n)")).Count;

        public void SearchInputText(string text) => SearchInput.SendKeys(text);
        public void SearchButtonClick() => SearchButton.Click();
        public void DropDownMenuClick() => DropDownMenu.Click();
    }
}
