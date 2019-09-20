@chrome
@RegressionTest
Feature: ViewAnalysis
	Verify View analysis tab calculations

@VA
Scenario: 01 verify Forecasted Monthly Arrival Data and Actual Monthly Arrival Data calculation
	Given Edit Model and go to practice matrics and Arrivals/esi tab
	And Calculate Forecasted Monthly Arrival Data and Actual Monthly Arrival Data based on practice matrics and Arrivals/esi
	Then now compare calcuated Forecasted Monthly Arrival Data and Actual Monthly Arrival Data with data in Monthly Arrivals under patient volume tab


Scenario: 02 verify Forecasted Daily Arrivals -BY Day Of Week calculation
		Then compare calcuated Forecasted Daily Arrivals -BY Day Of Week with data in weekly Arrivals under patient volume tab

	
