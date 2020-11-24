using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsGoogleSearch
{
    partial class HomePage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement SearchField => _driver.FindElement(By.XPath("//input[@name='q']"));
        private IWebElement SuntDeAcordButton => _driver.FindElement(By.XPath("//*[@id='introAgreeButton']/span/span"));
        private IWebElement ClickOnImagineButton => _driver.FindElement(By.XPath("//*[@id='hdtb-msb-vis']/div[2]/a"));
        public IWebElement ImageSelectedFrame => _driver.FindElement(By.XPath("//div[@id='Sva75c']"));


        public void SendKeywordToTextField(string keyword)
        {
            SearchField.SendKeys(keyword);
            SearchField.SendKeys(Keys.Return);
        }
        public void SwitchToIframe()
        {
            _driver.SwitchTo().Frame(0);
            SuntDeAcordButton.Click();
        }
        public void ClickOnImagineTab()
        {
            ClickOnImagineButton.Click();
        }
    }
}
