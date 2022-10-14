Feature: ToDoMvc
	Add 10 items in the ToDoMvc
	Select 5 items that have completed
	Clear All Completed items

@Test
Scenario: Add item to the ToDoMvc
	Given I navigated to ToDoMvc
	When I add 10 tasks in the todo list
	Then close the browser instance

Scenario: Remove 5 tasks completed and view all completed task
	Given I navigated to ToDoMvc
	When I add 10 tasks in the todo list
	And I select 5 tasks to mark as completed
	And I click on view completed
	When I click on clear completed
	Then close the browser instance

Scenario: View all Active task
	Given I navigated to ToDoMvc
	When I add 10 tasks in the todo list
	And I select 5 tasks to mark as completed
	And I click on view active
	Then close the browser instance
