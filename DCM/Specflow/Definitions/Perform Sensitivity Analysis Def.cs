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
            SensitivityAnalysis.actualMonthlyArrivalTab();
        }

        [Given(@"Update Actual Monthly Arrival data input fields and reset fields by clicking reset button")]
        public void GivenUpdateActualMonthlyArrivalDataInputFieldsAndResetFieldsByClickingResetButton(Table table)
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
        }

        [When(@"Update Actual Monthly Arrival data input fields and refresh fields by clicking refresh button")]
        public void WhenUpdateActualMonthlyArrivalDataInputFieldsAndRefreshFieldsByClickingRefreshButton(Table table)
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

        [Then(@"Click on Forecasted Weekly Arrivals tab and verified updated tab are highlighted")]
        public void ThenClickOnForecastedWeeklyArrivalsTabAndVerifiedUpdatedTabAreHighlighted()
        {
            SensitivityAnalysis.ForecastedWeeklyArrivalsTab();
        }

        //**************************************************** //

        // Secnario 3 : Forecasted Weekly Arrivals tab in SA   //

        //**************************************************** //
        [Given(@"Update data input fields and reset fields by clicking reset button in Forecasted hourly Arrivals tab")]
        [Given(@"Update data input fields and reset fields by clicking reset button in Forecasted Weekly Arrivals tab")]
        public void GivenUpdateDataInputFieldsAndResetFieldsByClickingResetButtonInForecastedWeeklyArrivalsTab(Table table)
        {
            
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

        [When(@"Clear and Update data input fields for Actual Monthly Arrival")]
        public void WhenUpdateDataInputFieldsForActualMonthlyArrival(Table table)
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
            
        }

        [Given(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields")]
        [When(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForSundayFields(Table table)
        {
            
             dynamic Sunday = table.CreateDynamicInstance();

            int Hr_00 = Sunday.Hr_00;
            int Hr_01 = Sunday.Hr_01;
            int Hr_02 = Sunday.Hr_02;
            int Hr_03 = Sunday.Hr_03;
            int Hr_04 = Sunday.Hr_04;
            int Hr_05 = Sunday.Hr_05;
            int Hr_06 = Sunday.Hr_06;
            int Hr_07 = Sunday.Hr_07;
            int Hr_08 = Sunday.Hr_08;
            int Hr_09 = Sunday.Hr_09;
            int Hr_10 = Sunday.Hr_10;
            int Hr_11 = Sunday.Hr_11;
            int Hr_12 = Sunday.Hr_12;
            int Hr_13 = Sunday.Hr_13;
            int Hr_14 = Sunday.Hr_14;
            int Hr_15 = Sunday.Hr_15;
            int Hr_16 = Sunday.Hr_16;
            int Hr_17 = Sunday.Hr_17;
            int Hr_18 = Sunday.Hr_18;
            int Hr_19 = Sunday.Hr_19;
            int Hr_20 = Sunday.Hr_20;
            int Hr_21 = Sunday.Hr_21;
            int Hr_22 = Sunday.Hr_22;
            int Hr_23 = Sunday.Hr_23;

            CreateModel.Sunday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);
        }

        [Given(@"click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields")]
        [When(@"click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Monday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForMondayFields(Table table)
        {
            
            dynamic Monday = table.CreateDynamicInstance();

            int Hr_00 = Monday.Hr_00;
            int Hr_01 = Monday.Hr_01;
            int Hr_02 = Monday.Hr_02;
            int Hr_03 = Monday.Hr_03;
            int Hr_04 = Monday.Hr_04;
            int Hr_05 = Monday.Hr_05;
            int Hr_06 = Monday.Hr_06;
            int Hr_07 = Monday.Hr_07;
            int Hr_08 = Monday.Hr_08;
            int Hr_09 = Monday.Hr_09;
            int Hr_10 = Monday.Hr_10;
            int Hr_11 = Monday.Hr_11;
            int Hr_12 = Monday.Hr_12;
            int Hr_13 = Monday.Hr_13;
            int Hr_14 = Monday.Hr_14;
            int Hr_15 = Monday.Hr_15;
            int Hr_16 = Monday.Hr_16;
            int Hr_17 = Monday.Hr_17;
            int Hr_18 = Monday.Hr_18;
            int Hr_19 = Monday.Hr_19;
            int Hr_20 = Monday.Hr_20;
            int Hr_21 = Monday.Hr_21;
            int Hr_22 = Monday.Hr_22;
            int Hr_23 = Monday.Hr_23;

            CreateModel.Monday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);

        }
        [Given(@"click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields")]
        [When(@"click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForTuesdayFields(Table table)
        {
            dynamic Tuesday = table.CreateDynamicInstance();

            int Hr_00 = Tuesday.Hr_00;
            int Hr_01 = Tuesday.Hr_01;
            int Hr_02 = Tuesday.Hr_02;
            int Hr_03 = Tuesday.Hr_03;
            int Hr_04 = Tuesday.Hr_04;
            int Hr_05 = Tuesday.Hr_05;
            int Hr_06 = Tuesday.Hr_06;
            int Hr_07 = Tuesday.Hr_07;
            int Hr_08 = Tuesday.Hr_08;
            int Hr_09 = Tuesday.Hr_09;
            int Hr_10 = Tuesday.Hr_10;
            int Hr_11 = Tuesday.Hr_11;
            int Hr_12 = Tuesday.Hr_12;
            int Hr_13 = Tuesday.Hr_13;
            int Hr_14 = Tuesday.Hr_14;
            int Hr_15 = Tuesday.Hr_15;
            int Hr_16 = Tuesday.Hr_16;
            int Hr_17 = Tuesday.Hr_17;
            int Hr_18 = Tuesday.Hr_18;
            int Hr_19 = Tuesday.Hr_19;
            int Hr_20 = Tuesday.Hr_20;
            int Hr_21 = Tuesday.Hr_21;
            int Hr_22 = Tuesday.Hr_22;
            int Hr_23 = Tuesday.Hr_23;

            CreateModel.Tuesday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);

        }

        [Given(@"click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields")]
        [When(@"click on clear and  enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForWednesdayFields(Table table)
        {
            dynamic Wednesday = table.CreateDynamicInstance();

            int Hr_00 = Wednesday.Hr_00;
            int Hr_01 = Wednesday.Hr_01;
            int Hr_02 = Wednesday.Hr_02;
            int Hr_03 = Wednesday.Hr_03;
            int Hr_04 = Wednesday.Hr_04;
            int Hr_05 = Wednesday.Hr_05;
            int Hr_06 = Wednesday.Hr_06;
            int Hr_07 = Wednesday.Hr_07;
            int Hr_08 = Wednesday.Hr_08;
            int Hr_09 = Wednesday.Hr_09;
            int Hr_10 = Wednesday.Hr_10;
            int Hr_11 = Wednesday.Hr_11;
            int Hr_12 = Wednesday.Hr_12;
            int Hr_13 = Wednesday.Hr_13;
            int Hr_14 = Wednesday.Hr_14;
            int Hr_15 = Wednesday.Hr_15;
            int Hr_16 = Wednesday.Hr_16;
            int Hr_17 = Wednesday.Hr_17;
            int Hr_18 = Wednesday.Hr_18;
            int Hr_19 = Wednesday.Hr_19;
            int Hr_20 = Wednesday.Hr_20;
            int Hr_21 = Wednesday.Hr_21;
            int Hr_22 = Wednesday.Hr_22;
            int Hr_23 = Wednesday.Hr_23;

            CreateModel.wednesday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);

        }

        [Given(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields")]
        [When(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForThursdayFields(Table table)
        {
            dynamic Thursday = table.CreateDynamicInstance();

            int Hr_00 = Thursday.Hr_00;
            int Hr_01 = Thursday.Hr_01;
            int Hr_02 = Thursday.Hr_02;
            int Hr_03 = Thursday.Hr_03;
            int Hr_04 = Thursday.Hr_04;
            int Hr_05 = Thursday.Hr_05;
            int Hr_06 = Thursday.Hr_06;
            int Hr_07 = Thursday.Hr_07;
            int Hr_08 = Thursday.Hr_08;
            int Hr_09 = Thursday.Hr_09;
            int Hr_10 = Thursday.Hr_10;
            int Hr_11 = Thursday.Hr_11;
            int Hr_12 = Thursday.Hr_12;
            int Hr_13 = Thursday.Hr_13;
            int Hr_14 = Thursday.Hr_14;
            int Hr_15 = Thursday.Hr_15;
            int Hr_16 = Thursday.Hr_16;
            int Hr_17 = Thursday.Hr_17;
            int Hr_18 = Thursday.Hr_18;
            int Hr_19 = Thursday.Hr_19;
            int Hr_20 = Thursday.Hr_20;
            int Hr_21 = Thursday.Hr_21;
            int Hr_22 = Thursday.Hr_22;
            int Hr_23 = Thursday.Hr_23;

            CreateModel.Thursday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);

        }

        [Given(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields")]
        [When(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Friday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForFridayFields(Table table)
        {
            dynamic Friday = table.CreateDynamicInstance();

            int Hr_00 = Friday.Hr_00;
            int Hr_01 = Friday.Hr_01;
            int Hr_02 = Friday.Hr_02;
            int Hr_03 = Friday.Hr_03;
            int Hr_04 = Friday.Hr_04;
            int Hr_05 = Friday.Hr_05;
            int Hr_06 = Friday.Hr_06;
            int Hr_07 = Friday.Hr_07;
            int Hr_08 = Friday.Hr_08;
            int Hr_09 = Friday.Hr_09;
            int Hr_10 = Friday.Hr_10;
            int Hr_11 = Friday.Hr_11;
            int Hr_12 = Friday.Hr_12;
            int Hr_13 = Friday.Hr_13;
            int Hr_14 = Friday.Hr_14;
            int Hr_15 = Friday.Hr_15;
            int Hr_16 = Friday.Hr_16;
            int Hr_17 = Friday.Hr_17;
            int Hr_18 = Friday.Hr_18;
            int Hr_19 = Friday.Hr_19;
            int Hr_20 = Friday.Hr_20;
            int Hr_21 = Friday.Hr_21;
            int Hr_22 = Friday.Hr_22;
            int Hr_23 = Friday.Hr_23;

            CreateModel.Friday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);

        }

        [Given(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields")]
        [When(@"click on clear and enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields")]
        public void WhenClickOnClearAndEnterValuesIntoActualHourlyArrivalsByDayOfWeekForSaturdayFields(Table table)
        {
            dynamic Saturday = table.CreateDynamicInstance();

            int Hr_00 = Saturday.Hr_00;
            int Hr_01 = Saturday.Hr_01;
            int Hr_02 = Saturday.Hr_02;
            int Hr_03 = Saturday.Hr_03;
            int Hr_04 = Saturday.Hr_04;
            int Hr_05 = Saturday.Hr_05;
            int Hr_06 = Saturday.Hr_06;
            int Hr_07 = Saturday.Hr_07;
            int Hr_08 = Saturday.Hr_08;
            int Hr_09 = Saturday.Hr_09;
            int Hr_10 = Saturday.Hr_10;
            int Hr_11 = Saturday.Hr_11;
            int Hr_12 = Saturday.Hr_12;
            int Hr_13 = Saturday.Hr_13;
            int Hr_14 = Saturday.Hr_14;
            int Hr_15 = Saturday.Hr_15;
            int Hr_16 = Saturday.Hr_16;
            int Hr_17 = Saturday.Hr_17;
            int Hr_18 = Saturday.Hr_18;
            int Hr_19 = Saturday.Hr_19;
            int Hr_20 = Saturday.Hr_20;
            int Hr_21 = Saturday.Hr_21;
            int Hr_22 = Saturday.Hr_22;
            int Hr_23 = Saturday.Hr_23;

            CreateModel.Saturday_Arrival(Hr_00, Hr_01, Hr_02, Hr_03, Hr_04, Hr_05, Hr_06, Hr_07, Hr_08, Hr_09, Hr_10, Hr_11, Hr_12, Hr_13, Hr_14, Hr_15, Hr_16, Hr_17, Hr_18, Hr_19, Hr_20, Hr_21, Hr_22, Hr_23);

        }
        [Given(@"Refresh data by clicking on refresh button\.")]
        [When(@"Refresh data by clicking on refresh button\.")]
        public void WhenRefreshDataByClickingOnRefreshButton_()
        {
            SensitivityAnalysis.SA_Refresh();
        }
        [Given(@"Verify zoom graph for Forecasted Weekly Arrivals by month")]
        public void WhenVerifyZoomGraphForActualWeeklyArrivalsByMonth()
        {
            SensitivityAnalysis.ZoomGraph_ActualWeeklyArrival();
        }

        [When(@"Verify zoom graph for Forecasted Weekly Arrivals by month")]
        public void WhenVerifyZoomGraphForForecastedWeeklyArrivalsByMonth()
        {
            SensitivityAnalysis.ZoomGraph();
        }

        [Then(@"Click on Actual Weekly Arrivals tab and verified updated tab are highlighted")]
        public void ThenClickOnActualWeeklyArrivalsTabAndVerifiedUpdatedTabAreHighlighted()
        {
            SensitivityAnalysis.ActualWeeklyArrivalsTab();
        }

        [Given(@"Clear Actual Monthly Arrival fields")]
        public void GivenClearActualMonthlyArrivalFields()
        {
            SensitivityAnalysis.ActualMonthlyArrivalClearButton();
        }


        [Given(@"Clear Actual Hourly Arrivals By Day Of Week fields")]
        public void WhenClearHourlyArrivalsByDayOfWeekFields()
        {
            SensitivityAnalysis.expandActualWeekArrivals();
            SensitivityAnalysis.ActualHourlyArrivalClearButton();
        }
        [When(@"Clear Actual Hourly Arrivals By Day Of Week fields")]
        public void WhenClearActualHourlyArrivalsByDayOfWeekFields()
        {
            SensitivityAnalysis.expandActualWeekArrivals();
            SensitivityAnalysis.ActualweeklyArrivalClearButton();
        }

        [Then(@"Click on Actual Hourly Arrivals tab and verified updated tab are highlighted")]
        public void ThenClickOnActualHourlyArrivalsTabAndVerifiedUpdatedTabAreHighlighted()
        {
            SensitivityAnalysis.ActualHourlyArrivalsTab();
        }


        [Then(@"Click on Forecasted Hourly Arrivals tab and verified updated tab are highlighted")]
        public void ThenClickOnForecastedHourlyArrivalsTabAndVerifiedUpdatedTabAreHighlighted()
        {
            SensitivityAnalysis.forcastedHourlyArrivalsTab();

            
        }

                    
        [Then(@"Click on Provider Staffing vs Calculated WorkLoad tab and verified updated tab are highlighted")]
        public void ThenClickOnProviderStaffingVsCalculatedWorkLoadTabAndVerifiedUpdatedTabAreHighlighted()
        {
            SensitivityAnalysis.ProviderStaffing_CalculatedWorkLoadTab();

            
        }








    }
}
