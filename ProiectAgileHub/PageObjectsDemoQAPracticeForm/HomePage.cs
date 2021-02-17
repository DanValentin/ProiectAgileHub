using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

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

        private IWebElement LogoHomePage => _driver.FindElement(By.XPath("//*[@id='header_logo']/a[1]/img[1]"));
        private IWebElement ContactUsButton => _driver.FindElement(By.XPath("//*[@id='contact-link']/a[1]"));
        private IWebElement SignInButton => _driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
        public IWebElement HeroImage => _driver.FindElement(By.XPath("//div[@id='slider_row']//li[4]//div[1]"));
        private IWebElement HomePagePhoneNumber => _driver.FindElement(By.XPath("//strong[contains(text(),'0123-456-789')]"));
        private IWebElement WomenNestedMainMenu => _driver.FindElement(By.XPath("//a[@title='Women']"));
        private IWebElement WomenNestedSecondMenu => _driver.FindElement(By.XPath("//header/div[3]/div[1]/div[1]/div[6]/ul[1]/li[1]/ul[1]/li[2]/ul[1]/li[3]/a[1]"));
        



        public void navigateInNestedMenu()
        {
            Actions builder = new Actions(_driver);
            builder.MoveToElement(WomenNestedMainMenu).Perform(); 
            builder.MoveToElement(WomenNestedSecondMenu).Click().Build().Perform();

        }
        public void clickOnContactUsButton()
        {
            ContactUsButton.Click();
        }
        public bool LogoIsDispayed()
        {
            bool logoIsDisplayed = LogoHomePage.Displayed;
            return logoIsDisplayed;
        }
        public bool SignInButtonIsDispayed()
        {
            bool signInButtonIsDisplayed = SignInButton.Displayed;
            return signInButtonIsDisplayed;
        }
        public bool ContactButtonIsDispayed()
        {
            bool contactButtonIsDisplayed = ContactUsButton.Displayed;
            return contactButtonIsDisplayed;
        }
        public string VerifyPhoneNumberOnHomePage()
        {
            string phoneNumber = HomePagePhoneNumber.Text;
            return phoneNumber;
        }
        public bool HeroImageIsDispayed()
        {
            bool heroImgeIsDisplayed = HeroImage.Displayed;
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
