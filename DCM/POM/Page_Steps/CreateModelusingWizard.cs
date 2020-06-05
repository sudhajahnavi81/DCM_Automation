using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using DCM.POM;
using System.Threading;

namespace DCM.POM.Page_Steps 
{
    class CreateModelusingWizard : MethodsAndActions
    {
        public static void WizardOpen()
        {
            click(Page_Objects.Appname);
            Thread.Sleep(10000);
            JSExe(Page_Objects.createModelTab);
            // WaitForElement(Page_Objects.createModelPopUp);
            Thread.Sleep(5000);
            JSExe(Page_Objects.createmodelusingwizardbtn);

        }

        public static void EnterFAA(int FAA)
        {

            Thread.Sleep(5000);
            Type(FAA.ToString(), Page_Objects.ForecastedAnnualArrivals);
           
            Enterkey(Page_Objects.ForecastedAnnualArrivals);

        }


        public static void EnterCWP(int CWP)
        {

            Type(CWP.ToString(), Page_Objects.currentwalkoutpercentage);
            Enterkey(Page_Objects.currentwalkoutpercentage);
        }


        //Get forcasted annual volume
        public static void getforecastedvalue()
        {
            Console.WriteLine("Forecasted Annual Volume :" + GetText(Page_Objects.Forecastedannualvolume));

        }


        public static void EnterAPP(int APP)
        {

            Type(APP.ToString(), Page_Objects.addmittedpatientspercentage);
            Enterkey(Page_Objects.addmittedpatientspercentage);

        }

        public static void SelectArrivalsData()
        {

            click(Page_Objects.databenchmarkingaverage);
            Thread.Sleep(2000);
            click(Page_Objects.OKbtn);

        }

        public static void SelectESI()
        {
            Thread.Sleep(3000);
            click(Page_Objects.ESI_databenchmarking);
            Thread.Sleep(2000);
            click(Page_Objects.OKbtn);
        }

        public static void EnterLOSAP(int LOSAP)
        {
            Thread.Sleep(1000);
            Type(LOSAP.ToString(), Page_Objects.LOSforaddmittedpatients);
            Enterkey(Page_Objects.LOSforaddmittedpatients);
        }

        public static void EnterLOSDP(int LOSDP)
        {
            Thread.Sleep(1000);
            Type(LOSDP.ToString(), Page_Objects.LOSdischargedpatients);
            Enterkey(Page_Objects.LOSdischargedpatients);
        }

        public static void EnterAADT(int AAD)
        {
            Thread.Sleep(1000);
            Type(AAD.ToString(), Page_Objects.LOSArrivaltoadmitdecisiontime);
            Enterkey(Page_Objects.LOSArrivaltoadmitdecisiontime);

        }

        public static void EnterShiftsmanually(int DS, int CTT, int PFT, int PTT)
        {
            Thread.Sleep(3000);
            click(Page_Objects.Shft_entermanually);
            Thread.Sleep(3000);
            // click(Page_Objects.Shiftpopup);
            click(Page_Objects.Shft_Addbtn);
            Thread.Sleep(3000);
            click(Page_Objects.Shft_Selectallchkbx);
            click(Page_Objects.Shft_currentFromdd);
            click(Page_Objects.shft_selectcurrentfromtime);
            click(Page_Objects.Shft_currentTodd);
            Type(CTT.ToString(), Page_Objects.Shft_currentTodd);
            Thread.Sleep(3000);
            click(Page_Objects.shft_selectcurrenttotime);
            Thread.Sleep(3000);
            click(Page_Objects.Shft_proposedFromdd);
            Type(PFT.ToString(), Page_Objects.Shft_proposedFromdd);
            Thread.Sleep(2000);
            click(Page_Objects.shft_selectproposedfromtime);
            click(Page_Objects.Shft_proposedTodd);
            Type(PTT.ToString(), Page_Objects.Shft_proposedTodd);
            Thread.Sleep(2000);
            click(Page_Objects.shft_selectproposedtotime);
            clear(Page_Objects.Shft_txtduplicateshifts);
            Type(DS.ToString(), Page_Objects.Shft_txtduplicateshifts);
            Thread.Sleep(2000);
            click(Page_Objects.Shft_Addscribeshiftchkbx);
            click(Page_Objects.Shft_Savebtn);
            click(Page_Objects.shft_12houeswarning_Yes);
            Thread.Sleep(2000);
            click(Page_Objects.Shft_popupOKbtn);

        }

        public static void EnterPhycost(int PC)
        {
            Thread.Sleep(1000);
            Type(PC.ToString(), Page_Objects.Avgcostperphyhour);
            Enterkey(Page_Objects.Avgcostperphyhour);

        }

        public static void EnterAPPCost(int AC)
        {
            Thread.Sleep(1000);
            Type(AC.ToString(), Page_Objects.AvgcostperAPPhour);
            Enterkey(Page_Objects.AvgcostperAPPhour);
            JSScroll();

        }

        public static void Selectdefaultscribecost()
        {
            Thread.Sleep(2000);
            click(Page_Objects.scribecost_lnkcontinue);


        }

        public static void ClinicianAvailability()
        {
            Thread.Sleep(2000);
            click(Page_Objects.bothPresent);


        }

        

        public static void EnterTPPPH(double TPP)
        {
            Thread.Sleep(1000);
            Type(TPP.ToString(), Page_Objects.Phy_patientsperhour);
            Enterkey(Page_Objects.Phy_patientsperhour);

        }

        public static void EnterTAPPH(double TAP)
        {
            Thread.Sleep(1000);
            Type(TAP.ToString(), Page_Objects.APP_patientsperhour);
            Enterkey(Page_Objects.APP_patientsperhour);

        }

        public static void Selectdefaultscribecoeff()
        {
            Thread.Sleep(1000);
            click(Page_Objects.Scribecoefficient_lnkcontinue);

        }

        public static void EnterPHYFH(int PFH)
        {
            Thread.Sleep(1000);
            Type(PFH.ToString(), Page_Objects.Phy_firsthour);
            Enterkey(Page_Objects.Phy_firsthour);

        }

        public static void EnterAPPFH(int AFH)
        {
            Thread.Sleep(1000);
            Type(AFH.ToString(), Page_Objects.App_firsthour);
            Enterkey(Page_Objects.App_firsthour);

        }

        public static void FtNOThatsall()
        {
            Thread.Sleep(3000);
            click(Page_Objects.FT_Lnknothatsall);
            Thread.Sleep(3000);
            //click(Page_Objects.OKbtn);

        }

        public static void NOThatsall()
        {
            Thread.Sleep(3000);
            click(Page_Objects.Lnknothatsall);
            Thread.Sleep(3000);
            
        }

        public static void Otherareafields(string FTHours, int FTESI3, int FTLOS, int DS, int CTT, int PFT, int PTT, double FTPHYFH, double FTAPPFH, double FTPHYPPH, double FTAPPPPH)
        {
            click(Page_Objects.LnkFasttrack);
            MouseHoverOnelement(Page_Objects.LnkFasttrack);
            IsElementPresent(Page_Objects.LnkFasttrack, "Hours of Operations are not set for 'Fast Track'. Click on the link to set the Hours of Operations");
            click(Page_Objects.FastTrackOperationalHrs);
            IsElementPresent(Page_Objects.HoursOfOperationForFTWindow, "Hours of Operations for Fast Track");
            click(Page_Objects.FTAllDays_CheckBox);
            click(Page_Objects.FTOpen24Hrs);
            click(Page_Objects.FTOKbutton);
            Thread.Sleep(3000);
            click(Page_Objects.FT_ESI_entermanually);
            clear(Page_Objects.FT_ESI3);
            Type(FTESI3.ToString(), Page_Objects.FT_ESI3);
            click(Page_Objects.ESI_OKbtn);
            Thread.Sleep(3000);
            Type(FTLOS.ToString(), Page_Objects.FT_LOS);
            Enterkey(Page_Objects.FT_LOS);
            Thread.Sleep(3000);
            click(Page_Objects.FT_ShiftManually);
            Thread.Sleep(3000);
            click(Page_Objects.FT_Shift);
            Thread.Sleep(3000);
            // click(Page_Objects.Shiftpopup);
            click(Page_Objects.Shft_Addbtn);
            Thread.Sleep(3000);
            click(Page_Objects.Shft_Selectallchkbx);
            click(Page_Objects.Shft_currentFromdd);
            click(Page_Objects.shft_selectcurrentfromtime);
            click(Page_Objects.Shft_currentTodd);
            Type(CTT.ToString(), Page_Objects.Shft_currentTodd);
            Thread.Sleep(3000);
            click(Page_Objects.shft_selectcurrenttotime);
            Thread.Sleep(3000);
            click(Page_Objects.Shft_proposedFromdd);
            Type(PFT.ToString(), Page_Objects.Shft_proposedFromdd);
            Thread.Sleep(2000);
            click(Page_Objects.shft_selectproposedfromtime);
            click(Page_Objects.Shft_proposedTodd);
            Type(PTT.ToString(), Page_Objects.Shft_proposedTodd);
            Thread.Sleep(2000);
            click(Page_Objects.shft_selectproposedtotime);
            clear(Page_Objects.Shft_txtduplicateshifts);
            Type(DS.ToString(), Page_Objects.Shft_txtduplicateshifts);
            Thread.Sleep(2000);
            click(Page_Objects.Shft_Addscribeshiftchkbx);
            click(Page_Objects.Shft_Savebtn);
            click(Page_Objects.shft_12houeswarning_Yes);
            Thread.Sleep(2000);
            click(Page_Objects.Shft_popupOKbtn);
            Thread.Sleep(3000);
            Find(Page_Objects.bothPresent2);
            click(Page_Objects.bothPresent2);
            Type(FTPHYPPH.ToString(), Page_Objects.FT_PHY_PPH);
            Enterkey(Page_Objects.FT_PHY_PPH);
            Type(FTAPPPPH.ToString(), Page_Objects.FT_APP_PPH);
            Enterkey(Page_Objects.FT_APP_PPH);
            click(Page_Objects.FT_Scribe_Cooff_Cont);
            Type(FTPHYFH.ToString(), Page_Objects.FT_PHY_FirstHour);
            Enterkey(Page_Objects.FT_PHY_FirstHour);
            Type(FTAPPFH.ToString(), Page_Objects.FT_APP_FirstHour);
            Enterkey(Page_Objects.FT_APP_FirstHour);
            
        }



        public static void CWD_Ok()
        {
            Thread.Sleep(3000);
            click(Page_Objects.ClinicalWorkDistribution_popupOKbtn);
            //Required fields OK

                   

        }

        public static void SaveModel()
            {

            
            bool Mandatory = false;
            try
            {
                WaitForElement(Page_Objects.Ok_Req);
                click(Page_Objects.Ok_Req);
                Mandatory = true;
            }
            catch
            {

            }
            WaitForElement(Page_Objects.modelName);
            //click(savepopup);
            DateTime now = DateTime.Now;
            String modelName = "Automation_" + now.ToString("MM/dd/yyyy hh:mm tt");
            Type(modelName.ToString(), Page_Objects.modelName);
            if (!Mandatory)
            {
                click(Page_Objects.EMD_ModeCategory_Operational);
            }
            click(Page_Objects.modelSave);
            try
            {
                WaitForElement(Page_Objects.op_model_verification);
                click(Page_Objects.Yesbtn);
            }
            catch
            {

            }

        }

        public static void Successmsg_Clk_OK()
        {
            Thread.Sleep(25000);
            click(Page_Objects.OKbtn);
        }


        //Import Arrivals data

        public static void Importarrivalsdata()
        {
            click(Page_Objects.importdata);
            WaitForElement(Page_Objects.arrivaldata_dropdown_datepicker);

            click(Page_Objects.arrivaldata_dropdown_datepicker);

            click(Page_Objects.Calendar_yeararrow);
            WaitForElement(Page_Objects.Calendar_dropdown_year);

            click(Page_Objects.Calendar_dropdown_year);
            WaitForElement(Page_Objects.Calendar_dropdown_month);
            click(Page_Objects.Calendar_dropdown_month);
            WaitForElement(Page_Objects.Calendar_dropdown_day);
            click(Page_Objects.Calendar_dropdown_day);
            click(Page_Objects.import_ok);
            Thread.Sleep(3000);
            click(Page_Objects.arrivals_missingdataalert);
            Thread.Sleep(5000);

            click(Page_Objects.Arrivals_OKbtn);
            Thread.Sleep(3000);

        }

        // Enter ESI data manually
        public static void ESIdatamanually(int esi1, int esi2, int esi3, int esi4)
        {
            Thread.Sleep(3000);
            click(Page_Objects.ESI_entermanually);
            clear(Page_Objects.ESI_1);
            Type(esi1.ToString(), Page_Objects.ESI_1);
            clear(Page_Objects.ESI_2);
            Type(esi2.ToString(), Page_Objects.ESI_2);
            clear(Page_Objects.ESI_3);
            Type(esi3.ToString(), Page_Objects.ESI_3);
            clear(Page_Objects.ESI_4);
            Type(esi4.ToString(), Page_Objects.ESI_4);
            
            click(Page_Objects.ESI_OKbtn);


        }
        
       //Import shift data
       public static void importshifts()
        {
            Thread.Sleep(7000);
            
            click(Page_Objects.Shift_import);
            Thread.Sleep(7000);
            //WaitForElement(Page_Objects.Shiftpopup);
            //click(Page_Objects.Shiftpopup);

            click(Page_Objects.ShiftImportAPPCheckbox);
            click(Page_Objects.ShiftImportPhyCheckbox);
            click(Page_Objects.ShiftImportScribeCheckbox);
            JSExe(Page_Objects.shiftDatePickerBtn);
            Thread.Sleep(2000);
            click(Page_Objects.Calendar_yeararrow);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_year);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_month);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_day);
            Thread.Sleep(2000);
            click(Page_Objects.ShiftRetrieve);
            Thread.Sleep(5000);
            JSExe(Page_Objects.OKbtn);
            Thread.Sleep(3000);
            click(Page_Objects.Shift_OKbtn);


        }



    }

}
