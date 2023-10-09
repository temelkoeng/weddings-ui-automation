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
    public class HallsPage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/halls";
            }
        }

        private By Hall4GalleryButtonLocator = By.XPath("//h3[contains(text(), 'Зала \"Четери\"')]/../../..//a[contains(text(), 'галерия')]");
        private By Hall3GalleryButtonLocator = By.XPath("//h3[contains(text(), '\"Трета\" Зала')]/../../..//a[contains(text(), 'галерия')]");
        private By HallVardarGalleryButtonLocator = By.XPath("//h3[contains(text(), 'Ритуална зала \"Вардар\"')]/../../..//a[contains(text(), 'галерия')]");
        private By Hall2GalleryButtonLocator = By.XPath("//h3[contains(text(), '\"Втора\" зала')]/../../..//a[contains(text(), 'галерия')]");
        private By Hall3GoogleMapButtonLocator = By.XPath("//h3[contains(text(), '\"Трета\" Зала')]/../../..//a[contains(@target, '_blank')]");
        private By Hall2GoogleMapButtonLocator = By.XPath("//h3[contains(text(), '\"Втора\" зала')]/../../..//a[contains(@target, '_blank')]");
        private By PrivacyPolicyLocator = By.XPath("//span[contains(text(), 'Политика за поверителност')]/..");
        private By TermsOfUseLocator = By.XPath("//span[contains(text(), 'Условия за ползване')]/..");
        private By CookiesPolicyLocator = By.XPath("//span[contains(text(), 'Политика за използване на \"бисквитки\"')]/..");
        private By LogoButtonSelector = By.CssSelector(".logo img");

        public HallsPage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsHall4GalleryButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Hall4GalleryButtonLocator);
        }

        public bool IsHall4GalleryButtonEnabled()
        {
            return _driver.IsElementEnabled(Hall4GalleryButtonLocator);
        }

        public bool IsHall3GalleryButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Hall3GalleryButtonLocator);
        }

        public bool IsHall3GalleryButtonEnabled()
        {
            return _driver.IsElementEnabled(Hall3GalleryButtonLocator);
        }

        public bool IsHallVardarGalleryButtonDisplayed()
        {
            return _driver.IsElementDisplayed(HallVardarGalleryButtonLocator);
        }

        public bool IsHallVardarGalleryButtonEnabled()
        {
            return _driver.IsElementEnabled(HallVardarGalleryButtonLocator);
        }

        public bool IsHall2GalleryButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Hall2GalleryButtonLocator);
        }

        public bool IsHall2GalleryButtonEnabled()
        {
            return _driver.IsElementEnabled(Hall2GalleryButtonLocator);
        }

        public bool IsHall3GoogleMapButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Hall3GoogleMapButtonLocator);
        }

        public bool IsHall3GoogleMapButtonEnabled()
        {
            return _driver.IsElementEnabled(Hall3GoogleMapButtonLocator);
        }

        public bool IsHall2GoogleMapButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Hall2GoogleMapButtonLocator);
        }

        public bool IsHall2GoogleMapButtonEnabled()
        {
            return _driver.IsElementEnabled(Hall2GoogleMapButtonLocator);
        }

        public bool IsLogoButtonDisplayed()
        {
            return _driver.IsElementDisplayed(LogoButtonSelector);
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

        public bool IsLogoButtonEnabled()
        {
            return _driver.IsElementEnabled(LogoButtonSelector);
        }
    }
}
