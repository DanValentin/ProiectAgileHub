using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace ProiectAgileHub.PageObjectsDemoQAPracticeForm
{
    class ProductsPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        
        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement firstDressHoverOver => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[1]/div[1]/div[1]/div[1]/a[1]/img[1]"));
        private IWebElement addToCardFirstDress => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[1]/div[1]/div[2]/div[2]/a[1]/span[1]"));
        private IWebElement secondDressHoverOver => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[2]/div[1]/div[1]/div[1]/a[1]/img[1]"));
        private IWebElement addToCardSecondDress => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[2]/div[1]/div[2]/div[2]/a[1]/span[1]"));
        private IWebElement thirdDressHoverOver => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[3]/div[1]/div[1]/div[1]/a[1]/img[1]"));
        private IWebElement addToCardThirdDress => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[3]/div[1]/div[2]/div[2]/a[1]/span[1]"));
        private IWebElement proceedToCheckOut => _driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a[1]/span[1]"));
        private IWebElement continueShoppingButton => _driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span[1]/span[1]"));
        private IWebElement proceedToCheckoutButton => _driver.FindElement(By.XPath("//a[@class='button btn btn-default standard-checkout button-medium']"));
        private IWebElement tShirtButton => _driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul[1]/li[3]/a[1]"));
        private IWebElement tshirtHoverOver => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[1]/div[1]/div[1]/div[1]/a[1]/img[1]"));
        private IWebElement tshirtAddToCartButton => _driver.FindElement(By.XPath("//*[@id='center_column']/ul[1]/li[1]/div[1]/div[2]/div[2]/a[1]/span[1]"));
        private IWebElement preceedToCheckOutFromTshirtOrder => _driver.FindElement(By.XPath("//span[normalize-space()='Proceed to checkout']"));
        private IWebElement emptyShoppingCartTextAlert => _driver.FindElement(By.XPath("//p[@class='alert alert-warning']"));
        private IWebElement searchItemsInputField => _driver.FindElement(By.Id("search_query_top"));



        public void searchforTshirt()
        {
            searchItemsInputField.SendKeys("t-shirt");
            searchItemsInputField.SendKeys(Keys.Enter);
        }
        public string CheckTextMessageWhenCartIsEmpty()
        {
            string emptyCartMessage = emptyShoppingCartTextAlert.Text;
            return emptyCartMessage;
        }
        public void OpenCartFromTshirt()
        {
            preceedToCheckOutFromTshirtOrder.Click();
        }
        public void AddTshirtToCart()
        {
            tShirtButton.Click();
            Actions builder = new Actions(_driver);
            builder.MoveToElement(tshirtHoverOver).Perform();
            builder.MoveToElement(tshirtAddToCartButton).Click().Build().Perform();
            
        }
        public void ProceedToCheckoutAction()
        {
            proceedToCheckoutButton.Click();
        }
        public void AddToCardThridDress()
        {
            Actions builder = new Actions(_driver);
            builder.MoveToElement(thirdDressHoverOver).Perform();
            builder.MoveToElement(addToCardThirdDress).Click().Build().Perform();
            proceedToCheckOut.Click();
        }
        public void AddToCardSecondDress()
        {
            Actions builder = new Actions(_driver);
            builder.MoveToElement(secondDressHoverOver).Perform();
            builder.MoveToElement(addToCardSecondDress).Click().Build().Perform();
            continueShoppingButton.Click();
        }
        public void AddToCardFirstDress()
        {
            Actions builder = new Actions(_driver);
            builder.MoveToElement(firstDressHoverOver).Perform();
            builder.MoveToElement(addToCardFirstDress).Click().Build().Perform();
            continueShoppingButton.Click();
        }
    
    }
}
