@chrome
@SanityTest
Feature: Create Model
		DCM login with Chrome browser and verify DCM functionality 
	
@mytag
Scenario: 02 Create model with Data Benchmarking 
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
	| 01:00	    | 08:00      |

	And Clinician Productivity tab opens enter values into fields and click on next button or click on Clinician Cost
	| main_phy_pph | main_app_pph | main_PhyFirstHour | main_appFirstHour | FT_Phy_pph | FT_App_PPH | FT_PhyfirstHour | FT_AppfirstHour | PIT_Phy_pph | PIT_App_PPH | PIT_PhyfirstHour | PIT_AppFirstHour |
	| 1.5          | 1            | 2		          | 1                 | 1          | 1          | 1               | 1               | 1           | 1           | 1                | 1                | 
	When Clinician Cost tab opens enter vlaues into fields and click on next button or click on Save Button
	| Average_Cost_per_Physician_Hour | Average_Cost_per_APP_Hour | Average_Cost_per_Scribe_Hour |
	| 20                              | 60                        | 20                           |

	Then Model should be saved with values enter into save model popup.


	Scenario: 01 Create model with import  
	Given click on create model tab from dashboard and click on Create Model using Free Form from popup
	And enter values into Practice Metrics fields and click on next button or click on Arrivals/ESL
	| Area2 | Area3 | Forecasted_Annual_Arrivals | Current_LWBS_rate | Admit_Percentage |
	| FT    | PIT   | 80000                      | 3                 | 12               |
	
	When Arrivals/ESL tab opens import data and enter values into fields and click on next button or click on Length of Stay
	| FT_ESI_3 | PIT_ESI_3 |
	| 20       | 5         |
	
	And Length of Stay tab opens enter values into fields and click on next button or click on Shifts
	| Overall_Admit_LOS | Overall_Arrival_To_Admit_Decision| Main_Discharge_LOS | FT_Discharge_LOS | PIT_Discharge_LOS |
	| 120               | 60                               | 90                 | 30               | 30                |
	   
	When Shifts tab opens import values into fields and click on next button or click on Clinician Productivity
	

	And Clinician Productivity tab opens enter values into fields and click on next button or click on Clinician Cost
	| main_phy_pph | main_app_pph | main_PhyFirstHour | main_appFirstHour | FT_Phy_pph | FT_App_PPH | FT_PhyfirstHour | FT_AppfirstHour | PIT_Phy_pph | PIT_App_PPH | PIT_PhyfirstHour | PIT_AppFirstHour |
	| 1.5          | 1            | 2                 | 1                 | 1          | 1          | 1               | 1               | 1           | 1           | 1                | 1                | 
	When Clinician Cost tab opens enter vlaues into fields and click on next button or click on Save Button
	| Average_Cost_per_Physician_Hour | Average_Cost_per_APP_Hour | Average_Cost_per_Scribe_Hour |
	| 20                              | 60                        | 20                           |

	Then Model should be saved with values enter into save model popup.


	Scenario: 03 Create model with Manual Entery
	Given click on create model tab from dashboard and click on Create Model using Free Form from popup
	And enter values into Practice Metrics fields and click on next button or click on Arrivals/ESL
	| Area2 | Area3 | Forecasted_Annual_Arrivals | Current_LWBS_rate | Admit_Percentage |
	| FT    | PIT   | 80000                      | 3                 | 12               |
	
	When Arrivals/ESL tab opens, select let me enter my own from dropdown and enter values into Actual Monthly Arrival fields
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5087 | 4752 | 5336 | 5066 | 5399 | 5061 | 5227 | 5137 | 5137 | 4835 | 4856 | 5030 |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Friday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And  enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	
	When select let me enter my own from dropdown and enter values into Segmentation by ESI Levels fields
	| ESI1 | ESI2 | ESI3 | ESI4 |
	| 10   | 10   | 10   | 10   |
	And enter values into Area1 fields
	| ESI1 | ESI2 | ESI3 | ESI4 | ESI5 |
	| 10   | 10   | 10   | 10   | 10   |
	And enter values into Area2 fields and click on next button
	| ESI1 | ESI2 | ESI3 | ESI4 | ESI5 |
	| 10   | 10   | 10   | 10   | 10   |

	And Length of Stay tab opens enter values into fields and click on next button or click on Shifts
	| Overall_Admit_LOS | Overall_Arrival_To_Admit_Decision| Main_Discharge_LOS | FT_Discharge_LOS | PIT_Discharge_LOS |
	| 120               | 60                               | 90                 | 30               | 30                |
	   
	When Shifts tab opens import values into fields and click on next button or click on Clinician Productivity
	

	And Clinician Productivity tab opens enter values into fields and click on next button or click on Clinician Cost
	| main_phy_pph | main_app_pph | main_PhyFirstHour | main_appFirstHour | FT_Phy_pph | FT_App_PPH | FT_PhyfirstHour | FT_AppfirstHour | PIT_Phy_pph | PIT_App_PPH | PIT_PhyfirstHour | PIT_AppFirstHour |
	| 1.5          | 1            | 2                 | 1                 | 1          | 1          | 1               | 1               | 1           | 1           | 1                | 1                | 
	When Clinician Cost tab opens enter vlaues into fields and click on next button or click on Save Button
	| Average_Cost_per_Physician_Hour | Average_Cost_per_APP_Hour | Average_Cost_per_Scribe_Hour |
	| 20                              | 60                        | 20                           |

	Then Model should be saved with values enter into save model popup.


