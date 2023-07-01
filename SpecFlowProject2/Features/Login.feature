Feature: Login

A short summary of the feature

@tag1
Scenario Outline: verifyLoginToLearningApplication  
	Given I am on the "https://demo.nopcommerce.com/";
  When I enter username "<username>"
  And I enter password  "<password>"
  Then I should see the dashboard

  Examples: 
  | username | password |
  | studentname    | 12313    |
