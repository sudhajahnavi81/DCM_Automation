@chrome
Feature: Perform Sensitivity Analysis
	Verify all the actions(update, refresh, reset, export and save) in Sensitivity Analysis pages

@sanity
Scenario: Verify Forecasted Monthly Arrivals tab in Patient Volume
	Given Update data input fields and reset fields by clicking reset button
	| Forecasted_Annual_Volume  | Percentage_Variation  | JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 77000						|					  2 | 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Clear fields
	When Update data input fields and refresh fields by clicking refresh button
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5000 | 4000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 5000 | 4000 | 4000 | 5000 |
	And Verify zoom graph for Forecasted Monthly Arrivals by month
	Then Click on Actual Monthly Arrivals tab and verified updated tab are highlighted 


	Scenario: Verify Actual Monthly Arrival  tab in Patient Volume
	Given Update Actual Monthly Arrival data input fields and reset fields by clicking reset button
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5001 | 4001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 4001 | 4001 | 5001 |
	And Clear fields
	When Update Actual Monthly Arrival data input fields and refresh fields by clicking refresh button
	| JAN  | FEB  | MAR  | APR  | MAY  | JUN  | JUL  | AUG  | SEP  | OCT  | NOV  | DEC  |
	| 5001 | 4001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 5001 | 4001 | 4001 | 5001 |
	And Verify zoom graph for Forecasted Monthly Arrivals by month
	Then Click on Forecasted Weekly Arrivals tab and verified updated tab are highlighted 
	

