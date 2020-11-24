using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsGoogleSearch
{
    partial class ImagePage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public ImagePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement FirstImage => _driver.FindElement(By.XPath("//*[@id='islrg']/div[1]/div[1]/a[1]/div[1]/img"));


        public void ClickOnFirstImage()
        {
            FirstImage.Click();
        }
        public void ReturnToImagePage()
        {
            _driver.Navigate().Back();
        }
    }
}
