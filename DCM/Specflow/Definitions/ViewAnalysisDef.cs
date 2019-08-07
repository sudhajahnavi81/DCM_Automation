using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;

namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class ViewAnalysisDef
    {
        [Given(@"Edit Model and go to practice matrics and Arrivals/esi tab")]
        public void GivenEditModelAndGoToPracticeMatricsAndArrivalsEsiTab()
        {
            ViewAnalysis.editmodel();
        }

        [Given(@"Calculate Forecasted Monthly Arrival Data and Actual Monthly Arrival Data based on practice matrics and Arrivals/esi")]
        public void GivenCalculateForecastedMonthlyArrivalDataAndActualMonthlyArrivalDataBasedOnPracticeMatricsAndArrivalsEsi()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"now compare calcuated Forecasted Monthly Arrival Data and Actual Monthly Arrival Data with data in Monthly Arrivals under patient volume tab")]
        public void ThenNowCompareCalcuatedForecastedMonthlyArrivalDataAndActualMonthlyArrivalDataWithDataInMonthlyArrivalsUnderPatientVolumeTab()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
