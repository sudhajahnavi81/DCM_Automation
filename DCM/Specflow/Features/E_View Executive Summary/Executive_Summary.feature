@chrome
Feature: View Executive Summary
	Verify Save in View Executive Summary

@sanity
Scenario: 01 Verify Save in View Executive Summary
Given click on View Executive summary tab and add comment in Key Observations
| Key_Observation    |
| Automation Testing |
Then Save Key Observations comments
