using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeddingsAutomation.Pages;

namespace WeddingsAutomation.Tests.DemoTests
{
    [TestFixture]
    public  class DemoTest : BaseTest
    {
        private DemoPage _demoPage;

        [SetUp]
        public void SetUp()
        {
            _demoPage = new DemoPage(base.driver);
            _demoPage.GoToHomePage();
        }

        [Test]
        public void VerifyThatCeleryCheckboxIsClickable()
        {
            Thread.Sleep(1000);
            _demoPage.ClickOnCeleryTextbox();
            Assert.IsTrue(_demoPage.IsChecked());
        }
    }
}
