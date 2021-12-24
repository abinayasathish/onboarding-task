Feature: Certification

Add certification in my profile

@tag1

	Scenario:Add Certification field in my profile
	Given Iam on my Profilepage
	And I click on the Certification tab
	And I click on Add New button
	And I enter certification in certification or award text box
	And I enter certification from in text box
	And I click the year dropdown list
	When I click Add button
	Then I should see a pop up message certificate added to your Certification
	

	Scenario:Fail to add Certification field with no data
	Given Iam on my Profilepage
	And I click on the Certification tab
	When I click Add button
	Then I should see Please enter certification name, certification from and certification year
