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
    public sealed class CreateModelDef : Steps
    {
        [Given(@"click on create model tab from dashboard and click on Create Model using Free Form from popup")]
        public void GivenClickOnCreateModelTabFromDashboardAndClickOnCreateModelUsingFreeFormFromPopup()
        {
            CreateModel.verifyCreateModel();
        }

        [Given(@"enter values into Practice Metrics fields and click on next button or click on Arrivals/ESL")]
        public void GivenEnterVlauesIntoPracticeMetricsFieldsAndClickOnNextButtonOrClickOnArrivalsESL(Table table)
        {
            // fatching values from feature table
            dynamic PMDetails = table.CreateDynamicInstance();
           
                string area2 = PMDetails.Area2;
                string area3 = PMDetails.Area3;
                int F_Annual_arrivals = PMDetails.Forecasted_Annual_Arrivals;
                int LWBS = PMDetails.Current_LWBS_rate;
                int admitPercentage = PMDetails.Admit_Percentage;
                // create model
                CreateModel.patcticeMetrics(area2, area3, F_Annual_arrivals, LWBS, admitPercentage);
                // verifying calculation of Forecasted Annual Volume
                int Forecasted_Annual_Volume = ((F_Annual_arrivals) - ((F_Annual_arrivals * LWBS) / 100));
                String total = Forecasted_Annual_Volume.ToString();
            string UItotal = MethodsAndActions.FieldText(Page_Objects.F_Annual_Voulme).ToString();

            if(UItotal.ToLower() == total.ToLower())
            {
                
                Console.WriteLine("Forecasted Annual Volume (matched) = Forecasted Annual Arrivals (walkouts included)-(Current LWBS rate(walkouts)* Forecasted Annual Arrivals (walkouts included)/100)");
                

            }
            else
            {

                Console.WriteLine("Forecasted Annual Volume ( Not matched) = Forecasted Annual Arrivals (walkouts included)-(Current LWBS rate(walkouts)* Forecasted Annual Arrivals (walkouts included)/100)");
                
            }
        
            MethodsAndActions.JSExe(Page_Objects.PM_next);
            
        }

        [When(@"Arrivals/ESL tab opens enter values into fields and click on next button or click on Length of Stay")]
        public void WhenArrivalsESLTabOpensEnterVlauesIntoFiledsAndClickOnNextButtonOrClickOnLengthOfStay(Table table)
        {

            dynamic AEDetails = table.CreateDynamicInstance();

            int FTESI3 = AEDetails.FT_ESI_3;
            int PITESI3 = AEDetails.PIT_ESI_3;
            CreateModel.ArrivalESI(FTESI3, PITESI3);

            //IEnumerable<dynamic> AEDetails  = table.CreateDynamicSet();
            //dynamic d = new ExpandoObject();
            ////object result = DataBinder.Eval(myPerson, "PersonsAddress.HousePhone.Number");
            //dynamic chec;
            //foreach (var esi in AEDetails)
            //{
            //     d.esi = esi.esi;
            //    CreateModel.ArrivalESI(d.esi);
            //}



        }

        [When(@"Length of Stay tab opens enter values into fields and click on next button or click on Shifts")]
        public void WhenLengthOfStayTabOpensEnterVlauesIntoFiledsAndClickOnNextButtonOrClickOnShifts(Table table)
        {
            dynamic LOSDetails = table.CreateDynamicInstance();

            int OAL = LOSDetails.Overall_Admit_LOS;
            int OAAD = LOSDetails.Overall_Arrival_To_Admit_Decision;
            int MDL = LOSDetails.Main_Discharge_LOS;
            int FDL = LOSDetails.FT_Discharge_LOS;
            int PDL = LOSDetails.PIT_Discharge_LOS;
            CreateModel.LengthDfStay(OAL, OAAD, MDL, FDL, PDL);
        }

        [When(@"Shifts tab opens enter values into fields and click on next button or click on Clinician Productivity")]
        public void WhenShiftsTabOpensEnterVlauesIntoFiledsAndClickOnNextButtonOrClickOnClinicianProductivity(Table table)
        {
            dynamic Shifts = table.CreateDynamicInstance();

            //string strDateTime = "7/12/2019 2:00:00 AM";
            //string dt = Convert.ToDateTime(strDateTime).ToString("MM/dd/yyyy hh:mm tt");
            //string FromTime = dt.Substring(11, 5);
            //string strTime = string.Format("{0}:{1}", Convert.ToDateTime(dt).Hour, Convert.ToDateTime(dt).Minute);

            string strDateTime = (Shifts.From_Time).ToString("MM/dd/yyyy hh:mm tt"); 
            //string dt = Convert.ToDateTime(strDateTime).ToString("MM/dd/yyyy hh:mm tt");
           string FromTime = strDateTime.Substring(11,5);
            string strToTime = (Shifts.To_Time).ToString("MM/dd/yyyy hh:mm tt");
            //string dt1 = Convert.ToDateTime(strDateTime).ToString("MM/dd/yyyy hh:mm tt");
            string ToTime = strToTime.Substring(11,5);
            CreateModel.Shifts(FromTime, ToTime);
        }

        [When(@"Clinician Productivity tab opens enter values into fields and click on next button or click on Clinician Cost")]
        public void WhenClinicianProductivityTabOpensEnterVlauesIntoFiledsAndClickOnNextButtonOrClickOnClinicianCost(Table table)
        {

            dynamic CP = table.CreateDynamicInstance();

            Double MPP = Convert.ToDouble(CP.main_phy_pph);
            Double MAP = Convert.ToDouble(CP.main_app_pph);
            Double MPF = Convert.ToDouble(CP.main_PhyFirstHour);
            Double MAF = Convert.ToDouble(CP.main_appFirstHour);
            Double FPP = Convert.ToDouble(CP.FT_Phy_pph);
            Double FAP = Convert.ToDouble(CP.FT_App_PPH);
            Double FPF = Convert.ToDouble(CP.FT_PhyfirstHour);
            Double FAF = Convert.ToDouble(CP.FT_AppfirstHour);
            Double PPP = Convert.ToDouble(CP.PIT_Phy_pph);
            Double PAP = Convert.ToDouble(CP.PIT_App_PPH);
            Double PPF = Convert.ToDouble(CP.PIT_PhyfirstHour);
            Double PAF = Convert.ToDouble(CP.PIT_AppFirstHour);

            CreateModel.ClinicianProductivity(MPP, MAP, MPF, MAF, FPP, FAP, FPF, FAF, PPP, PAP, PPF, PAF);


        }

        [When(@"Clinician Cost tab opens enter vlaues into fields and click on next button or click on Save Button")]
        public void WhenClinicianCostTabOpensEnterVlauesIntoFiledsAndClickOnNextButtonOrClickOnSaveButton(Table table)
        {
            dynamic CC = table.CreateDynamicInstance();

            int CPPH = CC.Average_Cost_per_Physician_Hour;
            int CPAH = CC.Average_Cost_per_APP_Hour;
            int CPSH = CC.Average_Cost_per_Scribe_Hour;

            CreateModel.ClinicianCost(CPPH,CPAH,CPSH);
        }

        [Then(@"Model should be saved with values enter into save model popup\.")]
        public void ThenModelShouldBeSavedWithValuesEnterIntoSaveModelPopup_()
        {
            CreateModel.SaveModel();
            
        }


        // Edit Model Details 

        [Given(@"Select model other then operational model and click on edit model details button")]
        public void GivenSelectModelOtherThenOperationalModelAndClickOnEditModelDetailsButton()
        {
            CreateModel.EditModelDetail();
        }

        [Given(@"select operational check box to make operational model")]
        public void GivenSelectOperationaCheckBoxToMakeOperationaModel()
        {
            CreateModel.EMDOperationalcheck();
        }


        //[Then(@"verify operation model history")]
        //public void ThenVerifyOperationModelHistory()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"Arrivals/ESL tab opens import data and enter values into fields and click on next button or click on Length of Stay")]
        public void WhenArrivalsESLTabOpensImportDataAndEnterValuesIntoFieldsAndClickOnNextButtonOrClickOnLengthOfStay(Table table)
        {
            dynamic AEDetails = table.CreateDynamicInstance();

            int FTESI3 = AEDetails.FT_ESI_3;
            int PITESI3 = AEDetails.PIT_ESI_3;
            CreateModel.ArrivalESI_import(FTESI3, PITESI3);
        }

        [When(@"Shifts tab opens import values into fields and click on next button or click on Clinician Productivity")]
        public void WhenShiftsTabOpensImportValuesIntoFieldsAndClickOnNextButtonOrClickOnClinicianProductivity()
        {
            CreateModel.Shifts_Import();
        }

        //create model with manual entry

        [When(@"Arrivals/ESL tab opens, select let me enter my own from dropdown and enter values into Actual Monthly Arrival fields")]
        public void WhenArrivalsESLTabOpensSelectLetMeEnterMyOwnFromDropdownAndEnterValuesIntoActualMonthlyArrivalFields(Table table)
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

            CreateModel.manual_Actual_Monthly_Arrival(JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC);
        }

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Sunday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForSundayFields(Table table)
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

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Monday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForMondayFields(Table table)
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

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Tuesday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForTuesdayFields(Table table)
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

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Wednesday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForWednesdayFields(Table table)
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

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Thursday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForThursdayFields(Table table)
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

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Friday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForFridayFields(Table table)
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

        [When(@"enter values into Actual Hourly Arrivals By Day Of Week for Saturday fields")]
        public void WhenEnterValuesIntoActualHourlyArrivalsByDayOfWeekForSaturdayFields(Table table)
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

        [When(@"select let me enter my own from dropdown and enter values into Segmentation by ESI Levels fields")]
        public void WhenSelectLetMeEnterMyOwnFromDropdownAndEnterValuesIntoSegmentationByESILevelsFields(Table table)
        {
            dynamic OverallED = table.CreateDynamicInstance();
           
            int ESI1 = OverallED.ESI1;
            int ESI2 = OverallED.ESI2;
            int ESI3 = OverallED.ESI3;
            int ESI4 = OverallED.ESI4;

            CreateModel.Overall_ED(ESI1, ESI2, ESI3, ESI4);
        }

        [When(@"enter values into Area1 fields")]
        public void WhenEnterValuesIntoAreaFields(Table table)
        {
            dynamic Area1 = table.CreateDynamicInstance();

            int ESI1 = Area1.ESI1;
            int ESI2 = Area1.ESI2;
            int ESI3 = Area1.ESI3;
            int ESI4 = Area1.ESI4;
            int ESI5 = Area1.ESI5;
            CreateModel.Area1_ED(ESI1, ESI2, ESI3, ESI4, ESI5);
        }

        [When(@"enter values into Area2 fields and click on next button")]
        public void WhenEnterValuesIntoAreaFieldsAndClickOnNextButton(Table table)
        {
            dynamic Area2 = table.CreateDynamicInstance();

            int ESI1 = Area2.ESI1;
            int ESI2 = Area2.ESI2;
            int ESI3 = Area2.ESI3;
            int ESI4 = Area2.ESI4;
            int ESI5 = Area2.ESI5;
            CreateModel.Area2_ED(ESI1, ESI2, ESI3, ESI4, ESI5);
        }


    }
}
