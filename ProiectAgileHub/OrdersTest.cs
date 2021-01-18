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
    class OrdersTest : Hooks
    {
        [Test, Category("SearchForProductTest")]
        public void SearchForProductTest()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            ProductsPage products = new ProductsPage(Driver);
            //signInPage.clickOnSignInUsButton();
            //userPage.enterCredentialsAndLogin();





            //Act
            products.searchforTshirt();
            products.AddTshirtToCart();
            products.OpenCartFromTshirt();
            userPage.ProceedTocheckoutFromSummaryPageAction();
            userPage.enterCredentialsAndLogin();
            userPage.ClickOnProceedButtonDromAddressPage();
            userPage.AgreeToConditionAndProceed();
            userPage.SelectPaymentType();
            userPage.ConfirmOrder();




            //Assert

            Assert.AreEqual(userPage.OrderConfirmationTextMessage(), "Your order on My Store is complete.", "The order was not OK");
            userPage.logoutAction();
            Assert.IsTrue(signInPage.IsSigninButtonDisplayed());
            Assert.AreEqual(userPage.checkIfLoginWasOk(), "AUTHENTICATION", "Logout action was not ok");


        }
        [Test, Category("DeleteAllItemsFromCartTest")]
        public void DeleteAllItemsFromCartTest()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            ProductsPage products = new ProductsPage(Driver);
            signInPage.clickOnSignInUsButton();
            userPage.enterCredentialsAndLogin();





            //Act
            homePage.navigateInNestedMenu();
            products.AddToCardFirstDress();
            products.AddToCardSecondDress();
            products.AddTshirtToCart();
            products.OpenCartFromTshirt();
            userPage.DeleteItemsFromCart();
            userPage.DeleteItemsFromCart();
            userPage.DeleteItemsFromCart();


            //Assert

            Assert.AreEqual(products.CheckTextMessageWhenCartIsEmpty(), "Your shopping cart is empty.", "The cart is not empty");
            userPage.logoutAction();
            Assert.IsTrue(signInPage.IsSigninButtonDisplayed());
           
            

        }

        [Test, Category("AddAndDeleteProductsInBasket")]
        public void AddAndDeleteItemsFromCartTest()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            ProductsPage products = new ProductsPage(Driver);
            signInPage.clickOnSignInUsButton();
            userPage.enterCredentialsAndLogin();





            //Act
            homePage.navigateInNestedMenu();
            products.AddToCardFirstDress();
            products.AddToCardSecondDress();
            products.AddTshirtToCart();
            products.OpenCartFromTshirt();
            userPage.DeleteItemsFromCart();  
            userPage.RemoveExtraQuantity();                      
            homePage.navigateInNestedMenu();
            products.AddToCardFirstDress();
            products.AddToCardSecondDress();
            products.AddToCardThridDress();
            products.ProceedToCheckoutAction();
            userPage.DeleteItemsFromCart();
            userPage.ProceedTocheckoutFromSummaryPageAction();
            userPage.ClickOnProceedButtonDromAddressPage();
            userPage.AgreeToConditionAndProceed();
            userPage.SelectPaymentType();
            userPage.ConfirmOrder();




            //Assert

            Assert.AreEqual(userPage.OrderConfirmationTextMessage(), "Your order on My Store is complete.", "The order was not OK");
            userPage.logoutAction();
            Assert.AreEqual(userPage.checkIfLoginWasOk(), "AUTHENTICATION", "Logout action was not ok");

        }


        [Test, Category("AddMultipleItemsInBasketTest")]
        public void AddMultipleItemsInBasketTest()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            ProductsPage products = new ProductsPage(Driver);
            signInPage.clickOnSignInUsButton();
            userPage.enterCredentialsAndLogin();





            //Act
            products.AddTshirtToCart();
            products.OpenCartFromTshirt();
            userPage.AddExtraQuantity(5);
            homePage.navigateInNestedMenu();
            products.AddToCardFirstDress();
            products.AddToCardSecondDress();
            products.AddToCardThridDress();
            products.ProceedToCheckoutAction();
            userPage.ClickOnProceedButtonDromAddressPage();
            userPage.AgreeToConditionAndProceed();
            userPage.SelectPaymentType();
            userPage.ConfirmOrder();




            //Assert

            Assert.AreEqual(userPage.OrderConfirmationTextMessage(), "Your order on My Store is complete.", "The order was not OK");
            userPage.logoutAction();
            Assert.AreEqual(userPage.checkIfLoginWasOk(), "AUTHENTICATION", "Logout action was not ok");

        }


        [Test, Category("OrderSummerDressesTest")]
        public void OrderSummerDressesTest()
        {
            // Arrange
            NavigateToURL();
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            ProductsPage summerDressesPage = new ProductsPage(Driver);
            //signInPage.clickOnSignInUsButton();





            //Act
            homePage.navigateInNestedMenu();
            summerDressesPage.AddToCardFirstDress();
            summerDressesPage.AddToCardSecondDress();
            summerDressesPage.AddToCardThridDress();
            summerDressesPage.ProceedToCheckoutAction();
            userPage.enterCredentialsAndLogin();
            userPage.ClickOnProceedButtonDromAddressPage();
            userPage.AgreeToConditionAndProceed();
            userPage.SelectPaymentType();
            userPage.ConfirmOrder();
            



            //Assert
          
            Assert.AreEqual(userPage.OrderConfirmationTextMessage(), "Your order on My Store is complete.", "The order was not OK");
            userPage.logoutAction();
            Assert.AreEqual(userPage.checkIfLoginWasOk(), "AUTHENTICATION", "Logout action was not ok");

        }
    }
}
