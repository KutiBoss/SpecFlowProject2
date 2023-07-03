Feature: Login

A short summary of the feature

@tag1
Scenario Outline: verifyLoginToLearningApplication  
  Given I am on the "https://demo.nopcommerce.com/";
  When I click on  the 'Log In' button on landing page
  And I enter email "<email>"
  And I enter password  "<password>"
  And I click on 'LOG IN' button
  Then I should see the dashboard

  Examples: 
  | email | password |
  | victorianonyea@gmail.com    | Automate@23    |
