Feature: Adding User From The Admin Page

Scenario: Add User From Admin Page
	Given the user is successfully logged in to OrangeHRM
	When user clicks on the Admin button
	And user clicks on the Add button
	And user selects the User Role
	And user gives the Employee Name
	And user selects the Status
	And user gives the Username
	And user gives the Password
	And user gives the Confirm Password
	And user clicks on the Save button
	Then the user is successfully added
	And user is logged out successfully


Scenario: Search user from Admin page
	Given the user is successfully logged in to OrangeHRM
	When user clicks on the Admin button
	And user verify if the record found in admin page
	And user enters the username, taken from one of the record found
	Then verify is the result is displayed or not
	And user is logged out successfully