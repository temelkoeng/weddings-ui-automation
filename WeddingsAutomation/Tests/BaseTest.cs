using NUnit.Framework;
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
            driver = new WebDriverController(WebDriverManager.Driver);
        }

        [TearDown]
        public void Teardown()
        {
            driver.QuitWebDriver();
        }
    }
}
