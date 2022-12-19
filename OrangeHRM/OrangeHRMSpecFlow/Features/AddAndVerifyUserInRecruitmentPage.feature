Feature: Add And Verify User Addition In Recruitment Page

Scenario: Add And Verify User Addition In Recruitment Page
	Given the user in on the OrangeHRM login page
	When user enters the Username
	And user enter the Password
	And user clicks on the login button
	And user clicks on the Recruitment button
	And user clicks on the Add button
	And user enters the Full Name
	And user enters the Email
	And user clicks on Save button
	Then verify if the user is added
