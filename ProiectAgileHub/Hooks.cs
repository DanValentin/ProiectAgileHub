using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ProiectAgileHub
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();



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