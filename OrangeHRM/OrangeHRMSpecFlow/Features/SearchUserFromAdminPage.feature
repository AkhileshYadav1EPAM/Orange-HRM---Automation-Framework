Feature: Search User From Admin Page

Scenario: Search user from Admin page
	Given the user in on the OrangeHRM login page
	When user enters the Username
	And user enter the Password
	And user clicks on the login button
	And user clicks on the Admin button
	And user verify if the record found in admin page
	And user enters the username, taken from one of the record found
	And user clicks on the Search button
	Then verify is the result is displayed or not