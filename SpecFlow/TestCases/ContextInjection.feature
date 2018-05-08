Feature: ContextInjection
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Context
Scenario: Context Injection
	Given The person firstname 'firstname' lastname 'lastname'
	Then The person data is properly displayed
