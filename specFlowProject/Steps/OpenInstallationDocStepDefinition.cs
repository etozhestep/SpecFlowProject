using specFlowProject.Base;
using specFlowProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace specFlowProject.Steps
{
    [Binding]
    public class OpenInstallationDocStepDefinition
    {
        [When(@"I click on '([^']*)' field")]
        public void ClickOnField(string fieldName)
        {
            SpecflowPage.Instance.ClickOnField(fieldName);
        }

        [When(@"I enter '([^']*)' on popup")]
        public void EnterOnPopupField(string textToEnter)
        {
            SpecflowPage.Instance.EnterTextOnPopupSearchField(textToEnter);
        }

        [When(@"I pick up search result '([^']*)'")]
        public void PickUpNecessarySearchResult(string resultNameToPick)
        {
         SpecflowPage.Instance.SelectItemFromSearchResults(resultNameToPick);
        }
        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
