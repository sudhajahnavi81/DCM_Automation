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
            ViewAnalysis.PMAEvalues();
        }

        [Then(@"now compare calcuated Forecasted Monthly Arrival Data and Actual Monthly Arrival Data with data in Monthly Arrivals under patient volume tab")]
        public void ThenNowCompareCalcuatedForecastedMonthlyArrivalDataAndActualMonthlyArrivalDataWithDataInMonthlyArrivalsUnderPatientVolumeTab()
        {
            ViewAnalysis.VA_MonthlyArrival(ViewAnalysis.AE_Forcasted_monthly_Ariival, ViewAnalysis.AE_ActualMonthlyArrival);

            
        }

        // verify Weekly Variation for each day of the week in weekly arrival under patient volume.

        
        [Then(@"compare calcuated Forecasted Daily Arrivals -BY Day Of Week with data in weekly Arrivals under patient volume tab")]
        public void ThenNowCompareCalcuatedForecastedDailyArrivals_BYDayOfWeekWithDataInWeeklyArrivalsUnderPatientVolumeTab()
        {
            ViewAnalysis.WA_DayoftheWeek(ViewAnalysis.Forcasted_Arrival_sun);
            Console.WriteLine("Weekly Variation for Sunday of the week" + ViewAnalysis.Forcasted_Arrival_sun);
        }


        
      
    }
}
