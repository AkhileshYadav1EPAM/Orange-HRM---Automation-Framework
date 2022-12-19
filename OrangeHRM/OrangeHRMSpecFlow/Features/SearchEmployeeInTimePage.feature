Feature: Search Employee In Time Page

Scenario: Search Employee In Time Page
	Given the user in on the OrangeHRM login page
	When user enters the Username
	And user enter the Password
	And user clicks on the login button
	And user clicks on the Time button
	And user verify if the record found in admin page
	And user enters the username, taken from one of the record found
	And user clicks on the Search button
	Then verify is the result is displayed or not
	