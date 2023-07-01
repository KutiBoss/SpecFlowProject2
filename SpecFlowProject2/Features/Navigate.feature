Feature: Navigate

as a tfl user
I want to be able to navigate to the website 
so that I can see homepage displayed

@tag1
Scenario: Verify I can navigate to tfl website
	Given I navigate to tfl website
	Then I should be able to see the landing page 

Scenario Outline: Verifiy I can navigate to the tfl webiste with scenario outline
	Given I navigate to new webiste "<url2>"
	Then I should be able to see the landing page 

	Examples: 
	| url2 |
	| https://tfl.gov.uk/ | 

Scenario: Verify I can navigate to tfl webiste with Tables
	Given I navigate to "website"
	| tfl |
	Then I should be able to see the landing page 