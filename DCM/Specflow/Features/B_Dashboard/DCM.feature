@chrome
@SanityTest
Feature: Dashboard
	DCM login with Chrome browser and verify DCM functionality 

@test
Scenario: 01 Edit Model Details 
	Given Select model other then operational model and click on edit model details button
	And select operational check box to make operational model
	Then verify operational model history

	