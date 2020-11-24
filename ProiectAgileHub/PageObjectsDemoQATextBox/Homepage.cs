using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemoQATextBox
{
    class Homepage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public Homepage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement TextBoxLinkButton => _driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[1]"));

        public void ClickOnTextBoxLinkButton()
        {
            TextBoxLinkButton.Click();
        }
    }
}
