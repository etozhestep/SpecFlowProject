using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using specFlowProject.Base;

namespace specFlowProject.Pages
{
    public class SpecflowPage : BasePage
    {
        private string fieldXpath => "//input[@type='text']"\;
        private string popupSearchFieldXpath => "//input[@class='search__outer__input']";
        private string searchingSignXpath => "//strong[text()='Searching ....']";
        private string searchResultsXpath => "//h2[@class='search__result__title']//span";

        private static SpecflowPage specflowPage;
        public static SpecflowPage Instance => specflowPage ?? (specflowPage = new SpecflowPage());

        public void ClickOnField(string fieldName)
        {
            var fieldElement = FindElements(By.XPath(fieldXpath)).First(x => x.GetAttribute("placeholder").Equals(fieldName));
            fieldElement.Click();
        }
        public void EnterTextOnPopupSearchField(string textToSearch)
        {
            if (IsDisplayed(By.XPath(popupSearchFieldXpath)))
            {
                var searchField = FindElement(By.XPath(popupSearchFieldXpath));
                var actions = new Actions(DriverManager.Instance());
                searchField.Click();
                actions.MoveToElement(searchField).SendKeys(textToSearch).Perform();
                WaitInvisibilityOfElement(By.XPath(searchingSignXpath));
            }
        }
        public void SelectItemFromSearchResults(string itemName)
        {
            FindElements(By.XPath(searchResultsXpath)).First(x => x.Text.Contains(itemName)).Click();
        }
    }
}
