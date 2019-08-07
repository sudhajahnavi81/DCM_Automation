@chrome
@SanityTest
Feature: CreateModelwithWizard
	DCM login with Chrome browser and Create model using Wizard


Scenario: 01
	Given click on create model tab from dashboard and click on Create Model using Wizard from popup
	And enter value stringo What is the Forecasted Annual Arrivals (walkouts included) of your Emergency Department? question and hit hit enter
	| FAA_Wizard|
	| 80000    |
	
	When What's your current walkout (Left without Triage or Left without being seen) percentage? question appeared then enter the value in textbox and hit enter
	| Current_Walkout_Percentage |
	| 3                 |
	
	#//And verify Your Forecasted Annual Volume (without walkouts) is calculated to value

	And  What percentage of patients get admitted?  question appeared then enter the value in text box and hit enter
	| Admitted_patients_percentage |
	| 20                                        |

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


	 

