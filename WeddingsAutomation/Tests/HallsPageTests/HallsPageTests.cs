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
    public class HallsPageTests : BaseTest
    {
        private HallsPage _hallsPage;

        [SetUp]
        public void SetUp()
        {
            _hallsPage = new HallsPage(base.driver);
            _hallsPage.NavigateToPage();
        }

        [Test]
        public void VerifyTheHall4GalleryButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsHall4GalleryButtonDisplayed(), "Hall 4 Gallery button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsHall4GalleryButtonEnabled(), "Hall 4 Gallery button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheHall3GalleryButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsHall3GalleryButtonDisplayed(), "Hall 3 Gallery button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsHall3GalleryButtonEnabled(), "Hall 3 Gallery button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheHallVardarGalleryButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsHallVardarGalleryButtonDisplayed(), "Hall Vardar Gallery button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsHallVardarGalleryButtonEnabled(), "Hall Vardar Gallery button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheHall2GalleryButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsHall2GalleryButtonDisplayed(), "Hall 2 Gallery button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsHall2GalleryButtonEnabled(), "Hall 2 Gallery button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheHall3GoogleMapButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsHall3GoogleMapButtonDisplayed(), "Hall 3 GoogleMap button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsHall3GoogleMapButtonEnabled(), "Hall 3 GoogleMap button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheHall2GoogleMapButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsHall2GalleryButtonDisplayed(), "Hall 2 GoogleMap button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsHall2GalleryButtonEnabled(), "Hall 2 GoogleMap button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyThePrivacyPolicyButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsPrivacyPolicyButtonDisplayed(), "Privacy Policy button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsPrivacyPolicyButtonEnabled(), "Privacy Policy button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheTermsOfUseButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsTermsOfUseButtonDisplayed(), "Terms Of Use button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsTermsOfUseButtonEnabled(), "Terms Of Use button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheCookiesPolicyButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsCookiesPolicyButtonDisplayed(), "Cookies Policy button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsCookiesPolicyButtonEnabled(), "Cookies Policy button is not enabled on the Halls page!");
        }

        [Test]
        public void VerifyTheLogoButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsLogoButtonDisplayed(), "Logo button is not displayed on the Halls page!");
            Assert.True(_hallsPage.IsLogoButtonEnabled(), "Logo button is not enabled on the Halls page!");
        }
    }
}
