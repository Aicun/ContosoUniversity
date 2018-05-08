Feature: ScenarioContext
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@showUpInScenarioInfo @andThisToo
Scenario: Showing information of the scenario
  When I execute any scenario
  Then the ScenarioInfo contains the following information
    | Field | Value                               |
    | Tags  | showUpInScenarioInfo, andThisToo    |
    | Title | Showing information of the scenario |

#This is not so easy to write a scenario for but I've created an AfterScenario-hook
@showingErrorHandling 
Scenario: Display error information in AfterScenario
	When an error occurs in a step

@CurrentScenarioBlock
Scenario: Show the type of step we're currently on
	Given I have a Given step
	And I have another Given step
	When I have a When step
	Then I have a Then step