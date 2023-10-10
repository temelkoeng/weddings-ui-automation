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
        private By LogoButtonSelector = By.CssSelector(".logo img");
        private By PrivacyPolicyLocator = By.XPath("//span[contains(text(), 'Политика за поверителност')]/..");
        private By TermsOfUseLocator = By.XPath("//span[contains(text(), 'Условия за ползване')]/..");
        private By CookiesPolicyLocator = By.XPath("//span[contains(text(), 'Политика за използване на \"бисквитки\"')]/..");

        public AboutPage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsDescriptionTextDisplayed()
        {
            return _driver.IsElementDisplayed(DescriptionTextLocator);
        }

        public bool IsPrivacyPolicyButtonDisplayed()
        {
            return _driver.IsElementDisplayed(PrivacyPolicyLocator);
        }

        public bool IsPrivacyPolicyButtonEnabled()
        {
            return _driver.IsElementEnabled(PrivacyPolicyLocator);
        }
        public bool IsTermsOfUseButtonDisplayed()
        {
            return _driver.IsElementDisplayed(TermsOfUseLocator);
        }

        public bool IsTermsOfUseButtonEnabled()
        {
            return _driver.IsElementEnabled(TermsOfUseLocator);
        }

        public bool IsCookiesPolicyButtonDisplayed()
        {
            return _driver.IsElementDisplayed(CookiesPolicyLocator);
        }

        public bool IsCookiesPolicyButtonEnabled()
        {
            return _driver.IsElementEnabled(CookiesPolicyLocator);
        }

        public bool IsLogoButtonDisplayed()
        {
            return _driver.IsElementDisplayed(LogoButtonSelector);
        }

        public bool IsLogoButtonEnabled()
        {
            return _driver.IsElementEnabled(LogoButtonSelector);
        }
    }
}
