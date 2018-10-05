Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of subtracting numbers

@mytag
Scenario: Subtract two numbers
	Given I enter 50 into the calculator
	And I enter 70 into the calculator
	When I press subtract
	Then the result should be -20 on screen

Scenario: Subtract another two numbers
	Given I have entered 50 into the calculator
	And I have entered 30 into the calculator
	When I press subtract
	Then the result should be 20 on the screen