using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProiectAgileHub.PageObjectsDemosite.casqad.org;

namespace ProiectAgileHub
{
[TestFixture]
    class TestClassDemoSiteCasqad : Hooks
    {
        private Hooks navigateToURL = new Hooks();
        [Test, Category("Login")]
        public void LoginIntoApplication()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("test10@gmail.com", "123456");

            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.DeconectareButton));
        }
        [Test, Category("Adding in basket as admin")]
        public void AddingItemsInBasketAsAdmin()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            LaptopPage laptopPage = new LaptopPage(Driver);

            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            homePage.NavigateToLaptopsPage();
            Assert.IsTrue(laptopPage.VerifyElementIsDisplayed(laptopPage.VerifyIfLaptopIsPresentOnThePage));
            laptopPage.ClickOnProductDetails();
            laptopPage.AddLaptopIntoBasket();

            //Assert
            Assert.IsTrue(laptopPage.VerifyElementIsDisplayed(laptopPage.VerifyThatLaptopIsPressentOnBasket));
        }

        [Test, Category("Signup")]
        public void SignUpIntoApplication()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            homePage.GoToRegisterPage();

            //Act
            RegisterPage registerPage = new RegisterPage(Driver);
            registerPage.RegisterUser("DanPopa", "test11@gmail.com", "0123654789", "Bucuresti sector4", "123456");
            registerPage.ClickOnSubmitButton();
            loginPage.AuthenticateUser("test11@gmail.com", "123456");

            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.DeconectareButton));
        }
         [Test, Category("LoginAndLogoutAction")]
        public void LoginAndLogoutAction()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("test10@gmail.com", "123456");
            homePage.DeconectareUtilizator();

            //Assert
            //work from here!
        }
        [Test, Category("LoginAndPressOnEachHorizontalMenu")]
        public void LoginAndPressOnEachHorizontalMenu()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("test10@gmail.com", "123456");
            homePage.ClickOnLaptopLink();
            homePage.ClickOnTelefoaneLink();
            homePage.ClickOnFotoLink();
            homePage.ClickOnCartiLink();
            homePage.ClickOnAccesoriiLink();
            homePage.ClickOnCosLink();
            homePage.ClickOnAdministareLink();
            homePage.DeconectareUtilizator();
            

            //Assert
            //work from here!
        }[Test, Category("AsAdmninClickOnAdminButton")]
        public void AsAdminClickOnAdminButton()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            AdminPage adminPage = new AdminPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            homePage.ClickOnAdministareLink();

            //Assert
            Assert.IsTrue(adminPage.CheckIfAddNewProductIsDisplayed());
        }
        [Test, Category("AsAdminClickOnAdminButtonAndAccessUtilizatoriLink")]
        public void AsAdminClickOnAdminButtonAndAccessUtilizatoriLink()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            AdminPage adminPage = new AdminPage(Driver);
            UtilizatoriPage utilizatoriPage = new UtilizatoriPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            homePage.ClickOnAdministareLink();
            adminPage.ClickOnUtilizatoriLink();

            //Assert
            Assert.IsTrue(utilizatoriPage.VerifyIfUsersNamesAreDisplayed());
        }
        [Test, Category("AsAdminClickOnAdminButtonAndAccessUtilizatoriLinkAndEditOneUser")]
        public void AsAdminClickOnAdminButtonAndAccessUtilizatoriLinkAndEditOneUser()
        {
            // Arrange
            navigateToURL.NavigateToURL("http://demosite.casqad.org/");
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            AdminPage adminPage = new AdminPage(Driver);
            UtilizatoriPage utilizatoriPage = new UtilizatoriPage(Driver);
            homePage.GoToAuthentication();

            //Act
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");
            homePage.ClickOnAdministareLink();
            adminPage.ClickOnUtilizatoriLink();
            utilizatoriPage.EditTest9User();

            //Assert
            Assert.IsTrue(utilizatoriPage.CheckIfActualizeazaUtilizatorButtonIsDisplayed());
        }


    }
}
