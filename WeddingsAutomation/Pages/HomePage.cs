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
        public string pageUrl = "https://" 
            + Environment.GetEnvironmentVariable("username") 
            + ":" + Environment.GetEnvironmentVariable("password") 
            + "@"
            + "burgas.ormy.io/";

        private By ReservationButton = By.CssSelector(".reservation-button");

        public HomePage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = pageUrl;
        }

        public bool IsReservationButtonDisplayed()
        {
            return _driver.IsElementDisplayed(ReservationButton);
        }

        public bool IsReservationButtonEnabled()
        {
            return _driver.IsElementEnaled(ReservationButton);
        }
    }
}
