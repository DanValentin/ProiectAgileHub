using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemosite.casqad.org
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

        private IWebElement AuthenticationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        private IWebElement SignUpButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement VeziDetaliiButon => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement ButonDeconectare => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),'Deconectare')]")));
        private IWebElement LinkCatrePaginaCuLaptopuri => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[1]/a"));
        private IWebElement LinkCatrePaginaCuTelefoane => _driver.FindElement(By.XPath("//a[contains(text(),'Telefoane')]"));
        private IWebElement LinkCatrePaginaCuFoto => _driver.FindElement(By.XPath("//a[contains(text(),'Foto')]"));
        private IWebElement LinkCatrePaginaCuCarti => _driver.FindElement(By.XPath("//a[contains(text(),'Carti')]"));
        private IWebElement LinkCatrePaginaCuAccesorii => _driver.FindElement(By.XPath("//a[contains(text(),'Accesorii')]"));
        private IWebElement LinkCatrePaginaCosCumparaturi => _driver.FindElement(By.XPath("//a[contains(text(),'Coș')]"));
        private IWebElement LinkCatrePaginaAdministrare => _driver.FindElement(By.XPath("//a[contains(text(),'Administrare')]"));
        public IWebElement ValidateDeconectareButtonIsMissing => (IWebElement)_driver.FindElements(By.XPath("//a[text()='Deconectare']"));


        public void GoToRegisterPage()
        {
            SignUpButton.Click();
        }
        public void GoToAuthentication()
        {
            AuthenticationButton.Click();
        }

        public bool VerifyIfLoginWasOk()
        {
            return _driver.FindElement((By)ButonDeconectare).Displayed;
        }

        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
        public void NavigateToLaptopsPage()
        {
            LinkCatrePaginaCuLaptopuri.Click();
        }
        public void DeconectareUtilizator()
        {
            ButonDeconectare.Click();
        }
        public void ClickOnLaptopLink()
        {
            LinkCatrePaginaCuLaptopuri.Click();
        }
        public void ClickOnTelefoaneLink()
        {
            LinkCatrePaginaCuTelefoane.Click();
        }
        public void ClickOnFotoLink()
        {
            LinkCatrePaginaCuFoto.Click();
        }
        public void ClickOnCartiLink()
        {
            LinkCatrePaginaCuCarti.Click();
        }
        public void ClickOnAccesoriiLink()
        {
            LinkCatrePaginaCuAccesorii.Click();
        }
        public void ClickOnCosLink()
        {
            LinkCatrePaginaCosCumparaturi.Click();
        }
        public void ClickOnAdministareLink()
        {
            LinkCatrePaginaAdministrare.Click();
        }
    }
}
