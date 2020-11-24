using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemosite.casqad.org
{
    partial class UtilizatoriPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public UtilizatoriPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement UsersNames => _driver.FindElement(By.XPath("//th[contains(text(),'Nume')]"));
        private IWebElement SelectTest9User => _driver.FindElement(By.XPath("//tbody/tr[124]/td[8]/a[1]/i[1]"));
        private IWebElement VerifyIfActualizeazaUtilizatorButtonExist => _driver.FindElement(By.XPath("//button[@type='submit']"));


        public bool CheckIfActualizeazaUtilizatorButtonIsDisplayed()
        {
            return VerifyIfActualizeazaUtilizatorButtonExist.Displayed;
        }
        public void EditTest9User()
        {
            SelectTest9User.Click();
        }
        public bool VerifyIfUsersNamesAreDisplayed()
        {
            return UsersNames.Displayed;
        }
    }
}
