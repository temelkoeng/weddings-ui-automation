using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingsAutomation.Utilities
{
    public class WebDriverController
    {
        private readonly IWebDriver _driver;
        
        public WebDriverController(IWebDriver driver)
        {
            this._driver = driver;
        }

        public void QuitWebDriver()
        {
            _driver.Quit();
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }
    }
}
