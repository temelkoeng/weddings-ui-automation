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
    public class HallsPage : BasePage
    {
        public TestContext testContext { get; set; }

        public string PageUrl { get
            {
                return "https://"
            + _driver.GetUsername()
            + ":" + _driver.GetPassword()
            + "@"
            + "burgas.ormy.io/halls";
            }
        }

        private By Gallery1ButtonSelector = By.XPath("//div[@class='listing-container js-masonry-container row']/div[1]//a[.='галерия']");
        private By Gallery2ButtonSelector = By.XPath("//div[@class='listing-container js-masonry-container row']/div[2]//a[.='галерия']");
        private By Gallery3ButtonSelector = By.XPath("//div[@class='listing-container js-masonry-container row']/div[3]//a[.='галерия']");
        private By Gallery4ButtonSelector = By.XPath("//div[@class='listing-container js-masonry-container row']/div[4]//a[.='галерия']");
        private By GoogleMap1ButtonSelector = By.XPath("//a[@href='https://goo.gl/maps/DZuPcSKtYrgHmBA78']");
        private By GoogleMap2ButtonSelector = By.XPath("//div[@class='listing-container js-masonry-container row']/div[2]//a[2]");
        public HallsPage(WebDriverController driver) : base(driver)
        {
            base.PageUrl = this.PageUrl;
        }

        public bool IsGallery1ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Gallery1ButtonSelector);
        }

        public bool IsGallery1ButtonEnabled()
        {
            return _driver.IsElementEnabled(Gallery1ButtonSelector);
        }

        public bool IsGallery2ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Gallery2ButtonSelector);
        }

        public bool IsGallery2ButtonEnabled()
        {
            return _driver.IsElementEnabled(Gallery2ButtonSelector);
        }

        public bool IsGallery3ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Gallery3ButtonSelector);
        }

        public bool IsGallery3ButtonEnabled()
        {
            return _driver.IsElementEnabled(Gallery3ButtonSelector);
        }

        public bool IsGallery4ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(Gallery4ButtonSelector);
        }

        public bool IsGallery4ButtonEnabled()
        {
            return _driver.IsElementEnabled(Gallery4ButtonSelector);
        }

        public bool IsGoogleMap1ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(GoogleMap1ButtonSelector);
        }

        public bool IsGoogleMap1ButtonEnabled()
        {
            return _driver.IsElementEnabled(GoogleMap1ButtonSelector);
        }

        public bool IsGoogleMap2ButtonDisplayed()
        {
            return _driver.IsElementDisplayed(GoogleMap2ButtonSelector);
        }

        public bool IsGoogleMap2ButtonEnabled()
        {
            return _driver.IsElementEnabled(GoogleMap2ButtonSelector);
        }
    }
}
