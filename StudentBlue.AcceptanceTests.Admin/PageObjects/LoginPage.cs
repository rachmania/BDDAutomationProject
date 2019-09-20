using OpenQA.Selenium;

namespace StudentBlue.AcceptanceTests.Admin.PageObjects
{
    public class LoginPage : AdminPageBase
    {
        protected override string PageUrl => "Account/Login";

        public LoginPage() : base()
        {
        }

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public string Username
        {
            set { Driver.FindElement(By.Id("UserName")).SendKeys(value); }
        }

        public string Password
        {
            set { Driver.FindElement(By.Id("Password")).SendKeys(value); }
        }

        public string ErrorMessage
        {
            get { return Driver.FindElement(By.CssSelector("div.validation-summary-errors ul li")).Text; }
        }

        public HomePage LogInSubmit()
        {
            Driver.FindElement(By.CssSelector("div.buttons input[type=submit]")).Click();

            return new HomePage(Driver);
        }

        public HomePage LogInAsSBAdmin()
        {
            NavigateTo();
            Username = TestSettings.SBAdminUsername;
            Password = TestSettings.Password;
            LogInSubmit();

            return new HomePage(Driver);
        }

        public new LoginPage NavigateTo()
        {
            return (LoginPage)base.NavigateTo();
        }
    }
}
