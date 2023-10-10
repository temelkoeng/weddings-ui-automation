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
    public class AboutPageTests : BaseTest
    {
        private AboutPage _aboutPage;

        [SetUp]
        public void SetUp()
        {
            _aboutPage = new AboutPage(base.driver);
            _aboutPage.NavigateToPage();
        }

        [Test]
        public void VerifyDescriptionTextIsDisplayedProperlyOnTheAboutPage()
        {
            Assert.True(_aboutPage.IsDescriptionTextDisplayed(), "Description Text is not displayed on the About Page!");
        }

        [Test]
        public void VerifyThePrivacyPolicyButtonIsDisplayedProperlyOnTheAboutPage()
        {
            Assert.True(_aboutPage.IsPrivacyPolicyButtonDisplayed(), "Privacy Policy button is not displayed on the About page!");
            Assert.True(_aboutPage.IsPrivacyPolicyButtonEnabled(), "Privacy Policy button is not enabled on the About page!");
        }

        [Test]
        public void VerifyTheTermsOfUseButtonIsDisplayedProperlyOnTheAboutPage()
        {
            Assert.True(_aboutPage.IsTermsOfUseButtonDisplayed(), "Terms Of Use button is not displayed on the About page!");
            Assert.True(_aboutPage.IsTermsOfUseButtonEnabled(), "Terms Of Use button is not enabled on the About page!");
        }

        [Test]
        public void VerifyTheCookiesPolicyButtonIsDisplayedProperlyOnTheAboutPage()
        {
            Assert.True(_aboutPage.IsCookiesPolicyButtonDisplayed(), "Cookies Policy button is not displayed on the About page!");
            Assert.True(_aboutPage.IsCookiesPolicyButtonEnabled(), "Cookies Policy button is not enabled on the About page!");
        }

        [Test]
        public void VerifyTheLogoButtonIsDisplayedProperlyOnTheAboutPage()
        {
            Assert.True(_aboutPage.IsLogoButtonDisplayed(), "Logo button is not displayed on the About page!");
            Assert.True(_aboutPage.IsLogoButtonEnabled(), "Logo button is not enabled on the About page!");
        }
    }
}
