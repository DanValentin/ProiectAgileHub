using System;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemoQAPracticeForm;

namespace ProiectAgileHub
{
     [TestFixture]
    class SignInTest : Hooks
    {
        [Test, Category("SignInTest")]
        public void SignInAction()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            signInPage.clickOnSignInUsButton();
            signInPage.enterEmail();




            //Act
            signInPage.clickOnCreateAccountButton();
            signInPage.enterPersonalDetails();
            signInPage.enterPassword();
            signInPage.enterFullAddress();
            signInPage.clickOnRegisterButton();



            //Assert
           
            Assert.IsTrue(userPage.checkIfSignOutButtonIsDispayed());
            Assert.AreEqual(userPage.checkWelcomeTextMessage(), "Welcome to your account. Here you can manage all of your personal information and orders.", "The login was not OK");
        }
    }
}
