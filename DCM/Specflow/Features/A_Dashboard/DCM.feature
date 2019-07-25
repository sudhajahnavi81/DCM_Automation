@chrome
@SanityTest
Feature: Dashboard
	DCM login with Chrome browser and verify DCM functionality 

@test
Scenario: 01 login into DCM. search and select practice from dashboard
	Given Enter practice name into search practice textbox and select searched practice.
	| name                         |
	| Bay Medical Center - EM 3150 |
	Then models should show from selected practice


Scenario: 02 verify Operational Model History
	Given click on operational model history
	Then verify current operational model name and previous operational model names


Scenario: 03 Verify Floor Plan popup from Dashboard
	Given click on Floor Plan link and verify View, delete and upload floor plan
	Then verify uploaded image


Scenario: 04 Edit Model Details 
	Given Select model other then operational model and click on edit model details button
	And select operational check box to make operational model
	Then verify operational model history

	