using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemoQAPracticeForm
{
    class PracticeFormPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public PracticeFormPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement FirstNameTextBox => _driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameTextBox => _driver.FindElement(By.Id("lastName"));
        private IWebElement EmailTextField => _driver.FindElement(By.Id("userEmail"));
        private IWebElement MaleRadioButton => _driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));
        private IWebElement PhoneNumberTextField => _driver.FindElement(By.Id("userNumber"));
        private IWebElement DateOfBirthPickDate => _driver.FindElement(By.Id("dateOfBirthInput"));
        private IWebElement SubjectTextField => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='subjectsInput']")));
        private IWebElement HobbieCheckBoxSport => _driver.FindElement(By.XPath("//label[contains(text(),'Sports')]"));
        private IWebElement HobbieCheckBoxReading => _driver.FindElement(By.Id("hobbies-checkbox-2"));
        private IWebElement HobbieCheckBoxMusic => _driver.FindElement(By.Id("hobbies-checkbox-3"));
        private IWebElement UploadPictureButton => _driver.FindElement(By.Id("uploadPicture"));
        private IWebElement EnterAddressTextBox => _driver.FindElement(By.Id("currentAddress"));
        private IWebElement SelectStateDropDows => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='react-select-3-input']")));
        private IWebElement SelectCityDropDown => _driver.FindElement(By.XPath("//*[@id='react-select-4-input']"));
        private IWebElement SubmitButton => _driver.FindElement(By.Id("submit"));
        public IWebElement ConfirmationThatFormWasSubmmited => _driver.FindElement(By.Id("closeLargeModal"));



        public void EnterFirstName(string name, string lastname)
        {
            FirstNameTextBox.SendKeys(name);
            LastNameTextBox.SendKeys(lastname);
        }
        public void EnterEmail(string email)
        {
            EmailTextField.SendKeys(email);
        }
        public void ClickOnMaleRadioButton()
        {
            MaleRadioButton.Click();
        }
        public void EnderPhoneNumber(string phoneNumber)
        {
            PhoneNumberTextField.SendKeys(phoneNumber);
        }
        //public void SelectDateOfBirth()
        //{
        //    DateOfBirthPickDate.Click();

        //    //driver.FindElement(By.XPath("//*[text()='Date: ']/input")).Click(); // find the calendar input field and click on it.

        //    List<IWebElement> tableContent = new List<IWebElement>(_driver.FindElements((By)DateOfBirthPickDate)); // get all the dates.

        //    foreach (IWebElement ele in tableContent) // use foreach iterate each cell.
        //    {
        //        string date = ele.Text; // get the text of the element.

        //        if (date.Equals("20")) // check if the date is 20
        //        {
        //            ele.Click(); // if date is 20, select it.
        //            break;
        //        }
        //    }
        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
        //    //js.ExecuteScript("document.getElementById('dateOfBirthInput').value='1988-01-01'");
        //}
        public void EnterSubject(string subject)
        {
            SubjectTextField.SendKeys(subject);
            SubjectTextField.SendKeys(Keys.Enter);
        }
        public void SelectHobbies()
        {
            HobbieCheckBoxSport.Click();
        }
        public void UploadPicture()
        {
            String script = "document.getElementById('uploadPicture').value='" + "C:\\\\temp\\\\file.txt" + "';";
            ((IJavaScriptExecutor)_driver).ExecuteScript(script);
        }
        public void EnterAddress(string address)
        {
            EnterAddressTextBox.SendKeys(address);
        }
        public void SelectStateFromDropDown(string state)
        {
            SelectStateDropDows.SendKeys(state);
            SelectStateDropDows.SendKeys(Keys.Tab);
        }
        public void SelectCityFromDropDown(string city)
        {
            SelectCityDropDown.SendKeys(city);
            SelectCityDropDown.SendKeys(Keys.Tab);
        }
        public void SubmitAction()
        {
            SubmitButton.Click();
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
