using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProiectAgileHub.PageObjectsDemosite.casqad.org
{
    class LaptopPage
    {
        private IWebDriver _driver;

        public LaptopPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SeeDetailsForProduct => _driver.FindElement(By.XPath("//a[contains(text(),'Vezi detalii')]"));
        public IWebElement VerifyIfLaptopIsPresentOnThePage => _driver.FindElement(By.XPath("//h5[contains(text(),'Laptop ASUS X509FJ')]"));
        private IWebElement AddToBasket => _driver.FindElement(By.XPath("//a[contains(text(),'Adaugă în coș')]"));
        public IWebElement VerifyThatLaptopIsPressentOnBasket => _driver.FindElement(By.XPath("//td[contains(text(),'Laptop ASUS X509FJ')]"));




        public void ClickOnProductDetails()
        {
            SeeDetailsForProduct.Click();
        }
        public void AddLaptopIntoBasket()
        {
            AddToBasket.Click();
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
