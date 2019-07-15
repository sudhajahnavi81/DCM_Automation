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

        [Given(@"enter vlaues into Practice Metrics fields and click on next button or click on Arrivals/ESL")]
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
            string UItotal = MethodsAndActions.FieldText(Page_Objects.F_Annual_Voulme);

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

        [When(@"Arrivals/ESL tab opens enter vlaues into fileds and click on next button or click on Length of Stay")]
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

        [When(@"Length of Stay tab opens enter vlaues into fileds and click on next button or click on Shifts")]
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

        [When(@"Shifts tab opens enter vlaues into fileds and click on next button or click on Clinician Productivity")]
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

        [When(@"Clinician Productivity tab opens enter vlaues into fileds and click on next button or click on Clinician Cost")]
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

        [When(@"Clinician Cost tab opens enter vlaues into fileds and click on next button or click on Save Button")]
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

    }
}
