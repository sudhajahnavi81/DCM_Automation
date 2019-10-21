using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Dynamic;
using TechTalk.SpecFlow.Assist;
using DCM.POM.Page_Steps;

namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class LoadModelListDef : Steps
    {

        [Given(@"Go to Load model list - Models in Selected practice and enter partial model name and click on last modeified by DD and deselect Select all and search one user and select that user and enter from and To date and enter model type")]
        public void GivenGoToLoadModelList_ModelsInSelectedPracticeAndEnterPartialModelNameAndClickOnLastModeifiedByDDAndDeselectSelectAllAndSearchOneUserAndSelectThatUserAndEnterFromAndToDateAndEnterModelType(Table table)
        {
            dynamic LML = table.CreateDynamicInstance();
            string modelname = LML.Modelname;
            string modeltype = LML.Modeltype;
            string lastmodifiedname = LML.Modifieduser;

            LoadModelList.SearchModelusingFilters(modelname, lastmodifiedname, modeltype);
        }

        [Given(@"verify model displayed accorinf to selected")]
        public void GivenVerifyModelDisplayedAccorinfToSelected()
        {
            LoadModelList.Verifysearchedmodel();
        }

        [Then(@"Click on Edit Model Details update model information and verify updated information")]
        public void ThenClickOnEditModelDetailsUpdateModelInformationAndVerifyUpdatedInformation(Table table)
        {
            dynamic Updatemodelname = table.CreateDynamicInstance();
            string UMN = Updatemodelname.Updatemodelname;
            LoadModelList.Editmodeldetails(UMN);
        }


        [Given(@"Search model and click on View Analysis and check view analysis tab opened")]
        public void GivenSearchModelAndClickOnViewAnalysisAndCheckViewAnalysisTabOpened()
        {

            LoadModelList.VerifyViewAnalysistab();
            

        }

        [Given(@"Come back to load model list and click on Edit Input button and verify Edit input tab opened")]
        public void GivenComeBackToLoadModelListAndClickOnEditInputButtonAndVerifyEditInputTabOpened()
        {
            LoadModelList.VerifyEditInputtab();
        }


    }
}
