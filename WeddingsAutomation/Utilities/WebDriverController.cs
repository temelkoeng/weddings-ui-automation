using NUnit.Framework;
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

        public void ClickElement(By elementLocator)
        {
            IWebElement element =  _driver.FindElement(elementLocator);
            element.Click();
        }

        public bool IsAttributePresented(By elementLocator, string expectedCondition, string attribute)
        {
            IWebElement element = _driver.FindElement(elementLocator);
            return element.GetAttribute(attribute).Contains(expectedCondition);
        }

        public void SwitchToAlert()
        {
            _driver.SwitchTo().Alert();
        }

        public bool IsElementDisplayed(By elementLocator)
        {
            return _driver.FindElement(elementLocator).Displayed;
        }

        public bool IsElementEnaled(By elementLocator)
        {
            return _driver.FindElement(elementLocator).Enabled;
        }

        public string GetUsername()
        {
            return TestContext.Parameters.Get("username");
        }

        public string GetPassword()
        {
            return TestContext.Parameters.Get("password");
        }
    }
}
