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
    public class PricesPage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/services";
            }
        }

        private By PricesAndServicesTextLocator = By.XPath("//div[contains(@class, 'title-container')]//h2[contains(text(), 'Цени и услуги')]");
        private By WeddingRitualsTextLocator = By.XPath("//div[contains(@class, 'title-container bordered')]//h3[contains(text(), 'Сватбени ритуали')]");
        private By RitualHall1TextLocator = By.XPath("//div[contains(@class, 'container services-container')]//h2[contains(text(), 'Озвучаване на сватбен ритуал с механична музика')]");
        private By RitualHall2TextLocator = By.XPath("//div[contains(@class, 'container services-container')]//h2[contains(text(), 'Право на снимане (фото и видео) в обредна зала')]");
        private By RitualHall3TextLocator = By.XPath("//div[contains(@class, 'container services-container')]//h2[contains(text(), 'Озвучаване  на  сватбения ритуал с рок,джаз или  латино музика информация тел.0888307698  зал Триадица, Оборище, Средец')]");
        private By RitualHall4TextLocator = By.XPath("//div[contains(@class, 'container services-container')]//h2[contains(text(), 'Озвучаване на сватбения ритуал с дуо')]");
        private By RitualHall5TextLocator = By.XPath("//div[contains(@class, 'container services-container')]//h2[contains(text(), 'Озвучаване на сватбения ритуал с трио')]");
        private By OtherRitualsTextLocator = By.XPath("//div[contains(@class, 'title-container bordered')]//h3[contains(text(), 'Други ритуали')]");
        private By RitualHall6TextLocator = By.XPath("//div[contains(@class, 'container services-container')]//h2[contains(text(), 'Осигуряване на музикален съпровод (на живо)')]");
        private By LogoButtonSelector = By.CssSelector(".logo img");
        private By PrivacyPolicyLocator = By.XPath("//span[contains(text(), 'Политика за поверителност')]/..");
        private By TermsOfUseLocator = By.XPath("//span[contains(text(), 'Условия за ползване')]/..");
        private By CookiesPolicyLocator = By.XPath("//span[contains(text(), 'Политика за използване на \"бисквитки\"')]/..");

        public PricesPage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsOtherRitualsTextDisplayed()
        {
            return _driver.IsElementDisplayed(OtherRitualsTextLocator);
        }

        public bool IsRitualHall6TextDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHall6TextLocator);
        }

        public bool IsRitualHall5TextDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHall5TextLocator);
        }

        public bool IsRitualHall4TextDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHall4TextLocator);
        }

        public bool IsRitualHall3TextDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHall3TextLocator);
        }

        public bool IsRitualHall2TextDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHall2TextLocator);
        }

        public bool IsRitualHall1TextDisplayed()
        {
            return _driver.IsElementDisplayed(RitualHall1TextLocator);
        }

        public bool IsWeddingRitualsTextDisplayed()
        {
            return _driver.IsElementDisplayed(WeddingRitualsTextLocator);
        }

        public bool IsPricesAndServicesTextDisplayed()
        {
            return _driver.IsElementDisplayed(PricesAndServicesTextLocator);
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
