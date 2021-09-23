Feature: GetUsers
	Testing the User Service

@UserTests
Scenario: Get Users should populate Box
	Given that I have opened the ui client
	When I click the 'Get Users' button
	Then The users should populate the listbox
