Feature: Search User On Leave Page

Scenario: Search user on leave page
	Given the user is successfully logged in to OrangeHRM
	When user clicks on the Leave button
	And user verify if the leave record found in admin page
	And user takes start date and end date from one of the record
	And user put that start date and end date in To Date Field
	And user clicks on the Search button
	Then verify that the reocrd is displayed or not
