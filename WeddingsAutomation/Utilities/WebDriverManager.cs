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
                    _driver = new ChromeDriver();
                
                return _driver;
            }
        }

        public static void QuitDriver()
        {
            _driver.Quit();
        }
    }
}
