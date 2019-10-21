using System;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;
using TechTalk.SpecFlow.Assist;
using System.Threading;

namespace DCM.Specflow.Definitions
{
    [Binding]
    public class DCMAutomationSteps
    {
        [Given(@"click on create model tab from dashboard and click on Create Model using Wizard from popup")]
        public void GivenClickOnCreateModelTabFromDashboardAndClickOnCreateModelUsingWizardFromPopup()
        {
           CreateModelusingWizard.WizardOpen();
        }

        [Given(@"enter value into What is the Forecasted Annual Arrivals \(walkouts included\) of your Emergency Department\? question and hit hit enter")]
        public void GivenEnterValueintoWhatIsTheForecastedAnnualArrivalsWalkoutsIncludedOfYourEmergencyDepartmentQuestionAndHitHitEnter(Table table)
        {
            dynamic FAAW = table.CreateDynamicInstance();

            int FAA = FAAW.FAA_Wizard;
            Thread.Sleep(3000);
            CreateModelusingWizard.EnterFAA(FAA);
                       
        }

        [When(@"What's your current walkout \(Left without Triage or Left without being seen\) percentage\? question appeared then enter the value in textbox and hit enter And verify Your Forecasted Annual Volume")]
        public void WhenWhatSYourCurrentWalkoutLeftWithoutTriageOrLeftWithoutBeingSeenPercentageQuestionAppearedThenEnterTheValueInTextboxAndHitEnterAndVerifyYourForecastedAnnualVolume(Table table)
        {
            dynamic CWPW = table.CreateDynamicInstance();

            int CWP = CWPW.Current_Walkout_Percentage;
            Thread.Sleep(2000);
            CreateModelusingWizard.EnterCWP(CWP);

            CreateModelusingWizard.getforecastedvalue();
        }

               
        [When(@"What percentage of patients get admitted\?  question appeared then enter the value in text box and hit enter")]
        public void WhenWhatPercentageOfPatientsGetAdmittedQuestionAppearedThenEnterTheValueintextBoxAndHitEnter(Table table)
        {
            dynamic APPW = table.CreateDynamicInstance();

            int APP = APPW.Admitted_patients_percentage;
            CreateModelusingWizard.EnterAPP(APP);

        }

        [When(@"How many patients come to your Emergency Department each month\? Each hour during the week\? question appeared and click on Apply Data Benchmarking Average pattern and Arrivals pop up will get appeared then click on OK button and verify the Click to view Arrival link appeared")]
        public void WhenHowManyPatientsComeToYourEmergencyDepartmentEachMonthEachHourDuringTheWeekQuestionAppearedAndClickOnApplyDataBenchmarkingAveragePatternAndArrivalsPopUpWillGetAppearedThenClickOnOKButtonAndVerifyTheClickToViewArrivalLinkAppeared()
        {
            CreateModelusingWizard.SelectArrivalsData();
        }


        [When(@"What is the Emergency Severity Index \(ESI\) breakdown for your Emergency Department\?  then click on  Apply Data Benchmarking Average pattern  and ESI pop up displayed then click on OK button after click on OK verify  Click to view ESI  link")]
        public void WhenWhatIsTheEmergencySeverityIndexESIBreakdownForYourEmergencyDepartmentThenClickOnApplyDataBenchmarkingAveragePatternAndESIPopUpDisplayedThenClickOnOKButtonAfterClickOnOKVerifyClickToViewESILink()
        {
            CreateModelusingWizard.SelectESI();
        }

        [When(@"What is the Length of Stay \(in minutes\) for Admitted patients in your Emergency Department\?  question appeared, enter the value in textbox and press enter")]
        public void WhenWhatIsTheLengthOfStayInMinutesForAdmittedPatientsInYourEmergencyDepartmentQuestionAppearedEnterTheValueintextboxAndPressEnter(Table table)
        {
            dynamic LOSAPW = table.CreateDynamicInstance();
            int LOSAP = LOSAPW.Los_for_Addmitted_patients;
            CreateModelusingWizard.EnterLOSAP(LOSAP);


        }

        [When(@"What is the Length of Stay \(in minutes\) for Discharged patients in your Emergency Department\? question appeared enter the value in textbox and press enter")]
        public void WhenWhatIsTheLengthOfStayInMinutesForDischargedPatientsInYourEmergencyDepartmentQuestionAppearedEnterTheValueintextboxAndPressEnter(Table table)
        {
            dynamic LOSDPW = table.CreateDynamicInstance();
            int LOSDP = LOSDPW.Los_for_Discharged_patients;
            CreateModelusingWizard.EnterLOSDP(LOSDP);
        }

        [When(@"What is your Arrival to Admit Decision time \(in minutes\)\?  question appeared, enter the value in textbox and press enter")]
        public void WhenWhatIsYourArrivalToAdmitDecisionTimeInMinutesQuestionAppearedEnterTheValueintextboxAndPressEnter(Table table)
        {
            dynamic LOSAADTW = table.CreateDynamicInstance();
            int LOSAADT = LOSAADTW.Arrival_to_admit_decision_time;
            CreateModelusingWizard.EnterAADT(LOSAADT);
        }

        [When(@"What is your typical staffing pattern\? appeared, click on  I'd like to enter the data manually and Shifts pop up displayed then add shifts manually and click on OK to close pop up")]
        public void WhenWhatIsYourTypicalStaffingPatternAppearedClickOnIDLikeToEnterTheDataManuallyAndShiftsPopUpDisplayedThenAddShiftsManuallyAndClickOnOKToClosePopUp(Table table)
        {
            dynamic DSW = table.CreateDynamicInstance();
            int DS = DSW.Duplicate_Shifts;
            int CTT = DSW.Current_To_Time;
            int PFT = DSW.Proposed_From_Time;
            int PTT = DSW.Proposed_To_Time;
            CreateModelusingWizard.EnterShiftsmanually(DS,CTT,PFT,PTT);
        }


        //[When(@"verify the  Click to view Staffing pattern  link displayed")]
        //public void WhenVerifyTheClickToViewStaffingPatternLinkDisplayed()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [When(@"What is your average cost \(in dollars\) per Physician hours\? Please enter (.*) in case of no cost\.  question appeared, enter the value in textbox and press enter")]
        public void WhenWhatIsYourAverageCostInDollarsPerPhysicianHoursPleaseEnterInCaseOfNoCost_QuestionAppearedEnterTheValueintextboxAndPressEnter(int p0, Table table)
        {
            Thread.Sleep(2000);
            dynamic PACPHW = table.CreateDynamicInstance();
            int PC = PACPHW.Phy_cost;
            CreateModelusingWizard.EnterPhycost(PC);
        }

        [When(@"If you use Advanced Practice Providers \(APPs\), what is your average cost \(in dollars\) per APP hours\? Please enter (.*) in case of no cost\.  question appeared, enter the value in textbox and press enter")]
        public void WhenIfYouUseAdvancedPracticeProvidersAPPsWhatIsYourAverageCostInDollarsPerAPPHoursPleaseEnterInCaseOfNoCost_QuestionAppearedEnterTheValueintextboxAndPressEnter(int p0, Table table)
        {
            dynamic AACPHW = table.CreateDynamicInstance();
            int AC = AACPHW.APP_cost;
            CreateModelusingWizard.EnterAPPCost(AC);
        }

        [When(@"We have defaulted your average cost \(in dollars\) per Scribe hours to \$(.*)\. Do you want to change\?  question appeared then click on  No, I want to continue with the default average cost per Scribe hours\.")]
        public void WhenWeHaveDefaultedYourAverageCostInDollarsPerScribeHoursTo_DoYouWantToChangeQuestionAppearedThenClickOnNoIWantToContinueWithTheDefaultAverageCostPerScribeHours_(int p0)
        {
            CreateModelusingWizard.Selectdefaultscribecost();
        }

        [When(@"How many patients does your Physicians see per hour \(PPH\)\?  question appeared, enter the value in textbox and press enter")]
        public void WhenHowManyPatientsDoesYourPhysiciansSeePerHourPPHQuestionAppearedEnterTheValueintextboxAndPressEnter(Table table)
        {
            dynamic TPPW = table.CreateDynamicInstance();
            double TPP = TPPW.Targeted_Phy_PPH;
            CreateModelusingWizard.EnterTPPPH(TPP);
        }

        [When(@"How many patients does your APPs see per hour \(PPH\)\?  question appeared, enter the value in textbox and press enter and verify the  Your APP coefficient calculates to  value")]
        public void WhenHowManyPatientsDoesYourAPPsSeePerHourPPHQuestionAppearedEnterTheValueintextboxAndPressEnterAndVerifyTheYourAPPCoefficientCalculatesToValue(Table table)
        {
            dynamic TAPW = table.CreateDynamicInstance();
            double TAP = TAPW.Targeted_APP_PPH;
            CreateModelusingWizard.EnterTAPPH(TAP);
        }

        [When(@"We have defaulted your Scribe coefficient \(efficiency of providers Scribes increase in percent\) to (.*)%\. Do you want to change\?  question appeared then click on  No, I want to continue with the default Scribe coefficient\.")]
        public void WhenWeHaveDefaultedYourScribeCoefficientEfficiencyOfProvidersScribesIncreaseInPercentTo_DoYouWantToChangeQuestionAppearedThenClickOnNoIWantToContinueWithTheDefaultScribeCoefficient_(int p0)
        {
            CreateModelusingWizard.Selectdefaultscribecoeff();
        }

        [When(@"Do your Physicians have a higher than average PPH during their first hour of the work\? If YES, please enter the PPH during the first hour\. If NO, please enter (.*)\.  question appeared, enter the value in textbox and press enter")]
        public void WhenDoYourPhysiciansHaveAHigherThanAveragePPHDuringTheirFirstHourOfTheWorkIfYESPleaseEnterThePPHDuringTheFirstHour_IfNOPleaseEnter_QuestionAppearedEnterTheValueintextboxAndPressEnter(int p0, Table table)
        {
            dynamic PFHW = table.CreateDynamicInstance();
            int PF = PFHW.Phy_First_hour;
            CreateModelusingWizard.EnterPHYFH(PF);
        }

        [When(@"Do your APPs have a higher than average PPH during their first hour of the work\? If YES, please enter the PPH during the first hour\. If NO, please enter (.*)\.  question appeared, enter the value in textbox and press enter")]
        public void WhenDoYourAPPsHaveAHigherThanAveragePPHDuringTheirFirstHourOfTheWorkIfYESPleaseEnterThePPHDuringTheFirstHour_IfNOPleaseEnter_QuestionAppearedEnterTheValueintextboxAndPressEnter(int p0, Table table)
        {
            dynamic AFHW = table.CreateDynamicInstance();
            int AF = AFHW.APP_First_hour;
            CreateModelusingWizard.EnterAPPFH(AF);
        }

        [When(@"Are there any other areas in your Emergency Department\?  question appeared then click on  NO that's all")]
        public void WhenAreThereAnyOtherAreasInYourEmergencyDepartmentQuestionAppearedThenClickOnNOThatSAll()
        {
            CreateModelusingWizard.NOThatsall();
        }

        [When(@"Clinical Work Distribution for Patient Encounters  pop up displayed then click on OK button")]
        public void WhenClinicalWorkDistributionForPatientEncountersPopUpDisplayedThenClickOnOKButton()
        {
            CreateModelusingWizard.CWD_Ok();
            
        }

        [When(@"Save Model  pop up displayed then enter mandatory information and click on Save")]
        public void WhenSaveModelPopUpDisplayedThenEnterMandatoryInformationAndClickOnSave()
        {
            CreateModelusingWizard.SaveModel();
        }

        [Then(@"model should get created and success message should be displayed")]
        public void ThenModelShouldGetCreatedAndSuccessMessageShouldBeDisplayed()
        {
            CreateModelusingWizard.Successmsg_Clk_OK();
        }

        //Import data for wizard model

        [When(@"Monthly/hourly arrivals question displayed then do import data")]
        public void WhenMonthlyHourlyArrivalsQuestionDisplayedThenDoImportData()
        {
            CreateModelusingWizard.Importarrivalsdata();
        }


        [When(@"What is the Emergency Severity Index \(ESI\) breakdown for your Emergency Department\?  then click on  I'd like to enter the data manually  and ESI pop up displayed then  enter esi values click on OK button after click on OK verify  Click to view ESI  link")]
        public void WhenWhatIsTheEmergencySeverityIndexESIBreakdownForYourEmergencyDepartmentThenClickOnIDLikeToEnterTheDataManuallyAndESIPopUpDisplayedThenEnterEsiValuesClickOnOKButtonAfterClickOnOKVerifyClickToViewESILink(Table table)
        {
            dynamic ESIData = table.CreateDynamicInstance();
            int esi1 = ESIData.ESI1;
            int esi2 = ESIData.ESI2;
            int esi3 = ESIData.ESI3;
            int esi4 = ESIData.ESI4;

            CreateModelusingWizard.ESIdatamanually(esi1, esi2, esi3, esi4);

        }


        [When(@"Shifts questions displayed then do import shifts")]
        public void WhenShiftsQuestionsDisplayedThenDoImportShifts()
        {
            CreateModelusingWizard.importshifts();
        }


        [When(@"Are there any other areas in your Emergency Department\?  question appeared then click on  Fast track and answer all the questions")]
        public void WhenAreThereAnyOtherAreasInYourEmergencyDepartmentQuestionAppearedThenClickOnFastTrackAndFillAllTheQuestion(Table table)
        {
            dynamic Table = table.CreateDynamicInstance();
            //string FThoursFrom = Table.FTHoursFrom;
            //string FTHoursTo = Table.FTHoursTo;
            string strDateTime = (Table.FTHoursFrom).ToString("MM/dd/yyyy HH:mm tt");
           
            string FromTime = strDateTime.Substring(11, 5);

            string strToTime = (Table.FTHoursTo).ToString("MM/dd/yyyy HH:mm tt");
           
            string ToTime = strToTime.Substring(11, 5);

            string FTHours = FromTime + "-" + ToTime;
            int FTESI3 = Table.FTesi3;
            int FTLOS = Table.FTLOS;
            int DS = Table.Duplicate_Shifts;
            int CTT = Table.Current_To_Time;
            int PFT = Table.Proposed_From_Time;
            int PTT = Table.Proposed_To_Time;
            double FTPHYFH = Table.FTPHYFH;
            double FTAPPFH = Table.FTAPPFH;
            double FTPHYPPH = Table.FT_PHY_PPH;
            double FTAPPPPH = Table.FT_APP_PPH;

            CreateModelusingWizard.Otherareafields(FTHours,FTESI3,FTLOS,DS,CTT,PFT,PTT,FTPHYFH,FTAPPFH,FTPHYPPH,FTAPPPPH);
            


        }

        [When(@"click on No,That's All button")]
        public void WhenClickOnNoThatSAllButton()
        {
            CreateModelusingWizard.FtNOThatsall();
        }

        [When(@"Arrivals question displayed then click on Enter data manually and enter monthly data")]
        public void WhenArrivalsQuestionDisplayedThenClickOnEnterDataManuallyAndEnterMonthlyData(Table table)
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

            CreateModel.Wizard_manual_Actual_Monthly_Arrival(JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC);
        }









    }
}
