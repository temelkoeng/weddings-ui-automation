using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Pages
{
    public class BasePage
    {
        protected WebDriverController _driver;
        protected string PageUrl { get; set; }

        public BasePage(WebDriverController driver)
        {
            this._driver = driver;
        }

        public void NavigateToPage()
        {
            _driver.NavigateToUrl(PageUrl);
        }
    }
}
