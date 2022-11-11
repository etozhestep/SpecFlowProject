Feature: SpecFlowMenuDocsTest

In order to easily find needed documentation
As a specflow user
I want to be able to navigate to pages through main menu

@smoke
Scenario Outline: Clicking menu option from the main menu should open corresponding page
	Given I open official Specflow web site
	When I hover the '<menuItem>' menu item from the main menu
	And I click '<subMenuItem>' option from the main menu
	Then The page '<title>' should be opened

	Examples: 
	| menuItem | subMenuItem     | title    |
	| Docs     | Releases        | Releases |
	| Docs     | Product roadmap | Roadmap  |
	