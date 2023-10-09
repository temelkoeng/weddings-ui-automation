using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Pages;

namespace WeddingsAutomation.Tests.HomePageTests
{
    [TestFixture]
    public class HomePageTests : BaseTest
    {
        private HomePage _homePage;

        [SetUp]
        public void SetUp()
        {
            _homePage = new HomePage(base.driver);
            _homePage.NavigateToPage();
        }

        [Test]
        public void VerifyTheReservationButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsReservationButtonDisplayed(), "Reservation button is not displayed on the Home page!");
            Assert.True(_homePage.IsReservationButtonEnabled(), "Reservation button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheAboutUsButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsForUsButtonDisplayed(), "About us button is not displayed on the Home page!");
            Assert.True(_homePage.IsForUsButtonEnabled(), "About us button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheHallsButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsHallsButtonDisplayed(), "Halls button is not displayed on the Home page!");
            Assert.True(_homePage.IsHallsButtonEnabled(), "Halls button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyThePricesButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsPricesButtonDisplayed(), "Prices button is not displayed on the Home page!");
            Assert.True(_homePage.IsPricesButtonEnabled(), "Prices button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheNewsButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsNewsButtonDisplayed(), "News button is not displayed on the Home page!");
            Assert.True(_homePage.IsNewsButtonEnabled(), "News button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheDocumentsButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsDocumentsButtonDisplayed(), "Documents button is not displayed on the Home page!");
            Assert.True(_homePage.IsDocumentsButtonEnabled(), "Documents button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheContactButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsContactButtonDisplayed(), "Contact button is not displayed on the Home page!");
            Assert.True(_homePage.IsContactButtonEnabled(), "Contact button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheRitualHallButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsRitualHallButtonDisplayed(), "Ritual Hall button is not displayed on the Home page!");
            Assert.True(_homePage.IsRitualHallButtonEnabled(), "Ritual Hall button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyThePerformedRitualButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsPerformedRitualButtonDisplayed(), "Performed Ritual button is not displayed on the Home page!");
            Assert.True(_homePage.IsPerformedRitualButtonEnabled(), "Performed Ritual button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyThePrivacyPolicyButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsPrivacyPolicyButtonDisplayed(), "Privacy Policy button is not displayed on the Home page!");
            Assert.True(_homePage.IsPrivacyPolicyButtonEnabled(), "Privacy Policy button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheTermsOfUseButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsTermsOfUseButtonDisplayed(), "Terms Of Use button is not displayed on the Home page!");
            Assert.True(_homePage.IsTermsOfUseButtonEnabled(), "Terms Of Use button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheCookiesPolicyButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsCookiesPolicyButtonDisplayed(), "Cookies Policy button is not displayed on the Home page!");
            Assert.True(_homePage.IsCookiesPolicyButtonEnabled(), "Cookies Policy button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheLogoButtonIsDisplayedProperlyOnTheHomePage()
        {
            Assert.True(_homePage.IsLogoButtonDisplayed(), "Logo button is not displayed on the Home page!");
            Assert.True(_homePage.IsLogoButtonEnabled(), "Logo button is not enabled on the Home page!");
        }
    }
}
