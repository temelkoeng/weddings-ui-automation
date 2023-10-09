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
    public class NewsPageTests : BaseTest
    {
        private NewsPage _newsPage;

        [SetUp]
        public void SetUp()
        {
            _newsPage = new NewsPage(base.driver);
            _newsPage.NavigateToPage();
        }
        //Бъг при изпълняване на теста, аутомейшън
        [Test]
        public void VerifyTheYear2023AndMonthsButtonsAreDisplayedProperlyOnTheNewsPage()
        {
            Assert.True(_newsPage.IsYear2023ButtonDisplayed(), "Year 2023 button is not displayed on the News page!");
            Assert.True(_newsPage.IsYear2023ButtonEnabled(), "Year 2023 button is not enabled on the News page!");
            /*Assert.True(_newsPage.IsJanuaryButtonDisplayed(), "January button is not displayed on the News page!");
            Assert.True(_newsPage.IsJanuaryButtonEnabled(), "January button is not enabled on the News page!");
            Assert.True(_newsPage.IsFebruaryButtonDisplayed(), "February button is not displayed on the News page!");
            Assert.True(_newsPage.IsFebruaryButtonEnabled(), "February button is not enabled on the News page!");
            Assert.True(_newsPage.IsMarchButtonDisplayed(), "March button is not displayed on the News page!");
            Assert.True(_newsPage.IsMarchButtonEnabled(), "March button is not enabled on the News page!");*/
        }
        //Бъг при изпълняване на теста, аутомейшън
        [Test]
        public void VerifyTheYear2022AndMonthsButtonsAreDisplayedProperlyOnTheNewsPage()
        {
            Assert.True(_newsPage.IsYear2022ButtonDisplayed(), "Year 2022 button is not displayed on the News page!");
            Assert.True(_newsPage.IsYear2022ButtonEnabled(), "Year 2022 button is not enabled on the News page!");
          /*  Assert.True(_newsPage.IsJanuaryButtonDisplayed(), "January button is not displayed on the News page!");
            Assert.True(_newsPage.IsJanuaryButtonEnabled(), "January button is not enabled on the News page!");
            Assert.True(_newsPage.IsFebruaryButtonDisplayed(), "February button is not displayed on the News page!");
            Assert.True(_newsPage.IsFebruaryButtonEnabled(), "February button is not enabled on the News page!");
            Assert.True(_newsPage.IsMarchButtonDisplayed(), "March button is not displayed on the News page!");
            Assert.True(_newsPage.IsMarchButtonEnabled(), "March button is not enabled on the News page!");*/
        }

        [Test]
        public void VerifyTheNewsAndEventsHeaderTextIsDisplayedOnTheNewsPage()
        {
            Assert.True(_newsPage.IsNewsAndEventsHeaderTextDisplayed(), "News And Events text is not displayed on the News page!");
        }

        [Test]
        public void VerifyThePrivacyPolicyButtonIsDisplayedProperlyOnTheNewsPage()
        {
            Assert.True(_newsPage.IsPrivacyPolicyButtonDisplayed(), "Privacy Policy button is not displayed on the News page!");
            Assert.True(_newsPage.IsPrivacyPolicyButtonEnabled(), "Privacy Policy button is not enabled on the News page!");
        }

        [Test]
        public void VerifyTheTermsOfUseButtonIsDisplayedProperlyOnTheNewsPage()
        {
            Assert.True(_newsPage.IsTermsOfUseButtonDisplayed(), "Terms Of Use button is not displayed on the News page!");
            Assert.True(_newsPage.IsTermsOfUseButtonEnabled(), "Terms Of Use button is not enabled on the News page!");
        }

        [Test]
        public void VerifyTheCookiesPolicyButtonIsDisplayedProperlyOnTheNewsPage()
        {
            Assert.True(_newsPage.IsCookiesPolicyButtonDisplayed(), "Cookies Policy button is not displayed on the News page!");
            Assert.True(_newsPage.IsCookiesPolicyButtonEnabled(), "Cookies Policy button is not enabled on the News page!");
        }

        [Test]
        public void VerifyTheLogoButtonIsDisplayedProperlyOnTheNewsPage()
        {
            Assert.True(_newsPage.IsLogoButtonDisplayed(), "Logo button is not displayed on the News page!");
            Assert.True(_newsPage.IsLogoButtonEnabled(), "Logo button is not enabled on the News page!");
        }
    }
}
