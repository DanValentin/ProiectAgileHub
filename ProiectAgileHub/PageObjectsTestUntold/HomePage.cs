using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsTestUntold
{
    class HomePage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }
        private IWebElement MenuButton => _driver.FindElement(By.XPath("//div[@class='bm-burger-button']"));
        private IWebElement HomeButton => _driver.FindElement(By.XPath("//span[contains(text(),'HOME')]"));
        public IWebElement HomePageLogo => _driver.FindElement(By.XPath("//header/a[@id='logo']/img[1]"));

        public void ClickOnMenuButton()
        {
            MenuButton.Click();
        }
        public void ClickOnHomePageButton()
        {
            HomeButton.Click();
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
