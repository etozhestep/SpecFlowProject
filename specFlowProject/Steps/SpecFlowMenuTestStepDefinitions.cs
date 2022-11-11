using NUnit.Framework;
using specFlowProject.Base;
using specFlowProject.Pages;
using TechTalk.SpecFlow;

namespace specFlowProject.Steps
{
    [Binding]
    public class SpecFlowMenuTestStepDefinitions
    {
        private readonly ScenarioContext context;
        public SpecFlowMenuTestStepDefinitions(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I open official Specflow web site")]
        public void OpenOfficialSpecflowWebSite()
        {
            HomePage.Instance.OpenSpecflowHomePage();
        }

        [When(@"I hover the '([^']*)' menu item from the main menu")]
        public void HoverTheMenuItemFromTheMainMenu(string menuItem)
        {
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"I click '([^']*)' option from the main menu")]
        public void ClickOptionFromTheMainMenu(string option)
        {
            HomePage.Instance.ClickSubMenuItem(option);
        }

        [Then(@"The page '([^']*)' should be opened")]
        public void PageShouldBeOpened(string title)
        {
            Assert.IsTrue(BasePage.Instance.IsPageTitleDisplayed(title), "Page title for the page is not displayed");
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
