Feature: Verify DirectLink to model for DCM users
		login user must have access of other's private model
	
@Task:46137
Scenario: Verify direct link to edit input tab of other's private model 
	Given Click on below link and login to open edit input tab of other's private model
	| link                                         |
	| https://dcmqa.evhc.net/v2/input?modelId=4258 |
	
	Then Verify edit input tab for logout from DCM and Okta. 
