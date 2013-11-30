@CuteCatPictures
Feature: Example Cat
	In demonstrate I am capable of designing a solution in Selenium Webdriver and Specflow
	As a person partial to cats
	I want to look for cat pictures
	
Scenario: Look for cute cat pictures on duckduckgo.com
	Given I go to url http://www.duckduckgo.com
	When I search for cute cat pictures
	Then I see that the first 50 links have the words cute,cat,pictures in them