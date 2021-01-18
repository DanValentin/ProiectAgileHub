using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProiectAgileHub.PageObjectsDemoQAPracticeForm
{
    class ContactUsPage
    {
        private IWebDriver _driver;

        private WebDriverWait _driverWait;

        public ContactUsPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driverWait.IgnoreExceptionTypes();
        }

        private IWebElement contactUsButton => _driver.FindElement(By.XPath("//*[@id='contact-link']/a[1]"));
        private IWebElement formTitle => _driver.FindElement(By.XPath("//h3[contains(text(),'send a message')]"));
        private IWebElement subjectDropDown => _driver.FindElement(By.XPath("//select[@id='id_contact']"));
        private IWebElement emailInputField => _driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement orderReferenceNumberInputField => _driver.FindElement(By.XPath("//input[@id='id_order']"));
        private IWebElement textMessageInputField => _driver.FindElement(By.XPath("//textarea[@id='message']"));
        private IWebElement sendButton => _driver.FindElement(By.XPath("//button[@id='submitMessage']"));
        private IWebElement confirmationTextMessage => _driver.FindElement(By.XPath("//p[contains(text(),'Your message has been successfully sent to our tea')]"));
        private IWebElement attachFileButton => _driver.FindElement(By.XPath("//input[@id='fileUpload']"));




        public string checkIfFormWasSuccesffully()
        {
            string textMessage = confirmationTextMessage.Text;
            return textMessage;
        }
        public void clickOnSendButton()
        {
            sendButton.Click();
        }
        public void enterTextMessage()
        {
            textMessageInputField.SendKeys("Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Fusce faucibus efficitur magna, vel dignissim metus. Nullam ac lacus sed massa tristique pellentesque. " +
                "Nam commodo vulputate lorem ac fermentum. Nam accumsan egestas neque eget cursus. Morbi pellentesque euismod finibus. " +
                "Curabitur venenatis blandit diam quis dictum. Vestibulum sit amet elit sed augue placerat mattis. Sed ante urna, " +
                "fermentum ac purus sed, viverra pretium enim.");
        }
        public void attacheFile()
        {
            string filePath = @"C:\Users\Dan\Desktop\curs TA AgileHub\testfile.txt";
            attachFileButton.SendKeys(filePath);
        }
        public void enterOrderReferenceNumber()
        {
            orderReferenceNumberInputField.SendKeys("123456Order");
        }
        public void enterEmailAddress()
        {
            emailInputField.SendKeys("agilehub@mailinator.com");
        }
        public void selectWebMasterSubjectFromDropdown()
        {
            SelectElement selectSubject = new SelectElement(subjectDropDown);
            selectSubject.SelectByIndex(1);
        }
        public void selectCustomerServiceSubjectFromDropdown()
        {
            SelectElement selectSubject = new SelectElement(subjectDropDown);
            selectSubject.SelectByIndex(2);
        }
        public string checkFormTitle()
        {
            string storeFormTitle = formTitle.Text;
            return storeFormTitle;
        }
        public void clickOnContactUsButton()
        {
            contactUsButton.Click();
        }
        public bool VerifyElementIsDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
