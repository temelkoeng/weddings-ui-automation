using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Pages
{
    public class GoogleHomePage
    {
        private WebDriverController _driver;
        private const string URL = "https://www.google.com";


        public GoogleHomePage(WebDriverController driver)
        {
            this._driver = driver;
        }

        public void GoToHomePage()
        {
            _driver.NavigateToUrl(URL);
        }
    }
}
