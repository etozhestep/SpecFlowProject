Feature: InstallationDoc

Go to SpecFlow web site in Docs dropdown select SpecFlow
and find from the 'search docs' field 'Installation'

@smoke
Scenario: Open Installation document page
Given I open official Specflow web site
	When I hover the 'Docs' menu item from the main menu
	And I click 'SpecFlow' option from the main menu
	And I click on 'Search docs' field
	And I enter 'Installation' on popup
	And I pick up search result 'Installation'
	Then The page 'Installation' should be opened
