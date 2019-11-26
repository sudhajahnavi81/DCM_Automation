@chrome
Feature: Perform Sensitivity Analysis
	Verify all the actions(update, refresh, reset, export and save) in Sensitivity Analysis pages

@sanity
Scenario: 01 Verify Forecasted Monthly Arrivals tab in Patient Volume
	Given Update data input fields and reset fields by clicking reset button
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear fields
	When Update data input fields and refresh fields by clicking refresh button
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Verify zoom graph for Forecasted Monthly Arrivals by month
	Then Click on Actual Monthly Arrivals tab and verified updated tab are highlighted 


	Scenario: 02 Verify Actual Monthly Arrival  tab in Patient Volume
	Given Update Actual Monthly Arrival data input fields and reset fields by clicking reset button
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5001 | 4001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 4001 | 4001 | 5001 |
	And Clear fields
	When Update Actual Monthly Arrival data input fields and refresh fields by clicking refresh button
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5001 | 4001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 4001 | 4001 | 5001 |
	And Verify zoom graph for Forecasted Monthly Arrivals by month
	Then Click on Forecasted Weekly Arrivals tab and verified updated tab are highlighted 


	Scenario: 03 Verify Forecasted Weekly Arrivals tab in Patient Volume
	Given Update data input fields and reset fields by clicking reset button in Forecasted Weekly Arrivals tab
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Monthly Arrival fields
	When Clear and Update data input fields for Actual Monthly Arrival
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Hourly Arrivals By Day Of Week fields
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And Refresh data by clicking on refresh button. 
	And Verify zoom graph for Forecasted Weekly Arrivals by month
	Then Click on Actual Weekly Arrivals tab and verified updated tab are highlighted 


	Scenario: 04 Verify Actual Weekly Arrivals tab in Patient Volume
	Given Clear Actual Hourly Arrivals By Day Of Week fields
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And Refresh data by clicking on refresh button. 
	And Verify zoom graph for Forecasted Weekly Arrivals by month
	Then Click on Actual Hourly Arrivals tab and verified updated tab are highlighted 


	Scenario: 05 Verify Actual Hourly Arrivals tab in Patient Volume
	Given Clear Actual Hourly Arrivals By Day Of Week fields
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And Refresh data by clicking on refresh button. 
	And Verify zoom graph for Forecasted Weekly Arrivals by month
	Then Click on Forecasted Hourly Arrivals tab and verified updated tab are highlighted 
	


	Scenario: 06 Verify Forecasted Hourly Arrivals tab in Patient Volume
	Given Update data input fields and reset fields by clicking reset button in Forecasted hourly Arrivals tab
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Monthly Arrival fields in Forecasted Hourly Arrivals
	When Clear and Update data input fields for Actual Monthly Arrival
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Hourly Arrivals By Day Of Week fields
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And Refresh data by clicking on refresh button. 
	And Verify zoom graph for Forecasted Weekly Arrivals by month in Forcasted hourly arrival tab
	Then Click on Provider Staffing vs Calculated WorkLoad tab and verified updated tab are highlighted 

	Scenario: 07 Verify Provider Staffing vs Calculated WorkLoad for SA
	Given Update data input fields and reset fields by clicking reset button in Forecasted hourly Arrivals tab in Provider Staffing vs Calculated WorkLoad
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Monthly Arrival fields in Provider Staffing vs Calculated WorkLoad
	When Clear and Update data input fields for Actual Monthly Arrival in Provider Staffing vs Calculated WorkLoad
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Hourly Arrivals By Day Of Week fields in Provider Staffing vs Calculated WorkLoad
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And clear Length Of Stay By Area and update with new values in Provider Staffing vs Calculated WorkLoad 
	| Overall_Admit_LOS | Overall_Arrival_To_Admit_Decision | Main_Discharge_LOS | FT_Discharge_LOS | PIT_Discharge_LOS |
	| 121               | 61                                | 91                 | 31               | 51                |
	And update shifts by importing new shifts in Provider Staffing vs Calculated WorkLoad
	And clear and update Productivity Targets by Area
	| main_phy_pph | main_app_pph | FT_Phy_pph | FT_App_PPH | PIT_Phy_pph | PIT_App_PPH |
	| 1.5          | 1            | 1          | 1          | 1           | 1           |
	And clear and update Targeted Physician PPH
	| main_PhyFirstHour | main_appFirstHour | FT_PhyfirstHour | FT_AppfirstHour |  PIT_PhyfirstHour | PIT_AppFirstHour |
	| 2                 | 1                 | 1               | 1               |  1                | 1                | 
	And Refresh data by clicking on refresh button in Provider Staffing vs Calculated WorkLoad. 
	And Verify zoom graph for Forecasted Weekly Arrivals by month in Forcasted hourly arrival tab in Provider Staffing vs Calculated WorkLoad
	Then Click on Provider Staffing vs Arrival WorkLoad tab and verified updated tab are highlighted 


	Scenario: 08 Verify Provider Staffing vs Arrivals Workload for SA
	Given Update data input fields and reset fields by clicking reset button in Forecasted hourly Arrivals tab in Provider Staffing vs Arrivals Workload
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Monthly Arrival fields in Provider Staffing vs Arrivals Workload
	When Clear and Update data input fields for Actual Monthly Arrival in Provider Staffing vs Arrivals Workload
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Hourly Arrivals By Day Of Week fields in Provider Staffing vs Arrivals Workload
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And update shifts by importing new shifts in Provider Staffing vs Arrivals Workload
	And clear and update Productivity Targets by Area in Provider Staffing vs Arrivals Workload
	| main_phy_pph | main_app_pph | FT_Phy_pph | FT_App_PPH | PIT_Phy_pph | PIT_App_PPH |
	| 1.5          | 1            | 1          | 1          | 1           | 1           |
	And clear and update Targeted Physician PPH in Provider Staffing vs Arrivals Workload
	| main_PhyFirstHour | main_appFirstHour | FT_PhyfirstHour | FT_AppfirstHour |  PIT_PhyfirstHour | PIT_AppFirstHour |
	| 2                 | 1                 | 1               | 1               |  1                | 1                | 
	And Refresh data by clicking on refresh button in Provider Staffing vs Arrivals Workload 
	And Verify zoom graph for Forecasted Weekly Arrivals by month in Forcasted hourly arrival tab in Provider Staffing vs Arrivals Workload
	Then Click on Provider Staffing vs Arrival WorkLoad tab and verified updated tab are highlighted 

	Scenario: 09 Verify Practice Productivity & Cost Summary for SA
	Given Update data input fields and reset fields by clicking reset button in Forecasted hourly Arrivals tab in Practice Productivity & Cost Summary
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Monthly Arrival fields in Practice Productivity & Cost Summary
	When Clear and Update data input fields for Actual Monthly Arrival in Practice Productivity & Cost Summary
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear Actual Hourly Arrivals By Day Of Week fields in Practice Productivity & Cost Summary
	And  click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields in SA
	|Hr_00  | Hr_01 | Hr_02 | Hr_03 | Hr_04 | Hr_05 | Hr_06 | Hr_07 | Hr_08 | Hr_09 | Hr_10 | Hr_11 | Hr_12 |  Hr_13 | Hr_14 | Hr_15 | Hr_16 | Hr_17 | Hr_18 | Hr_19 | Hr_20 | Hr_21 | Hr_22 | Hr_23 |
	| 1     | 1     | 2     | 3     | 1     | 1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     |  1     | 1     | 1     | 1     | 1     | 1     | 2     | 3     | 1     | 1     | 1     |
	And update shifts by importing new shifts in Practice Productivity & Cost Summary
	And clear and update Cost Data in Practice Productivity & Cost Summary
	| Cost_Phyhour | Cost_APPhour | Cost_Scrbhour |
	| 25           | 25           | 25			  |
	And Refresh data by clicking on refresh button in Practice Productivity & Cost Summary 
	Then Click on Save


