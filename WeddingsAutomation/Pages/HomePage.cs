using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Pages
{
    public class HomePage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/";
            }
        }

        private By ReservationButtonSelector = By.CssSelector(".reservation-button");
        private By ForUsButtonLocator = By.XPath("//span[contains(text(), 'За нас')]/..");

        public HomePage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsReservationButtonDisplayed()
        {
            return _driver.IsElementDisplayed(ReservationButtonSelector);
        }

        public bool IsReservationButtonEnabled()
        {
            return _driver.IsElementEnaled(ReservationButtonSelector);
        }

        public bool IsForUsButtonDisplayed()
        {
            return _driver.IsElementDisplayed(ForUsButtonLocator);
        }

        public bool IsForUsButtonEnabled()
        {
            return _driver.IsElementEnaled(ForUsButtonLocator);
        }
    }
}
