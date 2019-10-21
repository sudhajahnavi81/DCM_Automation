@chrome
@SanityTest
Feature: CreateModelwithWizard
	DCM login with Chrome browser and Create model using Wizard


Scenario: 01 Create Wizard model using data Benchmarking
	Given click on create model tab from dashboard and click on Create Model using Wizard from popup
	And enter value into What is the Forecasted Annual Arrivals (walkouts included) of your Emergency Department? question and hit hit enter
	| FAA_Wizard|
	| 80000    |
	
	When What's your current walkout (Left without Triage or Left without being seen) percentage? question appeared then enter the value in textbox and hit enter And verify Your Forecasted Annual Volume
	| Current_Walkout_Percentage |
	| 3                          |

	And  What percentage of patients get admitted?  question appeared then enter the value in text box and hit enter
	| Admitted_patients_percentage |
	| 20                           |

	When  How many patients come to your Emergency Department each month? Each hour during the week? question appeared and click on Apply Data Benchmarking Average pattern and Arrivals pop up will get appeared then click on OK button and verify the Click to view Arrival link appeared

	When  What is the Emergency Severity Index (ESI) breakdown for your Emergency Department?  then click on  Apply Data Benchmarking Average pattern  and ESI pop up displayed then click on OK button after click on OK verify  Click to view ESI  link

	When  What is the Length of Stay (in minutes) for Admitted patients in your Emergency Department?  question appeared, enter the value in textbox and press enter
	| Los_for_Addmitted_patients |
	| 147                        |
	
	When  What is the Length of Stay (in minutes) for Discharged patients in your Emergency Department? question appeared enter the value in textbox and press enter

	| Los_for_Discharged_patients |
	| 200                         |
	
	When  What is your Arrival to Admit Decision time (in minutes)?  question appeared, enter the value in textbox and press enter

	| Arrival_to_admit_decision_time |
	| 150                            |

	When  What is your typical staffing pattern? appeared, click on  I'd like to enter the data manually and Shifts pop up displayed then add shifts manually and click on OK to close pop up
	| Duplicate_Shifts |  Current_To_Time |  Proposed_From_Time |  Proposed_To_Time |
	| 2                |  18           |  05              |  19             |

	#And verify the  Click to view Staffing pattern  link displayed

	When  What is your average cost (in dollars) per Physician hours? Please enter 0 in case of no cost.  question appeared, enter the value in textbox and press enter

	| Phy_cost |
	| 350      |

	When  If you use Advanced Practice Providers (APPs), what is your average cost (in dollars) per APP hours? Please enter 0 in case of no cost.  question appeared, enter the value in textbox and press enter

	| APP_cost |
	| 300      |

	When  We have defaulted your average cost (in dollars) per Scribe hours to $20. Do you want to change?  question appeared then click on  No, I want to continue with the default average cost per Scribe hours.  

	When  How many patients does your Physicians see per hour (PPH)?  question appeared, enter the value in textbox and press enter
	
	| Targeted_Phy_PPH |
	| 2.5              |

	When  How many patients does your APPs see per hour (PPH)?  question appeared, enter the value in textbox and press enter and verify the  Your APP coefficient calculates to  value

	| Targeted_APP_PPH |
	| 1.25             |
	
	When  We have defaulted your Scribe coefficient (efficiency of providers Scribes increase in percent) to 15%. Do you want to change?  question appeared then click on  No, I want to continue with the default Scribe coefficient. 

	When  Do your Physicians have a higher than average PPH during their first hour of the work? If YES, please enter the PPH during the first hour. If NO, please enter 0.  question appeared, enter the value in textbox and press enter

	| Phy_First_hour |
	| 3              |

	When  Do your APPs have a higher than average PPH during their first hour of the work? If YES, please enter the PPH during the first hour. If NO, please enter 0.  question appeared, enter the value in textbox and press enter	

	| APP_First_hour |
	| 2              |

	When  Are there any other areas in your Emergency Department?  question appeared then click on  NO that's all 

	And  Clinical Work Distribution for Patient Encounters  pop up displayed then click on OK button

	When  Save Model  pop up displayed then enter mandatory information and click on Save

	Then model should get created and success message should be displayed


	
	Scenario: 02 Create Wizard model using Import data and manual ESI entry

	Given click on create model tab from dashboard and click on Create Model using Wizard from popup
	And enter value into What is the Forecasted Annual Arrivals (walkouts included) of your Emergency Department? question and hit hit enter
	| FAA_Wizard|
	| 50000    |
	
	When What's your current walkout (Left without Triage or Left without being seen) percentage? question appeared then enter the value in textbox and hit enter And verify Your Forecasted Annual Volume
	| Current_Walkout_Percentage |
	| 3                 |
	

	And  What percentage of patients get admitted?  question appeared then enter the value in text box and hit enter
	| Admitted_patients_percentage |
	| 20                           |

	When  Monthly/hourly arrivals question displayed then do import data

	When  What is the Emergency Severity Index (ESI) breakdown for your Emergency Department?  then click on  I'd like to enter the data manually  and ESI pop up displayed then  enter esi values click on OK button after click on OK verify  Click to view ESI  link
	| ESI1 | ESI2 | ESI 3 | ESI 4 |
	| 1    | 8    | 55    | 28    |

	When  What is the Length of Stay (in minutes) for Admitted patients in your Emergency Department?  question appeared, enter the value in textbox and press enter
	| Los_for_Addmitted_patients |
	| 147                        |
	
	When  What is the Length of Stay (in minutes) for Discharged patients in your Emergency Department? question appeared enter the value in textbox and press enter

	| Los_for_Discharged_patients |
	| 200                         |
	
	When  What is your Arrival to Admit Decision time (in minutes)?  question appeared, enter the value in textbox and press enter

	| Arrival_to_admit_decision_time |
	| 150                            |

	When  Shifts questions displayed then do import shifts
	
	When  What is your average cost (in dollars) per Physician hours? Please enter 0 in case of no cost.  question appeared, enter the value in textbox and press enter

	| Phy_cost |
	| 350      |

	When  If you use Advanced Practice Providers (APPs), what is your average cost (in dollars) per APP hours? Please enter 0 in case of no cost.  question appeared, enter the value in textbox and press enter

	| APP_cost |
	| 300      |

	When  We have defaulted your average cost (in dollars) per Scribe hours to $20. Do you want to change?  question appeared then click on  No, I want to continue with the default average cost per Scribe hours.  

	When  How many patients does your Physicians see per hour (PPH)?  question appeared, enter the value in textbox and press enter
	
	| Targeted_Phy_PPH |
	| 2.5              |

	When  How many patients does your APPs see per hour (PPH)?  question appeared, enter the value in textbox and press enter and verify the  Your APP coefficient calculates to  value

	| Targeted_APP_PPH |
	| 1.25             |
	
	When  We have defaulted your Scribe coefficient (efficiency of providers Scribes increase in percent) to 15%. Do you want to change?  question appeared then click on  No, I want to continue with the default Scribe coefficient. 

	When  Do your Physicians have a higher than average PPH during their first hour of the work? If YES, please enter the PPH during the first hour. If NO, please enter 0.  question appeared, enter the value in textbox and press enter

	| Phy_First_hour |
	| 3              |

	When  Do your APPs have a higher than average PPH during their first hour of the work? If YES, please enter the PPH during the first hour. If NO, please enter 0.  question appeared, enter the value in textbox and press enter	

	| APP_First_hour |
	| 2              |
	
	When Are there any other areas in your Emergency Department?  question appeared then click on  Fast track and answer all the questions
	| FTHoursFrom | FTHoursTo | FT_LOS | FT_PHY_PPH | FT_APP_PPH | FTesi3 | FTLOS | FTPHYFH | FTAPPFH | Duplicate_Shifts |Current_To_Time |  Proposed_From_Time |  Proposed_To_Time |
	| 09:00       | 21:00     | 90     | 3.25       | 2.75       | 5      | 90    | 4     | 3     | 2                |18           |  05              |  19             |
	

	And click on No,That's All button

	And  Clinical Work Distribution for Patient Encounters  pop up displayed then click on OK button

	When  Save Model  pop up displayed then enter mandatory information and click on Save

	Then model should get created and success message should be displayed



	Scenario: 03 Cretae model with Manual arrivals data
	
	Given click on create model tab from dashboard and click on Create Model using Wizard from popup
	And enter value into What is the Forecasted Annual Arrivals (walkouts included) of your Emergency Department? question and hit hit enter
	| FAA_Wizard|
	| 50000    |
	
	When What's your current walkout (Left without Triage or Left without being seen) percentage? question appeared then enter the value in textbox and hit enter And verify Your Forecasted Annual Volume
	| Current_Walkout_Percentage |
	| 3                 |
	

	And  What percentage of patients get admitted?  question appeared then enter the value in text box and hit enter
	| Admitted_patients_percentage |
	| 20                           |


	When Arrivals question displayed then click on Enter data manually and enter monthly data
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

	When  What is the Emergency Severity Index (ESI) breakdown for your Emergency Department?  then click on  I'd like to enter the data manually  and ESI pop up displayed then  enter esi values click on OK button after click on OK verify  Click to view ESI  link
	| ESI1 | ESI2 | ESI 3 | ESI 4 |
	| 1    | 8    | 55    | 28    |

	When  What is the Length of Stay (in minutes) for Admitted patients in your Emergency Department?  question appeared, enter the value in textbox and press enter
	| Los_for_Addmitted_patients |
	| 147                        |
	
	When  What is the Length of Stay (in minutes) for Discharged patients in your Emergency Department? question appeared enter the value in textbox and press enter

	| Los_for_Discharged_patients |
	| 200                         |
	
	When  What is your Arrival to Admit Decision time (in minutes)?  question appeared, enter the value in textbox and press enter

	| Arrival_to_admit_decision_time |
	| 150                            |

	When  Shifts questions displayed then do import shifts
	
	When  What is your average cost (in dollars) per Physician hours? Please enter 0 in case of no cost.  question appeared, enter the value in textbox and press enter

	| Phy_cost |
	| 350      |

	When  If you use Advanced Practice Providers (APPs), what is your average cost (in dollars) per APP hours? Please enter 0 in case of no cost.  question appeared, enter the value in textbox and press enter

	| APP_cost |
	| 300      |

	When  We have defaulted your average cost (in dollars) per Scribe hours to $20. Do you want to change?  question appeared then click on  No, I want to continue with the default average cost per Scribe hours.  

	When  How many patients does your Physicians see per hour (PPH)?  question appeared, enter the value in textbox and press enter
	
	| Targeted_Phy_PPH |
	| 2.5              |

	When  How many patients does your APPs see per hour (PPH)?  question appeared, enter the value in textbox and press enter and verify the  Your APP coefficient calculates to  value

	| Targeted_APP_PPH |
	| 1.25             |
	
	When  We have defaulted your Scribe coefficient (efficiency of providers Scribes increase in percent) to 15%. Do you want to change?  question appeared then click on  No, I want to continue with the default Scribe coefficient. 

	When  Do your Physicians have a higher than average PPH during their first hour of the work? If YES, please enter the PPH during the first hour. If NO, please enter 0.  question appeared, enter the value in textbox and press enter

	| Phy_First_hour |
	| 3              |

	When  Do your APPs have a higher than average PPH during their first hour of the work? If YES, please enter the PPH during the first hour. If NO, please enter 0.  question appeared, enter the value in textbox and press enter	

	| APP_First_hour |
	| 2              |
	
	When Are there any other areas in your Emergency Department?  question appeared then click on  Fast track and answer all the questions
	| FTHoursFrom | FTHoursTo | FT_LOS | FT_PHY_PPH | FT_APP_PPH | FTesi3 | FTLOS | FTPHYFH | FTAPPFH | Duplicate_Shifts |Current_To_Time |  Proposed_From_Time |  Proposed_To_Time |
	| 09:00       | 21:00     | 90     | 3.25       | 2.75       | 5      | 90    | 4     | 3     | 2                |18           |  05              |  19             |
	

	And click on No,That's All button

	And  Clinical Work Distribution for Patient Encounters  pop up displayed then click on OK button

	When  Save Model  pop up displayed then enter mandatory information and click on Save

	Then model should get created and success message should be displayed
	

