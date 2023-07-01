Feature: Login

A short summary of the feature

@tag1
Scenario: verifyLoginToLearningApplication  
	Given I am on the "https://demoqa.com/"; 
	When I enter username "Vickie@467"
	And I enter password "Automate@23"
	Then I should see the dashboard
