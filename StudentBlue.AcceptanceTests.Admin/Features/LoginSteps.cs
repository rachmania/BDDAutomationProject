using StudentBlue.AcceptanceTests.Admin.PageObjects;
using TechTalk.SpecFlow;
using Shouldly;

namespace StudentBlue.AcceptanceTests.Admin.Features
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            _loginPage = new LoginPage();
            _loginPage.NavigateTo();
        }

        [Given(@"I have entered username '(.*)'")]
        public void GivenIHaveEnteredUsername(string p0)
        {
            _loginPage.Username = p0;
        }

        [Given(@"I have entered password '(.*)'")]
        public void GivenIHaveEnteredPassword(string p0)
        {
            _loginPage.Password = p0;
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            _homePage = _loginPage.LogInSubmit();
        }

        [Then(@"I should be at the SBAdmin Home Page")]
        public void ThenIShouldBeAtTheSBAdminHomePage()
        {
            _homePage.WelcomeMessage.ShouldStartWith("Welcome");           
        }

        [Then(@"I should be at the login page")]
        public void ThenIShouldBeAtTheLoginPage()
        {
            _loginPage.ErrorMessage.ShouldBe("The user name or password provided is incorrect.");
        }

        [AfterScenario("login")]
        public void CloseWindows()
        {
            _loginPage.Driver.Close();
            _loginPage.Driver.Quit();
        }
    }
}
