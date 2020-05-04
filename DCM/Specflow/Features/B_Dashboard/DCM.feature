@chrome
@SanityTest
Feature: Dashboard
	DCM login with Chrome browser and verify DCM functionality 

@test
Scenario: 02 Edit Model Details 
	Given Select model other then operational model and click on edit model details button
	And select operational check box to make operational model
	Then verify operational model history

Scenario: 01 Update model name, model type and model category from Dashboard
	Given Click on Edit model details on any non operational model and update model name model type and model category and click on save
	| UpdateMN |
	| _Updated   |
	Then verify model details updated

Scenario: 03 Delete model
	Given click on Delete model icon and click on yes at confirmation pop up and click ok yes
	Then verify success message displayed and verify model has been removed from the dashboard 