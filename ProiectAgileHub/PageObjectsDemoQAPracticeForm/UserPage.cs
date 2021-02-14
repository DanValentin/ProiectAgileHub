using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace ProiectAgileHub.PageObjectsDemoQAPracticeForm
{
    class UserPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public UserPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement welcomeTestMessage => _driver.FindElement(By.XPath("//p[contains(text(),'Welcome to your account. Here you can manage all o')]"));
        private IWebElement signOutButton => _driver.FindElement(By.LinkText("Sign out"));
        private IWebElement enterEmailAddress => _driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement enterPassword => _driver.FindElement(By.XPath("//input[@id='passwd']"));
        private IWebElement clickOnSignInButton => _driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));
        private IWebElement authentificationTextMessage => _driver.FindElement(By.XPath("//h1[normalize-space()='Authentication']"));
        private IWebElement proceedToCheckoutButtonFromAddressesPage => _driver.FindElement(By.XPath("//button[@name='processAddress']//span[contains(text(),'Proceed to checkout')]"));
        private IWebElement proccedToCheckoutFromSummaryPage => _driver.FindElement(By.XPath("//a[@class='button btn btn-default standard-checkout button-medium']//span[contains(text(),'Proceed to checkout')]"));
        private IWebElement termOfServiceCheckBox => _driver.FindElement(By.XPath("//input[@id='cgv']"));
        private IWebElement proceedToCheckoutButtonFromShippingPage => _driver.FindElement(By.XPath("//button[@name='processCarrier']//span[contains(text(),'Proceed to checkout')]"));
        private IWebElement selectPaymentType => _driver.FindElement(By.XPath("//a[@title='Pay by bank wire']"));
        private IWebElement confirmMyOrderButton => _driver.FindElement(By.XPath("//span[normalize-space()='I confirm my order']"));
        private IWebElement orderConfirmationScreen => _driver.FindElement(By.XPath("//strong[normalize-space()='Your order on My Store is complete.']"));
        private IWebElement addExtraQuantityButton => _driver.FindElement(By.XPath("//i[@class='icon-plus']"));
        private IWebElement viewShoppingCartHoverOver => _driver.FindElement(By.XPath("//a[@title='View my shopping cart']"));
        private IWebElement deleteFirstItemFromCart => _driver.FindElement(By.XPath("//dt[@class='first_item']//a[@title='remove this product from my cart']"));
        private IWebElement removeQualityButton => _driver.FindElement(By.XPath("//i[@class='icon-minus']"));


        

        public void ProceedTocheckoutFromSummaryPageAction()
        {
            proccedToCheckoutFromSummaryPage.Click();
        }
        public void RemoveExtraQuantity()
        {
                removeQualityButton.Click();
        }
        public void DeleteItemsFromCart()
        {

            Actions builder = new Actions(_driver);
            builder.MoveToElement(viewShoppingCartHoverOver).Perform();
            builder.MoveToElement(deleteFirstItemFromCart).Click().Build().Perform();

            viewShoppingCartHoverOver.Click();
        }
        public void AddExtraQuantity(int howMany)
        {
          
            for (var i = 0; i >= howMany; i++)
            {
                addExtraQuantityButton.Click();
                
            }
        }
        public string OrderConfirmationTextMessage()
        {
            string confirmationMessage = orderConfirmationScreen.Text;
            return confirmationMessage;
        }
        public void ConfirmOrder()
        {
            confirmMyOrderButton.Click();
        }
        public void SelectPaymentType()
        {
            selectPaymentType.Click();
        }
        public void AgreeToConditionAndProceed()
        {
            termOfServiceCheckBox.Click();
            proceedToCheckoutButtonFromShippingPage.Click();
        }
        public void ClickOnProceedButtonDromAddressPage()
        {
            proceedToCheckoutButtonFromAddressesPage.Click();
        }
        public string checkIfLoginWasOk()
        {
            string textMessage = authentificationTextMessage.Text;
            return textMessage;
        }
        public void enterCredentialsAndLogin()
        {
            enterEmailAddress.SendKeys("teste@mailinator.com");
            enterPassword.SendKeys("123456");
            clickOnSignInButton.Click();
        }
        public void logoutAction()
        {
            signOutButton.Click();
        }
        public bool checkIfSignOutButtonIsDispayed()
        {
            bool signOutButtonDisplayed = signOutButton.Displayed;
            return signOutButtonDisplayed;
        }
        public string checkWelcomeTextMessage()
        {
            var welcomeText = welcomeTestMessage.Text;
            return welcomeText;
        }
    }
}
