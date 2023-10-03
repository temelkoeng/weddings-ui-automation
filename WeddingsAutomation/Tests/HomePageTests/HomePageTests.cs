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
            Console.WriteLine(_homePage.pageUrl);
            Assert.True(_homePage.IsReservationButtonDisplayed());
            Assert.True(_homePage.IsReservationButtonEnabled());
        }
    }
}
