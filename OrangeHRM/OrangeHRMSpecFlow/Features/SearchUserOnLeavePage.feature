Feature: Search User On Leave Page

Scenario: Search user on leave page
	Given the user in on the OrangeHRM login page
	When user enters the Username
	And user enter the Password
	And user clicks on the login button
	And user clicks on the Leave button
	And user verify if the record found in admin page
	And user takes start date from one of the record
	And user put that start date in From Date Field
	And user takes end date from that record
	And user put that end date in To Date Field
	And user clicks on the Search button
	Then verify is the result is displayed or not
