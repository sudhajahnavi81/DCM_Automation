@chrome
@SanityTest

Feature: LoadModelList
	Search models, Sort model list and perform Actions


Scenario: 01 Search models with different filters
	Given Go to Load model list - Models in Selected practice and enter partial model name and click on last modeified by DD and deselect Select all and search one user and select that user and enter from and To date and enter model type
	| Modelname  | Modifieduser  |  Modeltype	 |
	| Automation |   Sunil	     |     public    |
	And verify model displayed accorinf to selected
	Then Click on Edit Model Details update model information and verify updated information
	| Updatemodelname |
	| _Updated        |

Scenario: 02 verify View Analysis and Edit input tabs opened
	Given  Go to Load model list - Models in Selected practice and enter partial model name and click on last modeified by DD and deselect Select all and search one user and select that user and enter from and To date and enter model type
	| Modelname | Modifieduser | Modeltype |
	| Nehal     | Sunil		   |     Private   |
	And Search model and click on View Analysis and check view analysis tab opened
	And Come back to load model list and click on Edit Input button and verify Edit input tab opened
	
