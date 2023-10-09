using NUnit.Framework;
using OpenQA.Selenium;
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
            driver = new WebDriverController();    //PLS UPDATE?!??!?!?
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            driver.QuitWebDriver();
        }
    }
}
