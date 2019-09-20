using OpenQA.Selenium;

namespace StudentBlue.AcceptanceTests.Admin.PageObjects
{
    public class UniversityConfigurationPage : AdminPageBase
    {
        protected override string PageUrl => "University/Configuration";

        public UniversityConfigurationPage() : base()
        {
        }

        public UniversityConfigurationPage(IWebDriver driver) : base(driver)
        {
        }

        public new UniversityConfigurationPage NavigateTo()
        {
            return (UniversityConfigurationPage)base.NavigateTo();
        }
    }
}
