using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using specFlowProject.Base;

namespace specFlowProject.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://specflow.org";
        private string SubMenuItemXpath => "//ul[@class='sub-menu']/child::li[contains(@class,'menu-item')]//a";
        private string MainMenuItemXpath => "//ul[@id='menu-main-navigation']/child::li[contains(@class,'menu-item')]";


        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        public void OpenSpecflowHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(MainMenuItemXpath)).First(x => x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }
        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(SubMenuItemXpath)).First(x => x.Text.Equals(item));
            subMenuItem.Click();
        }
    }
}
