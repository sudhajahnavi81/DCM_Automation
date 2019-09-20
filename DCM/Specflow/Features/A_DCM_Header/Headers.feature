﻿@chrome
@SanityTest
Feature: Dashboard
	DCM login with Chrome browser and verify DCM functionality 

@test
Scenario: 01 login stringo DCM. search and select practice from dashboard
	Given Enter practice name into search practice textbox and select searched practice.
	| name                         |
	| Bay Medical Center - EM 3150 |
	Then models should show from selected practice

Scenario: 02 Verify search practice with OU, State and City
	Given click on select practice icon and search with OU state and city and select searched practice
	| OU       | State   | City        |
	| Southeast | Florida | Panama City |
	Then Searched practice should get selected

Scenario: 03 verify Operational Model History
	Given click on operational model history
	Then verify current operational model name and previous operational model names


Scenario: 04 Verify Floor Plan popup from Dashboard
	Given click on Floor Plan link and verify View, delete and upload floor plan
	Then verify uploaded image

