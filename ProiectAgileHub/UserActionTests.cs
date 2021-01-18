using System;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemoQAPracticeForm;

namespace ProiectAgileHub
{
     [TestFixture]
    class UserActionTests : Hooks
    {
        [Test, Category("SignInAndLogoutTest")]
        public void LoginAndLogoutTest()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            signInPage.clickOnSignInUsButton();


            
            //Act
            userPage.enterCredentialsAndLogin();



            //Assert
           
            Assert.IsTrue(userPage.checkIfSignOutButtonIsDispayed());
            Assert.AreEqual(userPage.checkWelcomeTextMessage(), "Welcome to your account. Here you can manage all of your personal information and orders.", "The login was not OK");
            userPage.logoutAction();
            Assert.AreEqual(userPage.checkIfLoginWasOk(), "AUTHENTICATION", "Logout action was not ok");

        }
    }
}
