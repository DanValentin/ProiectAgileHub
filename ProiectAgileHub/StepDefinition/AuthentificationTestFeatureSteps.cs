using ProiectAgileHub.PageObjectsDemoQAPracticeForm;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ProiectAgileHub.StepDefinition
{
    public class AuthentificationTestFeatureSteps : Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public AuthentificationTestFeatureSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Given(@"I navigate to authentification page")]
        public void GivenINavigateToAuthentificationPage()
        {
            HomePage homePage = new HomePage(Driver);
            SignInPage signInPage = new SignInPage(Driver);
            UserPage userPage = new UserPage(Driver);
            signInPage.clickOnSignInUsButton();
        }

        [When(@"I login with following credentioals")]
        public void WhenILoginWithFollowingCredentioals(Table table)
        {
            //var myUser = table.CreateInstance<UserDto>();
            //UserPage userPage = new UserPage(Driver);
            //userPage.enterCredentialsAndLoginDto(myUser);
        }
    

        [When(@"I login with user '(.*)'")]
        public void WhenILoginWithUser(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"password '(.*)'")]
        public void WhenPassword(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }

        
        //public void GivenINavigateToAuthentificationPage(ScenarioContext scenarioContext)
        //{
        //    HomePage homePage = new HomePage(Driver);
        //    SignInPage signInPage = new SignInPage(Driver);
        //    UserPage userPage = new UserPage(Driver);
        //    signInPage.clickOnSignInUsButton();
        //}

        //[When(@"I login with following credentioals")]
        //public void WhenILoginWithFollowingCredentioals(Table table)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I login with user '(.*)'")]
        //public void WhenILoginWithUser(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"password '(.*)'")]
        //public void WhenPassword(int p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"I am logged in")]
        //public void ThenIAmLoggedIn()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}

