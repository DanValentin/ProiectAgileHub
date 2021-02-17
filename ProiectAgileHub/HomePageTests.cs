using System;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemoQAPracticeForm;

namespace ProiectAgileHub
{
     [TestFixture]
    class HomePageTests : Hooks
    {
        [Test, Category("HomePageTests")]
        public void HomePageActions()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            NavigateToURL();
                       

            //Act
            homePage.PageTitle();
            homePage.HeroImageIsDispayed();
           

            //Assert
            //Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.heroImage));
            Assert.AreEqual(homePage.PageTitle(), "My Store", "My Store is not the application title");
            //Assert.IsTrue(homePage.HeroImageIsDispayed());
            Assert.AreEqual(homePage.VerifyPhoneNumberOnHomePage(), "0123-456-789", "Phone number is not correct");
            Assert.IsTrue(homePage.ContactButtonIsDispayed());
            Assert.IsTrue(homePage.SignInButtonIsDispayed());
            Assert.IsTrue(homePage.LogoIsDispayed());
        }
    }
}
