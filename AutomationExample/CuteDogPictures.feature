@CuteDogPictures
Feature: Example Dog
	In demonstrate I am capable of designing a solution in Selenium Webdriver and Specflow
	As a person partial to dogs
	I want to look for dog pictures
	
Scenario: Look for cute dog pictures on duckduckgo.com
	Given I go to url http://www.duckduckgo.com
	When I search for cute dog pictures
	Then I see that the first 50 links have the words cute,dog,pictures in them