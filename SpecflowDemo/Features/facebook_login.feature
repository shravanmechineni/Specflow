Feature: facebook_login
	In order to check messages
	As a user
	I want to be able to login into my account
@shravan
Scenario: shravan login - positive scenario
	Given I am on "http://facebook.com"
	And I fill "#email" as "shravan.scorpio@gmail.com"
	And I fill "#pass" as "04D61a0442"
	When I click on "#loginbutton > input" button
	Then I should logged in successfully

@ravali
Scenario: ravali login - positive scenario
	Given I am on "http://facebook.com"
	And I fill "#email" as "ravalirao_korukanti@yahool.com"
	And I fill "#pass" as "sainani"
	When I click on "#loginbutton > input" button
	Then I should logged in successfully




