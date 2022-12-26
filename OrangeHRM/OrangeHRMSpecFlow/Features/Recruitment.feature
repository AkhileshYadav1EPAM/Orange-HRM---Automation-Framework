Feature: Add And Verify User Addition In Recruitment Page

Scenario: Add And Verify User Addition In Recruitment Page
	Given the user is successfully logged in to OrangeHRM
	When user clicks on the Recruitment button
	And user clicks on the Recruitment Add button
	And user enters the Full Name
	And user enters the Email
	And user clicks on Save button
	Then verify if the user is added

#Scenario: Add And Verify User In Recruitment With Blank Last Name
#	Given the user is successfully logged in to OrangeHRM
#	When user clicks on the Recruitment button
#	And user clicks on the Add button
#	And user enters the only the first name
#	And user enters the Email
#	And user clicks on Save button
#	Then verify if the user is added
