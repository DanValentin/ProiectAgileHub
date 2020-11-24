using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemoQATextBox
{
    class Text_BoxPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public Text_BoxPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement UserName => _driver.FindElement(By.Id("userName"));
        private IWebElement EmailInputField => _driver.FindElement(By.Id("userEmail"));
        private IWebElement AddressInputField => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement PermanentAddressInputField => _driver.FindElement(By.Id("permanentAddress"));
        private IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement VerifyIfInputFieldIsSubmmited => _driver.FindElement(By.XPath("//div[@class='border col-md-12 col-sm-12']"));

        public void EnterFirstName(string userName)
        {
            UserName.SendKeys(userName);
        }
        public void EnterAddress(string address)
        {
            AddressInputField.SendKeys(address);
        }
        public void EnterPermanentAddress(string permanentAddress)
        {
            PermanentAddressInputField.SendKeys(permanentAddress);
        }
        public void SubmitForm()
        {
            SubmitButton.Click();
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
