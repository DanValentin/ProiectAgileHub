using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemoQAPracticeForm
{
    class SignInPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement signInButton => _driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
        private IWebElement enterEmailAddressInputField => _driver.FindElement(By.XPath("//input[@id='email_create']"));
        private IWebElement createAccountButton => _driver.FindElement(By.XPath("//button[@id='SubmitCreate']"));
        private IWebElement selectAccountTitle => _driver.FindElement(By.XPath("//*[@id='account-creation_form']/div[1]/div[1]/div[1]/label[1]"));
        private IWebElement firstNameInputField => _driver.FindElement(By.XPath("//input[@id='customer_firstname']"));
        private IWebElement lastNameInputField => _driver.FindElement(By.XPath("//input[@id='customer_lastname']"));
        private IWebElement passwordInputField => _driver.FindElement(By.XPath("//input[@id='passwd']"));
        private IWebElement addressInputField => _driver.FindElement(By.CssSelector("#address1"));
        private IWebElement reEnterAddressInputField => _driver.FindElement(By.CssSelector("#address2"));
        private IWebElement cityInputField => _driver.FindElement(By.XPath("//input[@id='city']"));
        private IWebElement selectStateFromDropdown => _driver.FindElement(By.XPath("//select[@id='id_state']"));
        private IWebElement zipCodeInputField => _driver.FindElement(By.XPath("//input[@id='postcode']"));
        private IWebElement selectCountryFromDropdown => _driver.FindElement(By.XPath("//select[@id='id_country']"));
        private IWebElement mobilePhoneNumberInputFiled => _driver.FindElement(By.XPath("//input[@id='phone_mobile']"));
        private IWebElement aliasForAddress => _driver.FindElement(By.XPath("//input[@id='alias']"));
        private IWebElement registerButton => _driver.FindElement(By.XPath("//*[@id='submitAccount']/span[1]"));



        public void clickOnRegisterButton()
        {
            registerButton.Click();
        }
        public void enterFullAddress()
        {
            addressInputField.SendKeys("Street address, P.O. Box, Company name, etc.");
            reEnterAddressInputField.SendKeys("Street address, P.O. Box, Company name, etc.");
            cityInputField.SendKeys("Atlanta");

            SelectElement selectState = new SelectElement(selectStateFromDropdown);
            selectState.SelectByIndex(3);

            zipCodeInputField.SendKeys("80514");

            mobilePhoneNumberInputFiled.SendKeys("0752456235");

            aliasForAddress.Clear();
            aliasForAddress.SendKeys("Home");
        }
        public void enterPassword()
        {
            passwordInputField.SendKeys("123456");
        }
        public void enterPersonalDetails()
        {
            selectAccountTitle.Click();
            firstNameInputField.SendKeys("John");
            lastNameInputField.SendKeys("Doe");
        }
        public void clickOnCreateAccountButton()
        {
            createAccountButton.Click();
        }
        public void enterEmail()
        {
            enterEmailAddressInputField.SendKeys("test" + radomNumber() + "@mailinator.com");
        }
        protected int radomNumber()
        {
            Random random = new Random();
            int radomNumber  = random.Next(130);
            return radomNumber;
        }
        public bool IsSigninButtonDisplayed()
        {
            bool isDisplayed = signInButton.Displayed;
            return isDisplayed;
        }
        public void clickOnSignInUsButton()
        {
            signInButton.Click();
        }
    }
}
