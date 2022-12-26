Feature: Search Employee In Time Page

Scenario: Search Employee In Time Page
	Given the user is successfully logged in to OrangeHRM
	When user clicks on the Time button
	And user verify if the time record found in time page
	And user takes the employee name from one of the found record
	And user enters the employee name
	And user clicks on the view button
	Then verify that the time result is displayed or not
	