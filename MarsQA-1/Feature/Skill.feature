Feature: Skill

A short summary of the feature

@tag1

	Scenario:Add Skill field in my profile
	Given Iam on my Profilepage
	And I click on the Skill tab
	And I click Add New button 
	And I enter skill text box
	And I choose Intermediate in skill level
	When I click on the Add button
	Then I should see a pop up message C# have been added to your skill

	Scenario:Skill field fail to add with no data 
	Given Iam on my Profilepage
	And I click on Add New button in skill field
	When I click on the Add button
	Then I should see a pop up message Please enter skill and level