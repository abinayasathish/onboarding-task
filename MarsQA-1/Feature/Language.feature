Feature: Language

Add language in my Profile



Scenario:Add new language in language field
	Given Iam on my profile page
	And I click AddNew butn in the language field
	And I enter language in the language textbox
	And I select level from language level dropdown 
	When I click the Add butn 
	Then I should see French added in the language textbox

	Scenario:Add existing language language to language field
	Given Iam on my profile page
	And I click AddNew butn in the language field
	And I enter existing language
	And I select level Basic from language level dropdown 
	When I click the Add butn
	Then I should see French already exist

Scenario Outline:Language field fail to add with no data on language level
	Given Iam on my profile page
	And I click AddNew butn to add second language in the language field
	And I enter second language in the language textbox
	When I click the Add butn
	Then I should see Please enter language and level








	