using System;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemoQAPracticeForm;

namespace ProiectAgileHub
{
     [TestFixture]
    class ContactUsTest : Hooks
    {
        [Test, Category("SendFormToWebmasterTest")]
        public void ContactUsFormWebmaster()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            ContactUsPage contactUsPage = new ContactUsPage(Driver);



            //Act
            homePage.clickOnContactUsButton();
            Assert.AreEqual(contactUsPage.checkFormTitle(), "SEND A MESSAGE", "Wrong form title");
            contactUsPage.selectWebMasterSubjectFromDropdown();
            contactUsPage.enterEmailAddress();
            contactUsPage.enterOrderReferenceNumber();
            contactUsPage.enterTextMessage();
            contactUsPage.clickOnSendButton();
           

            //Assert
            Assert.IsTrue(homePage.ContactButtonIsDispayed());
            Assert.AreEqual(contactUsPage.checkIfFormWasSuccesffully(), "Your message has been successfully sent to our team.", "The form was not send");
        }
        [Test, Category("SendFormToWebmasterTest")]
        public void ContactUsFormWithFileUpload()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            ContactUsPage contactUsPage = new ContactUsPage(Driver);



            //Act
            homePage.clickOnContactUsButton();
            Assert.AreEqual(contactUsPage.checkFormTitle(), "SEND A MESSAGE", "Wrong form title");
            contactUsPage.selectCustomerServiceSubjectFromDropdown();
            contactUsPage.enterEmailAddress();
            contactUsPage.enterOrderReferenceNumber();
            contactUsPage.attacheFile();
            contactUsPage.enterTextMessage();
            contactUsPage.clickOnSendButton();


            //Assert
            Assert.IsTrue(homePage.ContactButtonIsDispayed());
            Assert.AreEqual(contactUsPage.checkIfFormWasSuccesffully(), "Your message has been successfully sent to our team.", "The form was not send");
        }
    }
}
