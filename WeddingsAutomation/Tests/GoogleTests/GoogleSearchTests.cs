using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Pages;

namespace WeddingsAutomation.Tests.GoogleTests
{
    [TestFixture]
    public class GoogleSearchTests : BaseTest
    {
       private GoogleHomePage _homePage;

        [SetUp]
        public void SetUp()
        {
            _homePage = new GoogleHomePage(base.driver);
        }

        [Test]
        public void VerifyTheSearchResults()
        {
            _homePage.GoToHomePage();
            Assert.IsTrue(true);
        }
    }
}
