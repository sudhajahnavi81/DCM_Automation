@chrome
@SanityTest
Feature: Create Model
		DCM login with Chrome browser and verify DCM functionality 
	
@mytag
Scenario: 01 Create model 
	Given click on create model tab from dashboard and click on Create Model using Free Form from popup
	And enter values into Practice Metrics fields and click on next button or click on Arrivals/ESL
	| Area2 | Area3 | Forecasted_Annual_Arrivals | Current_LWBS_rate | Admit_Percentage |
	| FT    | PIT   | 80000                      | 3                 | 12               |
	
	When Arrivals/ESL tab opens enter values into fields and click on next button or click on Length of Stay
	| FT_ESI_3 | PIT_ESI_3 |
	| 20       | 5         |
	
	And Length of Stay tab opens enter values into fields and click on next button or click on Shifts
	| Overall_Admit_LOS | Overall_Arrival_To_Admit_Decision| Main_Discharge_LOS | FT_Discharge_LOS | PIT_Discharge_LOS |
	| 120               | 60                               | 90                 | 30               | 30                |
	   
	When Shifts tab opens enter values into fields and click on next button or click on Clinician Productivity
	| From_Time | To_Time |
	| 01:00     | 08:00   |

	And Clinician Productivity tab opens enter values into fields and click on next button or click on Clinician Cost
	| main_phy_pph | main_app_pph | main_PhyFirstHour | main_appFirstHour | FT_Phy_pph | FT_App_PPH | FT_PhyfirstHour | FT_AppfirstHour | PIT_Phy_pph | PIT_App_PPH | PIT_PhyfirstHour | PIT_AppFirstHour |
	| 1.5          | 1            | 1                 | 1                 | 1          | 1          | 1               | 1               | 1           | 1           | 1                | 1                | 
	When Clinician Cost tab opens enter vlaues into fields and click on next button or click on Save Button
	| Average_Cost_per_Physician_Hour | Average_Cost_per_APP_Hour | Average_Cost_per_Scribe_Hour |
	| 20                              | 60                        | 20                           |

	Then Model should be saved with values enter into save model popup.
