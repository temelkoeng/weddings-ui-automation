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
    public class NewsPage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/news";
            }
        }

        private By LogoButtonSelector = By.CssSelector(".logo img");
        private By PrivacyPolicyLocator = By.XPath("//span[contains(text(), 'Политика за поверителност')]/..");
        private By TermsOfUseLocator = By.XPath("//span[contains(text(), 'Условия за ползване')]/..");
        private By CookiesPolicyLocator = By.XPath("//span[contains(text(), 'Политика за използване на \"бисквитки\"')]/..");
        private By NewsHeaderTextLocator = By.XPath("//div[contains(@class, 'media media-bg')]//h2[contains(text(), 'Новини')]");
        private By Year2021ButtonLocator = By.XPath("//div[contains(@class, 'years-container')]//a[contains(text(), '2021')]");
        private By Year2022ButtonLocator = By.XPath("//div[contains(@class, 'years-container')]//a[contains(text(), '2022')]");
        private By Year2023ButtonLocator = By.XPath("//div[contains(@class, 'years-container')]//a[contains(text(), '2023')]");
        private By JanuaryButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Януари')]");
        private By FebruaryButtonLocator = By.XPath("//div[contains(@class, 'month-container')]//a[contains(.,'Февруари')]");
        private By MarchButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Март')]");
        private By AprilButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Април')]");
        private By MayButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Май')]");
        private By JuneButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Юни')]");
        private By JulyButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Юли')]");
        private By AugustButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Август')]");
        private By SeptemberButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Септември')]");
        private By OctoberButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Октомври')]");
        private By NovemberButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Ноември')]");
        private By DecemberButtonLocator = By.XPath("////div[contains(@class, 'month-container')]//a[contains(.,'Декември')]");

        public NewsPage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsDecemberButtonDisplayed()
        {
            return _driver.IsElementDisplayed(DecemberButtonLocator);
        }

        public bool IsDecemberButtonEnabled()
        {
            return _driver.IsElementEnabled(DecemberButtonLocator);
        }

        public bool IsNovemberButtonDisplayed()
        {
            return _driver.IsElementDisplayed(NovemberButtonLocator);
        }

        public bool IsNovemberButtonEnabled()
        {
            return _driver.IsElementEnabled(NovemberButtonLocator);
        }

        public bool IsOctoberButtonDisplayed()
        {
            return _driver.IsElementDisplayed(OctoberButtonLocator);
        }

        public bool IsOctoberButtonEnabled()
        {
            return _driver.IsElementEnabled(OctoberButtonLocator);
        }

        public bool IsSeptemberButtonDisplayed()
        {
            return _driver.IsElementDisplayed(SeptemberButtonLocator);
        }

        public bool IsSeptemberButtonEnabled()
        {
            return _driver.IsElementEnabled(SeptemberButtonLocator);
        }

        public bool IsAugustButtonDisplayed()
        {
            return _driver.IsElementDisplayed(AugustButtonLocator);
        }

        public bool IsAugustButtonEnabled()
        {
            return _driver.IsElementEnabled(AugustButtonLocator);
        }

        public bool IsJulyButtonDisplayed()
        {
            return _driver.IsElementDisplayed(JulyButtonLocator);
        }

        public bool IsJulyButtonEnabled()
        {
            return _driver.IsElementEnabled(JulyButtonLocator);
        }

        public bool IsJuneButtonDisplayed()
        {
            return _driver.IsElementDisplayed(JuneButtonLocator);
        }

        public bool IsJuneButtonEnabled()
        {
            return _driver.IsElementEnabled(JuneButtonLocator);
        }

        public bool IsMayButtonDisplayed()
        {
            return _driver.IsElementDisplayed(MayButtonLocator);
        }

        public bool IsMayButtonEnabled()
        {
            return _driver.IsElementEnabled(MayButtonLocator);
        }

        public bool IsAprilButtonDisplayed()
        {
            return _driver.IsElementDisplayed(AprilButtonLocator);
        }

        public bool IsAprilButtonEnabled()
        {
            return _driver.IsElementEnabled(AprilButtonLocator);
        }

        public bool IsMarchButtonDisplayed()
        {
            return _driver.IsElementDisplayed(MarchButtonLocator);
        }

        public bool IsMarchButtonEnabled()
        {
            return _driver.IsElementEnabled(MarchButtonLocator);
        }

        public bool IsFebruaryButtonDisplayed()
        {
            return _driver.IsElementDisplayed(FebruaryButtonLocator);
        }

        public bool IsFebruaryButtonEnabled()
        {
            return _driver.IsElementEnabled(FebruaryButtonLocator);
        }

        public bool IsJanuaryButtonDisplayed()
        {
            return _driver.IsElementDisplayed(JanuaryButtonLocator);
        }

        public bool IsJanuaryButtonEnabled()
        {
            return _driver.IsElementEnabled(JanuaryButtonLocator);
        }

        public bool IsYear2023ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Year2023ButtonLocator);
        }

        public bool IsYear2023ButtonEnabled()
        {
            return _driver.IsElementEnabled(Year2023ButtonLocator);
        }

        public bool IsYear2022ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Year2022ButtonLocator);
        }

        public bool IsYear2022ButtonEnabled()
        {
            return _driver.IsElementEnabled(Year2022ButtonLocator);
        }

        public bool IsYear2021ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Year2021ButtonLocator);
        }

        public bool IsYear2021ButtonEnabled()
        {
            return _driver.IsElementEnabled(Year2021ButtonLocator);
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

        public bool IsNewsAndEventsHeaderTextDisplayed()
        {
            return _driver.IsElementDisplayed(NewsHeaderTextLocator);
        }
    }
}
