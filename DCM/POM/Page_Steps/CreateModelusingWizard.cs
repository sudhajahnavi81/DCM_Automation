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

        public static void EnterFAA(string FAA)
        {
            Type(FAA.ToString(), Page_Objects.ForecastedAnnualArrivals);

            Enterkey(Page_Objects.ForecastedAnnualArrivals);

        }

        public static void EnterCWP(string CWP)
        {

            Type(CWP.ToString(), Page_Objects.currentwalkoutpercentage);
            Enterkey(Page_Objects.currentwalkoutpercentage);
        }

        public static void EnterAPP(string APP)
        {

            Type(APP.ToString(), Page_Objects.addmittedpatientspercentage);
            Enterkey(Page_Objects.addmittedpatientspercentage);

        }

        public static void SelectArrivalsData()
        {

            click(Page_Objects.databenchmarkingaverage);
            click(Page_Objects.OKbtn);

        }

        public static void SelectESI()
        {
            Thread.Sleep(3000);
            click(Page_Objects.ESI_databenchmarking);
            click(Page_Objects.OKbtn);
        }

        public static void EnterLOSAP(string LOSAP)
        {
            Thread.Sleep(1000);
            Type(LOSAP.ToString(), Page_Objects.LOSforaddmittedpatients);
            Enterkey(Page_Objects.LOSforaddmittedpatients);
        }

        public static void EnterLOSDP(string LOSDP)
        {
            Thread.Sleep(1000);
            Type(LOSDP.ToString(), Page_Objects.LOSdischargedpatients);
            Enterkey(Page_Objects.LOSdischargedpatients);
        }

        public static void EnterAADT(string AAD)
        {
            Thread.Sleep(1000);
            Type(AAD.ToString(), Page_Objects.LOSArrivaltoadmitdecisiontime);
            Enterkey(Page_Objects.LOSArrivaltoadmitdecisiontime);

        }

        public static void EnterShiftsmanually(string DS, string CTT, string PFT, string PTT)
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

        public static void EnterPhycost(string PC)
        {
            Thread.Sleep(1000);
            Type(PC.ToString(), Page_Objects.Avgcostperphyhour);
            Enterkey(Page_Objects.Avgcostperphyhour);

        }

        public static void EnterAPPCost(string AC)
        {
            Thread.Sleep(1000);
            Type(AC.ToString(), Page_Objects.AvgcostperAPPhour);
            Enterkey(Page_Objects.AvgcostperAPPhour);

        }

        public static void Selectdefaultscribecost()
        {

            click(Page_Objects.scribecost_lnkcontinue);


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

        public static void EnterPHYFH(string PFH)
        {
            Thread.Sleep(1000);
            Type(PFH.ToString(), Page_Objects.Phy_firsthour);
            Enterkey(Page_Objects.Phy_firsthour);

        }

        public static void EnterAPPFH(string AFH)
        {
            Thread.Sleep(1000);
            Type(AFH.ToString(), Page_Objects.App_firsthour);
            Enterkey(Page_Objects.App_firsthour);

        }

        public static void NOThatsall()
        {

            click(Page_Objects.Lnknothatsall);

        }

        public static void CWD_Ok()
        {

            click(Page_Objects.ClinicalWorkDistribution_popupOKbtn);

        }

        public static void SaveModel()
            {

            Thread.Sleep(3000);
            DateTime now = DateTime.Now;
            String modelName = "Automation_" + now.ToString("MM/dd/yyyy hh:mm tt");
            Type(modelName.ToString(), Page_Objects.modelName);
            click(Page_Objects.modelSave);

        }

        public static void Successmsg_Clk_OK()
        {
            //Thread.Sleep(6000);
            click(Page_Objects.OKbtn);
        }

    }

}
