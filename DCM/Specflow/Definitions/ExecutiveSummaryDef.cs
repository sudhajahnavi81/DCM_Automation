using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using DCM.POM.Page_Steps;
using DCM.POM.DCM_Objects;
using DCM.POM;
using NUnit.Framework;
using System.Dynamic;
namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class ExecutiveSummaryDef : Steps
    {
        [Given(@"click on View Executive summary tab and add comment in Key Observations")]
        public void GivenClickOnViewExecutiveSummaryTabAndAddCommentInKeyObservations(Table table)
        {
            ExecutiveSummary.ExecutiveSummaryTab();
            dynamic Exe_keyObesrvation = table.CreateDynamicInstance();
            string Keyobservation = Exe_keyObesrvation.Key_Observation;
            ExecutiveSummary.KeyObservation(Keyobservation);

        }

        [Then(@"Save Key Observations comments")]
        public void ThenSaveKeyObservationsComments()
        {
            ExecutiveSummary.Executive_Save();
        }

    }
}
