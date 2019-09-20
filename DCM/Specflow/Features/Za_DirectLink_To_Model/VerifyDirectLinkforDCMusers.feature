@chrome
Feature: Verify DirectLink to model for DCM users
		Verify with Full access and Viewer role
	
@Task:46137
Scenario: 01 Verify direct link to edit input tab of other's private model 
	Given verify current URL
	And Click on below link and login to open edit input tab of other's private model
	| link                                         |
	| https://dcmqa.evhc.net/v2/input?modelId=4258 |
	
	Then Verify edit input tab And logout from DCM and Okta. 

	Scenario: 02 Verify direct link to View Analysis tab of other's private model 
	Given verify current URL
	And Click on below link and login to open View Analysis tab of other's private model
	| link                                         |
	| https://dcmqa.evhc.net/v2/analysis?modelId=4295 |
	
	Then Verify edit input tab And logout from DCM and Okta.

	Scenario: 03 Verify direct link to Sensitivity Analysis tab of other's private model 
	Given verify current URL
	And Click on below link and login to open Sensitivity Analysis tab of other's private model
	| link                                         |
	| https://dcmqa.evhc.net/v2/sensitivityanalysis?modelId=4258 |
	
	Then Verify edit input tab And logout from DCM and Okta.

	Scenario: 04 Verify direct link to Executive Summary tab of other's private model 
	Given verify current URL
	And Click on below link and login to open Executive Summary tab of other's private model
	| link                                         |
	| https://dcmqa.evhc.net/v2/executivesummary?modelId=4258 |
	
	Then Verify edit input tab And logout from DCM and Okta.



	@viewer_role

	Scenario: 05 Verify direct link to edit input tab using Viewer role
	Given verify current URL
	And Click on below link and login to open edit input tab using Viewer role
	| link                                         |
	| https://dcmqa.evhc.net/v2/input?modelId=4258 |
	
	Then Verify edit input tab And logout from DCM and Okta. 

	Scenario: 06 Verify direct link to View Analysis tab using Viewer role
	Given verify current URL
	And Click on below link and login to open View Analysis tab using Viewer role
	| link                                         |
	| https://dcmqa.evhc.net/v2/analysis?modelId=4295 |
	
	Then Verify edit input tab And logout from DCM and Okta.

	Scenario: 07 Verify direct link to Sensitivity Analysis tab using Viewer role 
	Given verify current URL
	And Click on below link and login to open Sensitivity Analysis tab using Viewer role
	| link                                         |
	| https://dcmqa.evhc.net/v2/sensitivityanalysis?modelId=4258 |
	
	Then Verify edit input tab And logout from DCM and Okta.

	Scenario: 08 Verify direct link to Executive Summary tab using Viewer role 
	Given verify current URL
	And Click on below link and login to open Executive Summary tab using Viewer role
	| link                                         |
	| https://dcmqa.evhc.net/v2/executivesummary?modelId=4258 |
	
	Then Verify edit input tab And logout from DCM and Okta.