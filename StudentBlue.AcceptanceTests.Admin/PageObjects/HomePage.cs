using OpenQA.Selenium;

namespace StudentBlue.AcceptanceTests.Admin.PageObjects
{
    public class HomePage : AdminPageBase
    {
        protected override string PageUrl => "/";
        protected IWebElement span_OptionsWidget;
        protected IWebElement tab_Logout;

        public HomePage() : base()
        {
        }

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public string WelcomeMessage
        {
            get { return Driver.FindElement(By.CssSelector("div.welcome strong")).Text; }
        }

        public void ClickOptionsWidget(IWebDriver driver)
        {
            span_OptionsWidget = driver.FindElement(By.XPath("/html/body/div[1]/header/div[1]/nav/h3/span"));
            span_OptionsWidget.Click();
        }

        public void ClickLogoutTab(IWebDriver driver)
        {
            tab_Logout = driver.FindElement(By.Id("logoutForm"));
            tab_Logout.Click();
        }

        public new HomePage NavigateTo()
        {
            return (HomePage)base.NavigateTo();
        }
    }
}
