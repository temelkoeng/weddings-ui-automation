using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingsAutomation.Utilities
{
    public static class WebDriverManager
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    var options = new ChromeOptions();
                    options.AddArgument("--headless=new");
                    _driver = new ChromeDriver();

                    _driver.Manage().Window.Maximize();

                }

                return _driver;
            }
        }
    }
}
