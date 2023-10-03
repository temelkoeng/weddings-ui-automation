using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingsAutomation.Utilities;

namespace WeddingsAutomation.Pages
{
    public class DemoPage
    {
        private WebDriverController _driver;
        private const string URL = "https://demowf.aspnetawesome.com/";

        private By celeryLocator = By.XPath("//div[@class='o-chk']");

        public DemoPage(WebDriverController driver)
        {
            this._driver = driver;
        }

        public void ClickOnCeleryTextbox()
        {
            _driver.ClickElement(celeryLocator);
        }

        public bool IsChecked()
        {
           return _driver.IsAttributePresented(celeryLocator, "checked", "class");
        }

        public void GoToHomePage()
        {
            _driver.NavigateToUrl(URL);
        }
    }
}
