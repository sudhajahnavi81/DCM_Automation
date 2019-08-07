@chrome
@RegressionTest
Feature: ViewAnalysis
	Verify View analysis tab calculations

@VA
Scenario: verify Forecasted Monthly Arrival Data and Actual Monthly Arrival Data in Monthly Arrivals under patient volume tab
	Given Edit Model and go to practice matrics and Arrivals/esi tab
	And Calculate Forecasted Monthly Arrival Data and Actual Monthly Arrival Data based on practice matrics and Arrivals/esi
	Then now compare calcuated Forecasted Monthly Arrival Data and Actual Monthly Arrival Data with data in Monthly Arrivals under patient volume tab
	
