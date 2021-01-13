using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace ProiectAgileHub.PageObjectsDemoQAPracticeForm
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

        private IWebElement logoHomePage => _driver.FindElement(By.XPath("//*[@id='header_logo']/a[1]/img[1]"));
        private IWebElement contactUsButton => _driver.FindElement(By.XPath("//*[@id='contact-link']/a[1]"));
        private IWebElement signInButton => _driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
        public IWebElement heroImage => _driver.FindElement(By.XPath("//ul[@id='homeslider']"));
        private IWebElement homePagePhoneNumber => _driver.FindElement(By.XPath("//strong[contains(text(),'0123-456-789')]"));



        public bool LogoIsDispayed()
        {
            bool logoIsDisplayed = logoHomePage.Displayed;
            return logoIsDisplayed;
        }
        public bool SignInButtonIsDispayed()
        {
            bool signInButtonIsDisplayed = signInButton.Displayed;
            return signInButtonIsDisplayed;
        }
        public bool ContactButtonIsDispayed()
        {
            bool contactButtonIsDisplayed = contactUsButton.Displayed;
            return contactButtonIsDisplayed;
        }
        public string VerifyPhoneNumberOnHomePage()
        {
            string phoneNumber = homePagePhoneNumber.Text;
            return phoneNumber;
        }
        public bool HeroImageIsDispayed()
        {
            bool heroImgeIsDisplayed = heroImage.Displayed;
            return heroImgeIsDisplayed;
        }
        public string PageTitle()
        {
            string title = _driver.Title;
            return title;
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
