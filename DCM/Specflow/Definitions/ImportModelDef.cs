using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;
using DCM.POM.DCM_Objects;
using DCM.POM;
using TechTalk.SpecFlow.Assist;

namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class ImportModelDef : Steps
    {
        [Given(@"click on create model tab from dashboard and click on Import from Existing Model")]
        public void GivenClickOnCreateModelTabFromDashboardAndClickOnImportFromExistingModel()
        {
            ImportModel.verifyImportModel();
        }

        [When(@"Search model and click on searched model name")]
        public void WhenSearchModelAndClickOnSearchedModelName(Table table)
        {
            dynamic SearchImodel = table.CreateDynamicInstance();

            string SearchText = SearchImodel.SearchText;
            ImportModel.selectImportModel(SearchText);
        }

        [Then(@"Save model and verify imported model name")]
        public void WhenEnterModelNameAndClickOnSaveButton()
        {
            ImportModel.saveImportedModel();
        }

        

    }
}
