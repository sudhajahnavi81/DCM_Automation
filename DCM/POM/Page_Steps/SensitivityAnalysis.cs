using DCM.POM.DCM_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DCM.POM.Page_Steps
{
    public class SensitivityAnalysis : MethodsAndActions
    {
        public static void SA_SensitivityAnalysis()
        {
            WaitForElement(Page_Objects.Appname);
            click(Page_Objects.Appname);
            Thread.Sleep(15000);
            JSExe(Page_Objects.Editinput);
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.SensitivityAnalysisTab);
            click(Page_Objects.SensitivityAnalysisTab);
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.SA_Forecasted_Annual);
            
        }

        public static void SA_Forecasted_AnnualVolume(int Forecasted_Annual_Volume, int Percentage_Variation)
        {
            clear(Page_Objects.SA_Forecasted_Annual);
            Type(Forecasted_Annual_Volume.ToString(), Page_Objects.SA_Forecasted_Annual);
            clear(Page_Objects.SA_Percentage_Variation);
            Type(Percentage_Variation.ToString(), Page_Objects.SA_Percentage_Variation);
        }

        public static void SA_Actual_MonthlyArrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            bool ElementJAN = false;
            try
            {
                Find(Page_Objects.JAN);
                ElementJAN = false;
            }
            catch
            {
                ElementJAN = true;
            }
            if (ElementJAN)
            {
                click(Page_Objects.Expand_ActualMonthlyArrival);
            }
            
            clear(Page_Objects.JAN);
            Type(JAN.ToString(), Page_Objects.JAN);
            clear(Page_Objects.FEB);
            Type(FEB.ToString(), Page_Objects.FEB);
            clear(Page_Objects.MAR);
            Type(MAR.ToString(), Page_Objects.MAR);
            clear(Page_Objects.APR);
            Type(APR.ToString(), Page_Objects.APR);
            clear(Page_Objects.MAY);
            Type(MAY.ToString(), Page_Objects.MAY);
            clear(Page_Objects.JUN);
            Type(JUN.ToString(), Page_Objects.JUN);
            clear(Page_Objects.JUL);
            Type(JUL.ToString(), Page_Objects.JUL);
            clear(Page_Objects.AUG);
            Type(AUG.ToString(), Page_Objects.AUG);
            clear(Page_Objects.SEP);
            Type(SEP.ToString(), Page_Objects.SEP);
            clear(Page_Objects.OCT);
            Type(OCT.ToString(), Page_Objects.OCT);
            clear(Page_Objects.NOV);
            Type(NOV.ToString(), Page_Objects.NOV);
            clear(Page_Objects.DEC);
            Type(DEC.ToString(), Page_Objects.DEC);
        }

        public static void clearField()
        {
            click(Page_Objects.SA_clear);
        }

        public static void SA_Refresh()
        {
            JSScrollup();
            click(Page_Objects.SA_Refresh);
            Thread.Sleep(10000);
        }
        public static void ZoomGraph()
        {
            click(Page_Objects.GraphCheckbox);
            Thread.Sleep(3000);
            click(Page_Objects.ZoomGraph);
            Thread.Sleep(4000);
            click(Page_Objects.OKbtn);
        }
    }
}
