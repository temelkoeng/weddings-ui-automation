using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Pages
{
    public class HomePage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/";
            }
        }

        private By ReservationButtonSelector = By.CssSelector(".reservation-button");
        private By ForUsButtonLocator = By.XPath("//span[contains(text(), 'За нас')]/..");
        private By HallsButtonLocator = By.XPath("//span[contains(text(), 'Зали')]/..");
        private By PricesButtonLocator = By.XPath("//span[contains(text(), 'Цени')]/..");
        private By NewsButtonLocator = By.XPath("//span[contains(text(), 'Новини')]/..");
        private By DocumentsButtonLocator = By.XPath("//span[contains(text(), 'Документи')]/..");
        private By ContactButtonLocator = By.XPath("//span[contains(text(), 'Контакти')]/..");
        private By RitualHallLocator = By.XPath("//a[contains(text(), 'Ритуална зала')]/..");
        private By PerformedRitualLocator = By.XPath("//a[contains(text(), 'Изнесен ритуал')]/..");
        private By PrivacyPolicyLocator = By.XPath("//span[contains(text(), 'Политика за поверителност')]/..");
        private By TermsOfUseLocator = By.XPath("//span[contains(text(), 'Условия за ползване')]/..");
        private By CookiesPolicyLocator = By.XPath("//span[contains(text(), 'Политика за използване на \"бисквитки\"')]/..");
        private By LogoButtonSelector = By.CssSelector(".logo img");
       
        public HomePage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsReservationButtonDisplayed()
        {
            _driver.WaitForElementToBeDisplayed(ReservationButtonSelector);
            return _driver.IsElementDisplayed(ReservationButtonSelector);
        }

        public bool IsReservationButtonEnabled()
        {
            return _driver.IsElementEnabled(ReservationButtonSelector);
        }

        public bool IsForUsButtonDisplayed()
        {
            return _driver.IsElementDisplayed(ForUsButtonLocator);
        }

        public bool IsForUsButtonEnabled()
        {
            return _driver.IsElementEnabled(ForUsButtonLocator);
        }

        public bool IsHallsButtonDisplayed()
        {
            return _driver.IsElementDisplayed(HallsButtonLocator);
        }

        public bool IsHallsButtonEnabled()
        {
            return _driver.IsElementEnabled(HallsButtonLocator);
        }

        public bool IsPricesButtonDisplayed()
        {
            return _driver.IsElementDisplayed(PricesButtonLocator);
        }

        public bool IsPricesButtonEnabled()
        {
            return _driver.IsElementEnabled(PricesButtonLocator);
        }

        public bool IsNewsButtonDisplayed()
        {
            return _driver.IsElementDisplayed(NewsButtonLocator);
        }
        
        public bool IsNewsButtonEnabled()
        {
            return _driver.IsElementEnabled(NewsButtonLocator);
        }

        public bool IsDocumentsButtonDisplayed()
        {
            return _driver.IsElementDisplayed(DocumentsButtonLocator);
        }

        public bool IsDocumentsButtonEnabled()
        {
            return _driver.IsElementEnabled(DocumentsButtonLocator);
        }

        public bool IsContactButtonDisplayed()
        {
            return _driver.IsElementDisplayed(ContactButtonLocator);
        }

        public bool IsContactButtonEnabled()
        {
            return _driver.IsElementEnabled(ContactButtonLocator);
        }

        public bool IsRitualHallButtonDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHallLocator);
        }

        public bool IsRitualHallButtonEnabled()
        {
            return _driver.IsElementEnabled(RitualHallLocator);
        }

        public bool IsPerformedRitualButtonDisplayed()
        {
            return _driver.IsElementDisplayed(PerformedRitualLocator);
        }

        public bool IsPerformedRitualButtonEnabled()
        {
            return _driver.IsElementEnabled(PerformedRitualLocator);
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
