using OpenQA.Selenium;
using StudentBlue.AcceptanceTests.Common;

namespace StudentBlue.AcceptanceTests.Admin.PageObjects
{
    public abstract class AdminPageBase : PageBase
    {
        public AdminPageBase() : base()
        {
        }

        public AdminPageBase(IWebDriver driver) : base(driver)
        {
        }

        protected override string BaseUrl => TestSettings.BaseUrl;
    }
}

