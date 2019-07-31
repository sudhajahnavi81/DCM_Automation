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
        public void GivenEnterValueIntoWhatIsTheForecastedAnnualArrivalsWalkoutsIncludedOfYourEmergencyDepartmentQuestionAndHitHitEnter(Table table)
        {
            dynamic FAAW = table.CreateDynamicInstance();

            int FAA = FAAW.FAA_Wizard;
            Thread.Sleep(2000);
            CreateModelusingWizard.EnterFAA(FAA);
            
            
        }

        [When(@"What's your current walkout \(Left without Triage or Left without being seen\) percentage\? question appeared then enter the value in textbox and hit enter")]
        public void WhenWhatSYourCurrentWalkoutLeftWithoutTriageOrLeftWithoutBeingSeenPercentageQuestionAppearedThenEnterTheValueInTextboxAndHitEnter(Table table)
        {
            dynamic CWPW = table.CreateDynamicInstance();

            int CWP = CWPW.Current_Walkout_Percentage;
            Thread.Sleep(2000);
            CreateModelusingWizard.EnterCWP(CWP);



        }

        //[When(@"verify Your Forecasted Annual Volume \(without walkouts\) is calculated to value")]
        //public void WhenVerifyYourForecastedAnnualVolumeWithoutWalkoutsIsCalculatedToValue()
        //{
            
        //    int FAA = FAA_Wizard;
        //    int Forecasted_Annual_Volume = (() - ((FAA * LWBS) / 100));
        //    String total = Forecasted_Annual_Volume.ToString();
        //    string UItotal = MethodsAndActions.FieldText(Page_Objects.F_Annual_Voulme);

        //    if (UItotal.ToLower() == total.ToLower())
        //    {

        //        Console.WriteLine("Forecasted Annual Volume (matched) = Forecasted Annual Arrivals (walkouts included)-(Current LWBS rate(walkouts)* Forecasted Annual Arrivals (walkouts included)/100)");


        //    }
        //    else
        //    {

        //        Console.WriteLine("Forecasted Annual Volume ( Not matched) = Forecasted Annual Arrivals (walkouts included)-(Current LWBS rate(walkouts)* Forecasted Annual Arrivals (walkouts included)/100)");

        //    }
        //}

        [When(@"What percentage of patients get admitted\?  question appeared then enter the value in text box and hit enter")]
        public void WhenWhatPercentageOfPatientsGetAdmittedQuestionAppearedThenEnterTheValueInTextBoxAndHitEnter(Table table)
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
        public void WhenWhatIsTheLengthOfStayInMinutesForAdmittedPatientsInYourEmergencyDepartmentQuestionAppearedEnterTheValueInTextboxAndPressEnter(Table table)
        {
            dynamic LOSAPW = table.CreateDynamicInstance();
            int LOSAP = LOSAPW.Los_for_Addmitted_patients;
            CreateModelusingWizard.EnterLOSAP(LOSAP);


        }

        [When(@"What is the Length of Stay \(in minutes\) for Discharged patients in your Emergency Department\? question appeared enter the value in textbox and press enter")]
        public void WhenWhatIsTheLengthOfStayInMinutesForDischargedPatientsInYourEmergencyDepartmentQuestionAppearedEnterTheValueInTextboxAndPressEnter(Table table)
        {
            dynamic LOSDPW = table.CreateDynamicInstance();
            int LOSDP = LOSDPW.Los_for_Discharged_patients;
            CreateModelusingWizard.EnterLOSDP(LOSDP);
        }

        [When(@"What is your Arrival to Admit Decision time \(in minutes\)\?  question appeared, enter the value in textbox and press enter")]
        public void WhenWhatIsYourArrivalToAdmitDecisionTimeInMinutesQuestionAppearedEnterTheValueInTextboxAndPressEnter(Table table)
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
        public void WhenWhatIsYourAverageCostInDollarsPerPhysicianHoursPleaseEnterInCaseOfNoCost_QuestionAppearedEnterTheValueInTextboxAndPressEnter(int p0, Table table)
        {
            Thread.Sleep(2000);
            dynamic PACPHW = table.CreateDynamicInstance();
            int PC = PACPHW.Phy_cost;
            CreateModelusingWizard.EnterPhycost(PC);
        }

        [When(@"If you use Advanced Practice Providers \(APPs\), what is your average cost \(in dollars\) per APP hours\? Please enter (.*) in case of no cost\.  question appeared, enter the value in textbox and press enter")]
        public void WhenIfYouUseAdvancedPracticeProvidersAPPsWhatIsYourAverageCostInDollarsPerAPPHoursPleaseEnterInCaseOfNoCost_QuestionAppearedEnterTheValueInTextboxAndPressEnter(int p0, Table table)
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
        public void WhenHowManyPatientsDoesYourPhysiciansSeePerHourPPHQuestionAppearedEnterTheValueInTextboxAndPressEnter(Table table)
        {
            dynamic TPPW = table.CreateDynamicInstance();
            double TPP = TPPW.Targeted_Phy_PPH;
            CreateModelusingWizard.EnterTPPPH(TPP);
        }

        [When(@"How many patients does your APPs see per hour \(PPH\)\?  question appeared, enter the value in textbox and press enter and verify the  Your APP coefficient calculates to  value")]
        public void WhenHowManyPatientsDoesYourAPPsSeePerHourPPHQuestionAppearedEnterTheValueInTextboxAndPressEnterAndVerifyTheYourAPPCoefficientCalculatesToValue(Table table)
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
        public void WhenDoYourPhysiciansHaveAHigherThanAveragePPHDuringTheirFirstHourOfTheWorkIfYESPleaseEnterThePPHDuringTheFirstHour_IfNOPleaseEnter_QuestionAppearedEnterTheValueInTextboxAndPressEnter(int p0, Table table)
        {
            dynamic PFHW = table.CreateDynamicInstance();
            int PF = PFHW.Phy_First_hour;
            CreateModelusingWizard.EnterPHYFH(PF);
        }

        [When(@"Do your APPs have a higher than average PPH during their first hour of the work\? If YES, please enter the PPH during the first hour\. If NO, please enter (.*)\.  question appeared, enter the value in textbox and press enter")]
        public void WhenDoYourAPPsHaveAHigherThanAveragePPHDuringTheirFirstHourOfTheWorkIfYESPleaseEnterThePPHDuringTheFirstHour_IfNOPleaseEnter_QuestionAppearedEnterTheValueInTextboxAndPressEnter(int p0, Table table)
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


    }
}
