using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace ProiectAgileHub
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }

    public class Hooks
    {
        private BrowserType _browserType;
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {

            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
            ChooseDriverInstance(_browserType);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }
        public void NavigateToURL()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}