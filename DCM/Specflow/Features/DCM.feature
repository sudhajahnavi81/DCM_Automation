@chrome
@SanityTest
Feature: DCM Automation
	DCM login with Chrome browser and verify DCM functionality 


Scenario: login into DCM. search and select practice from dashboard
	Given Enter practice name into search practice textbox and select searched practice.
	| name                            |
	| Bay Medical Center - EM 3150 |
	Then models should show from selected practice


Scenario: verify Operational Model History
	Given click on operational model history
	Then verify current operational model name and privious opearation model names

Scenario: Verify Floor Plan popup from Dashboard
	Given click on Floor Plan link and verify View, delete and upload floor plan
	Then verify uploaded image
	

Scenario: Create model 
	Given click on create model tab from dashboard and click on Create Model using Free Form from popup
	And enter vlaues into Practice Metrics fields and click on next button or click on Arrivals/ESI
	| Area2 | Area3 | Forecasted Annual Arrivals (walkouts included) | Current LWBS rate (walkouts) | Admit Percentage % |
	| FT    | PIT   | 80000                                          | 3                            | 12                 |
	When Arrivals/ESL tab opens enter vlaues into fileds and click on next button or click on Length of Stay
	And Length of Stay tab opens enter vlaues into fileds and click on next button or click on Shifts
	When Shifts tab opens enter vlaues into fileds and click on next button or click on Clinician Productivity
	And Clinician Productivity tab opens enter vlaues into fileds and click on next button or click on Clinician Cost
	When Clinician Cost tab opens enter vlaues into fileds and click on next button or click on Save Button
	Then Model should be saved with values enter into save model popup.




	