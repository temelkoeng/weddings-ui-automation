using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Tests
{
    public class BaseTest
    {
        protected WebDriverController driver;

        [OneTimeSetUp]
        public void Setup()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            driver = new WebDriverController(chromeDriver);
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            driver.QuitWebDriver();
        }
    }
}
