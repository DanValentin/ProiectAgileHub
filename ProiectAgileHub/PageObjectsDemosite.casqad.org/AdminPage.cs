using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemosite.casqad.org
{
    partial class AdminPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement AddNewProduct => _driver.FindElement(By.XPath("//a[contains(text(),'Adaugă produs nou')]"));
        private IWebElement UtilizatoriLink => _driver.FindElement(By.XPath("//a[contains(text(),'Utilizatori')]"));



        public bool CheckIfAddNewProductIsDisplayed()
        {
            return AddNewProduct.Displayed;
        }
        public void ClickOnUtilizatoriLink()
        {
            UtilizatoriLink.Click();
        }
    }
}
