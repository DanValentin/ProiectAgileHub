using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsTestTeatru
{
    class ActorPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public ActorPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement ActorButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-masonry-1-item-2697']/figure/div/div")));
        private IWebElement SpectacolButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]")));
        private IWebElement showNameText => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[2]/div/div/h3")));
        public IWebElement CumparaBileteButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'CUMPARA BILET')]")));
        public void ClickOnActorImage()
        {
            ActorButton.Click();
        }
        public void ClickOnSpectacolButton()
        {
            SpectacolButton.Click();
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
