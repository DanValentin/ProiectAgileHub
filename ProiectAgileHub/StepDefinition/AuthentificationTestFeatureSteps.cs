using System;
using TechTalk.SpecFlow;

namespace ProiectAgileHub.StepDefinition
{
    [Binding]
    public class AuthentificationTestFeatureSteps
    {
        [Given(@"I navigate to authentification page")]
        public void GivenINavigateToAuthentificationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login with following credentioals")]
        public void WhenILoginWithFollowingCredentioals(Table table)
        {
            ScenarioContext.Current.Pending();
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
    }
}
