Feature: AuthentificationTestFeature
	In order to login into website
	As a normal user
	I want to be logged in successfully 

@SmokeTests
Scenario Outline: ValidateLogin
	Given I navigate to authentification page
	When I login with following credentioals
	| userEmail             | userPassword |
	| teste@mailinator.com  | 1234 |
	When I login with user 'teste@mailinator.com'
		And password '1234'
	Then I am logged in

Examples: 
| userEmailValue        | userPasswordValue |
| teste@mailinator.com  | 1234              |
| teste2@mailinator.com | 1234              |