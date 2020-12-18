using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemoQAPracticeForm;

namespace ProiectAgileHub
{
     [TestFixture]
    class TestClassDemoQAPracticeForm : Hooks
    {
        [Test, Category("Login")]
        public void SubmitForm()
        {
            // Arrange
            NavigateToURL("https://demoqa.com/forms");
            HomePage homePage = new HomePage(Driver);
            PracticeFormPage practiceFormPage = new PracticeFormPage(Driver);
            homePage.ClickOnFormButton();

            //Act
            practiceFormPage.EnterFirstName("Dan", "Popa");
            practiceFormPage.EnterEmail("test@mail.com");
            practiceFormPage.ClickOnMaleRadioButton();
            practiceFormPage.EnderPhoneNumber("0123654879");
            //practiceFormPage.SelectDateOfBirth();
            practiceFormPage.EnterSubject("Math");
            practiceFormPage.SelectHobbies();
            //practiceFormPage.UploadPicture();
            practiceFormPage.EnterAddress("asfdklgnsfdkn sdgertg");
            practiceFormPage.SelectStateFromDropDown("NCR");
            practiceFormPage.SelectCityFromDropDown("Delhi");
            practiceFormPage.SubmitAction();


            //Assert
            Assert.IsTrue(practiceFormPage.VerifyElementIsDisplayed(practiceFormPage.ConfirmationThatFormWasSubmmited));
        }
    }

    public class HooksDemoQAPracticeForm
    {
    }
}
