Feature: Login
	In order to use the site
	As an admin user
	I want to be able to log in

@login
Scenario: Log in with SBAdmin
Given I am at the login page
	And I have entered username 'rachman.walker+sbadmin@atlanticbt.com'
	And I have entered password 'Password01!'
When I click login
Then I should be at the SBAdmin Home Page

@login
Scenario: Log in with UNC System Admin
Given I am at the login page
	And I have entered username 'rachman.walker+ncadmin@atlanticbt.com'
	And I have entered password 'Password01!'
When I click login
Then I should be at the SBAdmin Home Page

@login
Scenario: Failed Log in
Given I am at the login page
	And I have entered username 'NotARealUser@atlanticbt.com'
	And I have entered password 'abcdef'
When I click login
Then I should be at the login page