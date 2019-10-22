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
    public sealed class Perform_Sensitivity_Analysis : Steps
    {
        [Given(@"Update data input fields and reset fields by clicking reset button")]
        public void GivenUpdateDataInputFieldsAndResetFieldsByClickingResetButton(Table table)
        {
            SensitivityAnalysis.SA_SensitivityAnalysis();
            dynamic Actual_Monthly_Arrival = table.CreateDynamicInstance();

            int Forecasted_Annual_Volume = Actual_Monthly_Arrival.Forecasted_Annual_Volume;
            int Percentage_Variation = Actual_Monthly_Arrival.Percentage_Variation;
            int JAN = Actual_Monthly_Arrival.JAN;
            int FEB = Actual_Monthly_Arrival.FEB;
            int MAR = Actual_Monthly_Arrival.MAR;
            int APR = Actual_Monthly_Arrival.APR;
            int MAY = Actual_Monthly_Arrival.MAY;
            int JUN = Actual_Monthly_Arrival.JUN;
            int JUL = Actual_Monthly_Arrival.JUL;
            int AUG = Actual_Monthly_Arrival.AUG;
            int SEP = Actual_Monthly_Arrival.SEP;
            int OCT = Actual_Monthly_Arrival.OCT;
            int NOV = Actual_Monthly_Arrival.NOV;
            int DEC = Actual_Monthly_Arrival.DEC;

            SensitivityAnalysis.SA_Forecasted_AnnualVolume(Forecasted_Annual_Volume, Percentage_Variation);
            SensitivityAnalysis.SA_Actual_MonthlyArrival(JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC);


        }

        [Given(@"Clear fields")]
        public void GivenClearFields()
        {
            SensitivityAnalysis.clearField();
        }

        [When(@"Update data input fields and refresh fields by clicking refresh button")]
        public void WhenUpdateDataInputFieldsAndRefreshFieldsByClickingResetButton(Table table)
        {
            dynamic Actual_Monthly_Arrival = table.CreateDynamicInstance();

            int JAN = Actual_Monthly_Arrival.JAN;
            int FEB = Actual_Monthly_Arrival.FEB;
            int MAR = Actual_Monthly_Arrival.MAR;
            int APR = Actual_Monthly_Arrival.APR;
            int MAY = Actual_Monthly_Arrival.MAY;
            int JUN = Actual_Monthly_Arrival.JUN;
            int JUL = Actual_Monthly_Arrival.JUL;
            int AUG = Actual_Monthly_Arrival.AUG;
            int SEP = Actual_Monthly_Arrival.SEP;
            int OCT = Actual_Monthly_Arrival.OCT;
            int NOV = Actual_Monthly_Arrival.NOV;
            int DEC = Actual_Monthly_Arrival.DEC;

            SensitivityAnalysis.SA_Actual_MonthlyArrival(JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC);
            SensitivityAnalysis.SA_Refresh();
        }

        [When(@"Verify zoom graph for Forecasted Monthly Arrivals by month")]
        public void WhenVerifyZoomGraphForForecastedMonthlyArrivalsByMonth()
        {
            SensitivityAnalysis.ZoomGraph();
        }

        [Then(@"Click on Actual Monthly Arrivals tab and verified updated tab are highlighted")]
        public void ThenClickOnActualMonthlyArrivalsTabAndVerifiedUpdatedTabAreHighlighted()
        {
            
        }


    }
}
