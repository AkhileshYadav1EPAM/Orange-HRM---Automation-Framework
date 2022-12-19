Feature: Add And Verify User In Recruitment With Blank Last Name


Scenario: Add And Verify User In Recruitment With Blank Last Name
	Given the user in on the OrangeHRM login page
	When user enters the Username
	And user enter the Password
	And user clicks on the login button
	And user clicks on the Recruitment button
	And user clicks on the Add button
	And user enters the only the first name
	And user enters the Email
	And user clicks on Save button
	Then verify if the user is added

