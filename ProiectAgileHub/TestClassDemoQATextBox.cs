// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemoQATextBox;

namespace ProiectAgileHub
{
    [TestFixture]
    public class TestClassDemoQATextBox : Hooks
    {
        [Test, Category("Login")]
        public void SubmitForm()
        {
            // Arrange
            Hooks navigateToURL = new Hooks();
            navigateToURL.NavigateToURL("https://demoqa.com/elements");
            Homepage homepage = new Homepage(Driver);
            Text_BoxPage text_BoxPage = new Text_BoxPage(Driver);
            homepage.ClickOnTextBoxLinkButton();

            //Act
            text_BoxPage.EnterFirstName("Dan");
            text_BoxPage.EnterAddress("test@test.com");
            text_BoxPage.EnterAddress("address 1");
            text_BoxPage.EnterPermanentAddress("address 2");
            text_BoxPage.SubmitForm();

            //Assert
            Assert.IsTrue(text_BoxPage.VerifyElementIsDisplayed(text_BoxPage.VerifyIfInputFieldIsSubmmited));
        }
    }
}
