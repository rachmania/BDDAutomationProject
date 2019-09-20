using OpenQA.Selenium;
using System;

namespace StudentBlue.AcceptanceTests.Admin.PageObjects
{
    class PageObjectTemplate : AdminPageBase
    {
        //  Variables
        protected override string PageUrl => "/";

        //  Constructor
        public PageObjectTemplate() : base()
        {
        }

        public PageObjectTemplate(IWebDriver driver) : base(driver)
        {
        }



        public new PageObjectTemplate NavigateTo()
        {
            return (PageObjectTemplate)base.NavigateTo();
        }
    }
}

