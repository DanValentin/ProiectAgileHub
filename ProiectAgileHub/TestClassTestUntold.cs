using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsTestUntold;

namespace ProiectAgileHub
{
    [TestFixture]
    class TestClassTestUntold : Hooks
    {
        [Test, Category("Login")]
        public void UntoldHomePage()
        {
            // Arrange
            Hooks navigateToURL = new Hooks();
            navigateToURL.NavigateToURL("https://untold.com");
            HomePage homePage = new HomePage(Driver);
            homePage.ClickOnMenuButton();

            //Act
            homePage.ClickOnHomePageButton();
            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.HomePageLogo));
        }
    }
}
