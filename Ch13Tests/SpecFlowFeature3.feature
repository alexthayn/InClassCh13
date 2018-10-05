Feature: SpecFlowFeature3
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Multiply two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press multiply
	Then the result should be 3500 on the screen

Scenario: Multiply three numbers
	Given I enter 1, 5, 6 and 2 into the calculator
	When I press multiply
	Then the result should be 60 on the screen
