Feature: facebook_login_Examples
	In order to check messages
	As a user
	I want to be able to login into my account

@examples
Scenario Outline: login into facebook - positive scenario
	Given I am on "http://facebook.com"
	And I fill "#email" as "<Username>"
	And I fill "#pass" as "<Password>"
	When I click on "#loginbutton > input" button
	Then I should logged in successfully

Examples: 
	| Username                       | Password   |
	| shravan.scorpio@gmail.com      | 04D61a0442 |
	| ravalirao_korukanti@yahool.com | sainani    |
