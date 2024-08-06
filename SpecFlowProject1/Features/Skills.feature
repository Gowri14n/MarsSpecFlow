Feature: Skills

A short summary of the feature

@tag1
Scenario: Verify User is able to add Skills
    Given user logins to MarsprojectSkills
	Then user Navigates to Skill Module
	When user clicks on Add new button under Skills
	And user enters Skills and level 'java'
	And user clicks on Skillsaddbutton
	Then skill language is added

	Scenario: Verify User is able to delete Skills
	Given user logins to MarsprojectSkills
	Then user Navigates to Skill Module
	When user clicks on Add new button under Skills
	And user enters Skills and level 'c#'
	And user clicks on Skillsaddbutton
	When user clicks on delete button under Skills
	Then verify Skill is deleted

	Scenario: Verify User is able to edit Skills
	Given user logins to MarsprojectSkills
	Then user Navigates to Skill Module
	When user clicks on Add new button under Skills 
	And user enters Skills and level '.Net'
	And user clicks on Skillsaddbutton
	And user clicks on Skillsedit button
	Then verify Skill is edited