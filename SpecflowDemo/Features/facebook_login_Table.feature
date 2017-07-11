@facebook
Feature: facebook_login_Table
	In order to check messages
	As a user
	I want to be able to login into my account
#@dictionary
#Scenario: login using dictionary- positive scenario
#	Given I am on "http://facebook.com"
#	And I enter below credentials
#	| Key      | Value                     |
#	| Username | shravan.scorpio@gmail.com |
#	| Password | 04D61a0442                |
#	When I click on "#loginbutton > input" button
#	Then I should logged in successfully
#
#@datatable
#Scenario: login using datatable - positive scenario
#	Given I am on "http://facebook.com"
#	And I enter below credentials
#	| Username                  | Password                  |
#	| shravan.scorpio@gmail.com | 04D61a0442                |
#	When I click on "#loginbutton > input" button
#	Then I should logged in successfully
#
#@createinstance
#Scenario: login using createinstance - positive scenario
#	Given I am on "http://facebook.com"
#	And I enter below credentials
#	| Field    | Value                     |
#	| Username | shravan.scorpio@gmail.com |
#	| Password | 04D61a0442                |
#	When I click on "#loginbutton > input" button
#	Then I should logged in successfully
#
#@createset
#Scenario: login using createset - positive scenario
#	Given I am on "http://facebook.com"
#	And I enter below credentials
#	| Username                  | Password                  |
#	| shravan.scorpio@gmail.com | 04D61a0442                |
#	When I click on "#loginbutton > input" button
#	Then I should logged in successfully

#@createdynamicset
#Scenario: login using createdynamicset - positive scenario
#	Given I am on "http://facebook.com"
#	And I enter below credentials
#	| Username                       | Password                  |
#	| shravan.scorpio@gmail.com      | 04D61a0442                |
#	# multiple rows data can be used with this
#	When I click on "#loginbutton > input" button
#	Then I should logged in successfully

@createdynamicinstance
Scenario: login using createdynamicinstance - positive scenario
	Given I am on "http://facebook.com"
	And I enter below credentials
	| Username                       | Password                  |
	| shravan.scorpio@gmail.com      | 04D61a0442                |
	# Only Single row of Data can be used with this.
	When I click on "#loginbutton > input" button
	Then I should logged in successfully