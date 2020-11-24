using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsGoogleSearch;

namespace ProiectAgileHub
{
    [TestFixture]
    public class TestClass : Hooks
    {
        [Test, Category("GoogleSearchKeyword")]
        public void GoogleSearchKeyword()
        {
            //Arrange
            Hooks navigateToURL = new Hooks();
            navigateToURL.NavigateToURL("https://www.google.com/");
            HomePage homePage = new HomePage(Driver);
            ImagePage imagePage = new ImagePage(Driver);
            homePage.SwitchToIframe();
            homePage.SendKeywordToTextField("paris");


            //Act
            homePage.ClickOnImagineTab();
            imagePage.ClickOnFirstImage();
            imagePage.ReturnToImagePage();

            //Assert
            Assert.IsTrue(!homePage.ImageSelectedFrame.Displayed);

        }

    }
}
