using OpenQA.Selenium;

namespace StudentBlue.AcceptanceTests.Admin.PageObjects
{
    public class SearchPage : AdminPageBase
    {
        protected override string PageUrl => "/Search";
        protected IWebElement link_AdvancedSearch, input_StudentId, btn_StudentIDSearch, input_FirstName, input_LastName, btn_NameSearch, input_EmailAddress, btn_EmailSearch;

        public SearchPage() : base()
        {
        }

        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        public string WelcomeMessage
        {
            get { return Driver.FindElement(By.CssSelector("div.welcome strong")).Text; }
        }

        public void EnterStudentId(string id)
        {
            input_StudentId = Driver.FindElement(By.Id("StudentId"));
            input_StudentId.SendKeys(id);
        }

        public void ClickSearchStudentIdButton()
        {
            btn_StudentIDSearch = Driver.FindElement(By.Id("studentIdSearchBtn"));
            btn_StudentIDSearch.Click();
        }

        public void EnterFirstName(string fname)
        {
            input_FirstName = Driver.FindElement(By.Id("FirstName"));
            input_FirstName.SendKeys(fname);
        }

        public void EnterLastName(string lname)
        {
            input_LastName = Driver.FindElement(By.Id("LastName"));
            input_LastName.SendKeys(lname);
        }

        public void ClickSearchByNameButton()
        {
            btn_NameSearch = Driver.FindElement(By.Name("searchBtn"));
            btn_NameSearch.Click();
        }

        public void EnterEmailAddress(string emailAddr)
        {
            input_EmailAddress = Driver.FindElement(By.Id("PrimaryEmailAddress"));
            input_EmailAddress.SendKeys(emailAddr);
        }

        public void ClickSearchByEmailButton()
        {
            btn_EmailSearch = Driver.FindElement(By.Id("emailSearchBtn"));
            btn_EmailSearch.Click();
        }

        public void ClickAdvancedSearchLink()
        {
            link_AdvancedSearch = Driver.FindElement(By.LinkText("Advanced Search"));
            link_AdvancedSearch.Click();
        }

        public new SearchPage NavigateTo()
        {
            return (SearchPage)base.NavigateTo();
        }
    }
}