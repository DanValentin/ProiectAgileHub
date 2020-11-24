using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsTestTeatru
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

        private IWebElement TeamLinkButton => _driver.FindElement(By.XPath("//span[contains(text(),'Team')]"));

        public void ClickOnTeamLinkButton()
        {
            TeamLinkButton.Click();
        }
    }
}
