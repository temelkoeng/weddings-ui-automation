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
    }
}
