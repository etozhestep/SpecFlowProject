using OpenQA.Selenium;

namespace specFlowProject.Pages
{
    public class GettingStartedPage : BasePage
    {

        private static GettingStartedPage? gettingStartedPage;
        public static GettingStartedPage Instance => gettingStartedPage ?? (gettingStartedPage = new GettingStartedPage());

        public bool IsPageTitleDisplayed(string title)
        {
            return IsDisplayed(By.XPath($"//h1[contains(text(),'{title}')]"));
        }
    }
}
