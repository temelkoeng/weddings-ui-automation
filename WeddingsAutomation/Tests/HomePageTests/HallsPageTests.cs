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
        public void VerifyTheGallery1ButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsGallery1ButtonDisplayed(), "Gallery1 button is not displayed on the Home page!");
            Assert.True(_hallsPage.IsGallery1ButtonEnabled(), "Gallery1 button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheGallery2ButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsGallery2ButtonDisplayed(), "Gallery2 button is not displayed on the Home page!");
            Assert.True(_hallsPage.IsGallery2ButtonEnabled(), "Gallery2 button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheGallery3ButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsGallery3ButtonDisplayed(), "Gallery3 button is not displayed on the Home page!");
            Assert.True(_hallsPage.IsGallery3ButtonEnabled(), "Gallery3 button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyTheGallery4ButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsGallery4ButtonDisplayed(), "Gallery4 button is not displayed on the Home page!");
            Assert.True(_hallsPage.IsGallery4ButtonEnabled(), "Gallery4 button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyGoogleMap1ButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsGoogleMap1ButtonDisplayed(), "GoogleMap1 button is not displayed on the Home page!");
            Assert.True(_hallsPage.IsGoogleMap1ButtonEnabled(), "GoogleMap1 button is not enabled on the Home page!");
        }

        [Test]
        public void VerifyGoogleMap2ButtonIsDisplayedProperlyOnTheHallsPage()
        {
            Assert.True(_hallsPage.IsGoogleMap2ButtonDisplayed(), "GoogleMap2 button is not displayed on the Home page!");
            Assert.True(_hallsPage.IsGoogleMap2ButtonEnabled(), "GoogleMap2 button is not enabled on the Home page!");
        }

    }
}
