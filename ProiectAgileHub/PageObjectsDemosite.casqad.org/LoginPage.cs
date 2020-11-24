using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemosite.casqad.org
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;


        private IWebElement EmailFieldTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='email']")));
        private IWebElement PasswordFieldTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='password']")));
        private IWebElement AuthenticateButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@type='submit']")));



        public LoginPage(IWebDriver driver)
        {
            _driver = driver;

            // setam driverul sa stea cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }

        public void AuthenticateUser(string user, string password)
        {
            EmailFieldTextBox.Click();
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.Click();
            PasswordFieldTextBox.SendKeys(password);
            AuthenticateButton.Click();

        }
        public bool VerifyIfSuccessMessageIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

    }
}
