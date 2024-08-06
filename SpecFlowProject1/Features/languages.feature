Feature: LanguageActions

A short summary of the feature

@tag1
Scenario: Verify User is able to addlanguages
    Given user logins to Marsproject
	When user clicks on Add new button under languages
	And user enters language andproficiency level 'tamil'
	And user clicks on addbutton
	Then verify language is added

	Scenario: Verify User is able to delete languages
	Given user logins to Marsproject
	When user clicks on Add new button under languages
	And user enters language andproficiency level 'Hindi'
	And user clicks on addbutton
	When user clicks on delete button under languages
	Then verify language is deleted

		Scenario: Verify User is able to edit languages
	Given user logins to Marsproject
	When user clicks on Add new button under languages 
	And user enters language andproficiency level 'Tamil'
	And user clicks on addbutton
	And user clicks on edit button
	Then verify language is edited