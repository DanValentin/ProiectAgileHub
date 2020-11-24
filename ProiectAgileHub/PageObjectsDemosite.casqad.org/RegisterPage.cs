using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemosite.casqad.org
{
    partial class RegisterPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement AddName => _driver.FindElement(By.XPath("//input[@name='name']"));
        private IWebElement AddEmail => _driver.FindElement(By.XPath("//input[@name='email']"));
        private IWebElement AddPhone => _driver.FindElement(By.XPath("//input[@name='phone']"));
        private IWebElement AddAddress => _driver.FindElement(By.XPath("//textarea[@name='address']"));
        private IWebElement EnterFirstPassword => _driver.FindElement(By.XPath("//input[@name='password_1']"));
        private IWebElement EnterSecondPassword => _driver.FindElement(By.XPath("//input[@name='password_2']"));
        private IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@type='submit']"));


        public void RegisterUser(string name, string email, string telefon, string adresa, string parola)
        {
            AddName.SendKeys(name);
            AddEmail.SendKeys(email);
            AddPhone.SendKeys(telefon);
            AddAddress.SendKeys(adresa);
            EnterFirstPassword.SendKeys(parola);
            EnterSecondPassword.SendKeys(parola);

        }
        public void ClickOnSubmitButton()
        {
            SubmitButton.Click();
        }
        //public string GenerateRandomString()
        //{
        //    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        //    var stringChars = new char[6];
        //    var random = new Random();

        //    for (int i = 0; i < stringChars.Length; i++)
        //    {
        //        stringChars[i] = chars[random.Next(chars.Length)];
        //    }

        //    var finalString = new String(stringChars);

        //    return finalString;
        //}
    }
}
