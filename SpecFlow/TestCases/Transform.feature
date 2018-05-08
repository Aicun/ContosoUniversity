Feature: Test transform input Table to Ojbect

Background: 
		Given I have entered value 'good morning'
		And I have entered another value 'Lu'

@Transform
Scenario Outline: Transform Table
    Given I created a person with properties as follows:
        | firstName   | lastName   | birthDate   | gender   | age   |
        | <FirstName> | <LastName> | <BirthDate> | <Gender> | <Age> |
    And I have change the person with the following properties:
		| BirthDate  |
		| 1999-01-01 |
        
    Then the person infomation should be:
		| FirstName | LastName | BirthDate  | Gender | Age | Greeting        |
		| Aicun     | Lu       | 1999-01-01 | Male   | 13  | good morning Lu |

    Examples:
        | FirstName | LastName | BirthDate  | Gender | Age |
        | Aicun     | Lu       | 2001-01-01 | Male   | 13  |

@TestHooks
Scenario: TestHooks
	Given I have a before test method
	And I hava an after test method
	And I have change the person with the following properties:
	| BirthDate  |
	| 1999-01-01 |
	Then they should be executed only once


@TestComplexConversion
Scenario: Test Complex Comversion
	Given I have entered following properties:
		| Name | Color |
		| XL   | Blue  |
		| L    | Red   |
	Then the converted result should be a complex object