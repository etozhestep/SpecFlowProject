using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using specFlowProject.Base;

namespace specFlowProject.Pages
{
    public class BasePage
    {
        private static BasePage basePage;
        public static BasePage Instance => basePage ?? (basePage = new BasePage());
        public BasePage()
        {

        }
        public IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }

        public bool IsDisplayed(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(d => DriverManager.Instance().FindElement(locator).Displayed);
        }
        public void WaitInvisibilityOfElement(By locator, int timeout = 20)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
        }
        public bool IsPageTitleDisplayed(string title)
        {
            return IsDisplayed(By.XPath($"//h1[contains(text(),'{title}')]"));
        }
    }
}
