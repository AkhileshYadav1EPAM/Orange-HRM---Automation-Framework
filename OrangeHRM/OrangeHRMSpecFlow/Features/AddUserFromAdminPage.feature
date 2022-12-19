Feature: Adding User From The Admin Page

Scenario: Add User From Admin Page
	Given the user in on the OrangeHRM login page
	When user enters the Username
	And user enter the Password
	And user clicks on the login button
	And user clicks on the Admin button
	And user clicks on the Add button
	And user selects the User Role
	And user gives the Employee Name
	And user selects the Status
	And user gives the Username
	And user gives the Password
	And user gives the Confirm Password
	And user clicks on the Save button
	Then the user is successfully added