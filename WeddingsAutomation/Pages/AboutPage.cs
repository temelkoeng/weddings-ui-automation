using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Pages
{
    public class AboutPage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/about";
            }
        }

        private By DescriptionTextLocator = By.XPath("//p[contains(text(), 'Описание')]");
        public AboutPage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsDescriptionTextDisplayed()
        {
            return _driver.IsElementDisplayed(DescriptionTextLocator);
        }

    }
}
