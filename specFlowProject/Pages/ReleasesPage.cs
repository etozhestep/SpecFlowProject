using OpenQA.Selenium;

namespace specFlowProject.Pages
{
    public class ReleasesPage : BasePage
    {

        private static ReleasesPage? gettingStartedPage;
        public static ReleasesPage Instance => gettingStartedPage ?? (gettingStartedPage = new ReleasesPage());

        public bool IsPageTitleDisplayed(string title)
        {
            return IsDisplayed(By.XPath($"//h1[contains(text(),'{title}')]"));
        }
    }
}
