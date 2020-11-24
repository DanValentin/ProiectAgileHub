using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsTestTeatru;

namespace ProiectAgileHub
{
      [TestFixture]
    class TestClassTestTeatru : Hooks
    {
        [Test, Category("GoogleSearchKeyword")]
        public void SpectacolTeatru()
        {
            //Arrange
            Hooks navigateToURL = new Hooks();
            navigateToURL.NavigateToURL("https://www.teatrulsicaalexandrescu.ro/?lang=en");
            HomePage homePage = new HomePage(Driver);
            ActorPage actorPage = new ActorPage(Driver);
            homePage.ClickOnTeamLinkButton();

            //Act
            actorPage.ClickOnActorImage();
            actorPage.ClickOnSpectacolButton();

            //Assert
            Assert.IsTrue(actorPage.VerifyElementIsDisplayed(actorPage.CumparaBileteButton));

        }

    }
}
