@Api
Feature: Users
	Runs through querys and responses to and from the Users API

	//HELPFUl TIP! Write your scenario before your steps. Highlight the scenarion, right click and click generate step definitions
	//You can then click create or copy to clipboard to paste them into what ever step file you want
	//It will normally detect parameters for you

		Scenario: Retrieving Users
		Given that I am connected to the API
		When I requests all Users
		Then the result should contain more than 0 users

		Scenario: Adding a New User
		Given new user details "John", 30
		When I call add new user
		Then the users list should contain the new user
		
		Scenario: User with name already exists
		Given new user details "Craig", 28
		When I call add new user
		Then the API should fail with a 418 response code

		Scenario: Updating User Age
		Given that I am authenticated as User "Craig"
		When age is updated with the number 33
		Then the users age will be updated