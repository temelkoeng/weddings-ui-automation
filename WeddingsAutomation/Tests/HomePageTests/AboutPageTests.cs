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

    }
}
