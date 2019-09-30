@chrome
@SanityTest
Feature: Import Model
		DCM login with Chrome browser and Create Model Using Importing Other model
	
@mytag
Scenario:Create Model Using Importing Other model
Given click on create model tab from dashboard and click on Import from Existing Model
When Search model and click on searched model name
| SearchText |
| Automation |
Then Save model and verify imported model name
 