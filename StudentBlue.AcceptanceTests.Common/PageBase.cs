using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace StudentBlue.AcceptanceTests.Common
{
    public abstract class PageBase
    {
        protected abstract string PageUrl { get; }
        protected abstract string BaseUrl { get; }

        public IWebDriver Driver { get; }

        public PageBase()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService("webdriver.chrome.driver", @"C:\\DRIVERS\\chromedriver.exe");
            Driver = new ChromeDriver(service);
        }

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        public PageBase NavigateTo()
        {
            Driver.Navigate().GoToUrl($"{BaseUrl}/{PageUrl}");
            return (PageBase)Activator.CreateInstance(GetType(), Driver);
        }
    }
}
