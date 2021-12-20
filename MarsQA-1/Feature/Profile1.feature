Feature: Profile

Add my Profile details

@tag1


	Scenario:Able to save my full name in my profile page
	Given Iam on my profilepage
	And I enter "Abinaya" in first name field
	And I eneter "Balasubramaniam" in last name field
	When I click save button
	Then I shoud see my full name "Abinaya Balasubramaniam"

	Scenario:Fail to Save with no data in name fields in my profile page
	Given Iam on my profilepage
	When I click "save" button in the name field
	Then I should see a pop up message "first name and last name required"

	Scenario:Fail to Save with no data in first name text box in my profile 
	Given Iam on my profilepage
	And I enter "Balasubramaniam" my last name field
	When I click "save" button
	Then I should see a pop up message "first name and last name required"

	Scenario:Fail to Save with no data in last name text box in my profile
	Given Iam on my profilepage
	And I enter "Abinaya" my first name field
	When I click save button
	Then I should see a pop up message "first name and last name required"

	Scenario:Update Availability field in my profile
	Given Iam on my profilepage
	And I click on small write icon right to Availability field
	When I select "Part Time" from the dropdown list
	Then I should see a pop up message "Availability updated"

	Scenario:Update Hours field in my profile
	Given Iam on my profilepage
 	And I click on the small write icon right to Hours field
	When I select "More than 30hours a week" from the dropdown list
	Then I should see a pop up message "Availability updated"

	Scenario:Update Earn Target field in my profile
	Given Iam on my profilepage
	And I click on the small write icon right to Earn target field
	When I select "Between $500 and $1000 per month" from the dropdown list
	Then I should see a pop up message "Availability updated"

	Scenario:Add Description field in my profile
	Given Iam on my profilepage
	And I enter my description text box with 600 characters
	When I click "save" button
	Then I should see a pop up message "Description has been saved successfully"

	Scenario:Description field fail to save with no data
	Given Iam on my Profilepage
	When I click "save" button
	Then I should see a pop up message "Please, a description is required"

	Scenario:Add Descrition field with less than 600 characters
	Given Iam on my profilepage
	And I enter my description text box with less than 600 characters
	When I click "save" button
	Then I should see a pop up message "Description has been saved successfully"

	Scenario:Add new language in language field
	Given Iam on my Profile page
	And I click "Add New" button in language field
	And I enter French in the language text box
	And I click the dropdown arrow
	And I choose "Conversational" from dropdown
	When I click the "Add" button 
	Then I should see pop up message "English language has been added to your language"

	Scenario:Language field fail to update with no data 
	Given Iam on my Profilepage
	And I click on "Add New" button in language field
	When I click on the "Add" button
	Then I should see a pop up message "Please enter language and level"

	Scenario:Language field fail to add with no data on level field
	Given Iam on my Profile page
	And I click "Add New" button in language field
	And I enter English in language filed
	When I click the "Add" button
	Then I should see pop up message "Please enter language and level"

	Scenario:Language field fail to update with special characters
	Given Iam on my Profilepage
	And I click on "Add New" button in language field
	And I enter "@$#%" in language text box
	When I click on the "Add" button
	Then I should see a pop up message "Please enter valid data"

	Scenario:Language field fail to update with numbers
	Given Iam on my Profilepage
	And I click on "Add New" button in language field
	And I enter "1234" in language text box
	When I click on the "Add" button
	Then I should see a pop up message "Please enter valid data"

	Scenario:Delete the added language
	Given Iam on my Profilepage
	And I click on the language tab
	When I click on the "Remove" icon
	Then I should see pop up message "English has been deleted from your language"

	Scenario:Add Skill field in my profile
	Given Iam on my Profilepage
	And I click on the "Skill" tab
	And I click "Add New" button 
	And I enter "Leadership" in skill text box
	And I click on the dropdown arrow
	And I choose "Intermediate" in skill level
	When I click on the "Add" button
	Then I should see a pop up message "Leadership have been added to your skill"

	Scenario:Skill field fail to add with no data 
	Given Iam on my Profilepage
	And I click on "Add New" button in skill field
	When I click on the "Add" button
	Then I should see a pop up message "Please enter skill and level"

	Scenario:skill field fail to add with no data on level field
	Given Iam on my Profilepage
	And I click on "Add New" button in language field
	And I enter "Leadership" in skill filed
	When I click on the "Add" button
	Then I should see a pop up message "Please enter skill and level"

	Scenario:Delete the updated skill
	Given Iam on my Profilepage
	And I click on the skill tab
	When I click on the "Remove" icon
	Then I should see pop up message "leadership has been deleted"

    Scenario:Add Education field in my profile
    Given Iam on my Profilepage
    And I click on the "Education" tab
    And I click on the "Add New" button
    And I enter "Anna University" in College/University name text box
    And I click on the select country dropdown
    And I select "India" from country dropdown list
	And I click on the Title dropdown 
	And I select "B.Tech" from the title dropdown list
    And I click on the Degree text box
    And I enter "Bachelors" in the degree text box
    And I click on the select year dropdown
    And I select "2012" from the year dropdown list
    When I click on "Add" button
    Then I should see a pop up message "Education has been added"

    Scenario:Delete the updated data in education field
    Given Iam on my Profilepage
    When I click on "Remove" icon
	Then I should see a pop up message "Education entry successfully removed"

	Scenario:Fail to add education field with special characters
	 Given Iam on my Profilepage
    And I click on the "Education" tab
    And I click on the "Add New" button
    And I enter "@#$%^&" in College/University name text box
    And I click on the select country dropdown
    And I select "India" from country dropdown list
	And I click on the Title dropdown 
	And I select "B.Tech" from the title dropdown list
    And I click on the Degree text box
    And I enter "Bachelors" in the degree text box
    And I click on the select year dropdown
    And I select "2012" from the year dropdown list
    When I click on "Add" button
    Then I should see a pop up message "Please enter valid data"
	

	Scenario:Fail to add education field with no data
	Given Iam on my Profilepage
	And I click on the "Education" tab
	And I click on the "Add New" button
	When I click on "Add" button
    Then I should see a pop up message "Please enter all the fields"

	Scenario:Fail to add education field with numbers
	Given Iam on my Profilepage
    And I click on the "Education" tab
    And I click on the "Add New" button
    And I enter "12345" in College/University name text box
    And I click on the select country dropdown
    And I select "India" from country dropdown list
	And I click on the Title dropdown 
	And I select "B.Tech" from the title dropdown list
    And I click on the Degree text box
    And I enter "Bachelors" in the degree text box
    And I click on the select year dropdown
    And I select "2012" from the year dropdown list
    When I click on "Add" button
    Then I should see a pop up message "Please enter all the fields"
    

	Scenario:Update the added data in education field
	Given Iam on my Profilepage
	And I click on the "Education" tab
	When I click "Write" icon
	And I click on Title dropdown
	And I select "M.Tech" from title dropdown list
	When I click on the "Update" button
	Then I chould see a pop up message "Education has been updated"

	Scenario:Add Certification field in my profile
	Given Iam on my Profilepage
	And I click on the "Certification" tab
	And I click on "Add New" button
	And I enter "C#" in certification or award text box
	And I enter "Udemy" in certification text box
	And I click the year dropdown list
	And select "2018" in the year dropdown list
	When I click "Add" button
	Then I should see a pop up message "C# added to your Certification"
	

	Scenario:Fail to add Certification field with no data
	Given Iam on my Profilepage
	And I click on the "Certification" tab
	When I click "Add" button
	Then I should see "Please enter certification name, certification from and certification year"

	Scenario:Fail to add Certification field with Special Characters
	Given Iam on my Profilepage
	And I click on the "Certification" tab
	And I click on "Add New" button
	And I enter "@#$$%" in certification or award text box
	And I enter "@#&*" in certification from text box
	When I click "Add" button
	Then I should see "Please enter valid data"

	Scenario:Fail to add Certification field with numbers
	Given Iam on my Profilepage
	And I click on the "Certification" tab
	And I click on "Add New" button
	And I enter "1234" in certification or award text box
	And I enter "2358" in certification from text box
	When I click "Add" button
	Then I should see "Please enter valid data"

	Scenario:Delete the added Certification data in my profile
	Given Iam on my Profilepage
	And I click on the "Certification" tab
	When I click on the "Remove" icon
	Then I should see a pop up message "Certification entry removed successfully"

	Scenario:Update the added Certification data in my profile
	Given Iam on my Profilepage
	And I click on the "Certification" tab
	And I click on the "Write" icon
	And I click on the year dropdown list
	And I select "2019" from year dropdown list
	When I click on "Update" button
    Then I should see a pop up message "Certification has been updated"








	




