using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Pages;

namespace WeddingsAutomation.Tests.PricesPageTests
{
    [TestFixture]
    public class PricesPageTests : BaseTest
    {
        private PricesPage _pricesPage;

        [SetUp]
        public void SetUp()
        {
            _pricesPage = new PricesPage(base.driver);
            _pricesPage.NavigateToPage();
        }

        [Test]
        public void VerifyTheRitualHall6IsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsRitualHall6TextDisplayed(), "RitualHall6 Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheRitualHall5IsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsRitualHall5TextDisplayed(), "RitualHall5 Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheRitualHall4IsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsRitualHall4TextDisplayed(), "RitualHall4 Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheRitualHall3IsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsRitualHall3TextDisplayed(), "RitualHall3 Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheRitualHall2IsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsRitualHall2TextDisplayed(), "RitualHall2 Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheRitualHall1IsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsRitualHall1TextDisplayed(), "RitualHall1 Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheWeddingRitualsTextDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsWeddingRitualsTextDisplayed(), "WeddingRituals Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyThePricesAndServicesTextIsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsPricesAndServicesTextDisplayed(), "Prices and Services Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyTheOtherRitualsTextIsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsOtherRitualsTextDisplayed(), "OtherRituals Text is not displayed on the Prices Page!");
        }

        [Test]
        public void VerifyThePrivacyPolicyButtonIsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsPrivacyPolicyButtonDisplayed(), "Privacy Policy button is not displayed on the Prices page!");
            Assert.True(_pricesPage.IsPrivacyPolicyButtonEnabled(), "Privacy Policy button is not enabled on the Prices page!");
        }

        [Test]
        public void VerifyTheTermsOfUseButtonIsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsTermsOfUseButtonDisplayed(), "Terms Of Use button is not displayed on the Prices page!");
            Assert.True(_pricesPage.IsTermsOfUseButtonEnabled(), "Terms Of Use button is not enabled on the Prices page!");
        }

        [Test]
        public void VerifyTheCookiesPolicyButtonIsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsCookiesPolicyButtonDisplayed(), "Cookies Policy button is not displayed on the Prices page!");
            Assert.True(_pricesPage.IsCookiesPolicyButtonEnabled(), "Cookies Policy button is not enabled on the Prices page!");
        }

        [Test]
        public void VerifyTheLogoButtonIsDisplayedProperlyOnThePricesPage()
        {
            Assert.True(_pricesPage.IsLogoButtonDisplayed(), "Logo button is not displayed on the Prices page!");
            Assert.True(_pricesPage.IsLogoButtonEnabled(), "Logo button is not enabled on the Prices page!");
        }
    }
}
