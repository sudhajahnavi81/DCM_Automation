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
            JSExe(Page_Objects.Editinput_Edu);
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.SensitivityAnalysisTab);
            click(Page_Objects.SensitivityAnalysisTab);
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.SA_Forecasted_Annual);
            
        }

        public static void SAWorkload_Forecasted_AnnualVolume(int Forecasted_Annual_Volume, int Percentage_Variation)
        {
            Thread.Sleep(40000);
            click(Page_Objects.SAWorkload_Forecasted_Annual);
            clear(Page_Objects.SAWorkload_Forecasted_Annual);
            Type(Forecasted_Annual_Volume.ToString(), Page_Objects.SAWorkload_Forecasted_Annual);
            clear(Page_Objects.SAworkload_Percentage_Variation);
            Type(Percentage_Variation.ToString(), Page_Objects.SAworkload_Percentage_Variation);
        }

        public static void SAArrivalWorkload_Forecasted_AnnualVolume(int Forecasted_Annual_Volume, int Percentage_Variation)
        {
            Thread.Sleep(40000);
            click(Page_Objects.SAArrivalWorkload_Forecasted_Annual);
            clear(Page_Objects.SAArrivalWorkload_Forecasted_Annual);
            Type(Forecasted_Annual_Volume.ToString(), Page_Objects.SAArrivalWorkload_Forecasted_Annual);
            clear(Page_Objects.SAArrivalworkload_Percentage_Variation);
            Type(Percentage_Variation.ToString(), Page_Objects.SAArrivalworkload_Percentage_Variation);
        }

        public static void SACostSummary_Forecasted_AnnualVolume(int Forecasted_Annual_Volume, int Percentage_Variation)
        {
            Thread.Sleep(30000);
            click(Page_Objects.SACostSummary_Forecasted_Annual);
            clear(Page_Objects.SACostSummary_Forecasted_Annual);
            Type(Forecasted_Annual_Volume.ToString(), Page_Objects.SACostSummary_Forecasted_Annual);
            clear(Page_Objects.SACostSummary_Percentage_Variation);
            Type(Percentage_Variation.ToString(), Page_Objects.SACostSummary_Percentage_Variation);
            
        }

        public static void SA_Forecasted_AnnualVolume(int Forecasted_Annual_Volume, int Percentage_Variation)
        {
            Thread.Sleep(40000);
            clear(Page_Objects.SA_Forecasted_Annual);
            Type(Forecasted_Annual_Volume.ToString(), Page_Objects.SA_Forecasted_Annual);
            clear(Page_Objects.SA_Percentage_Variation);
            Type(Percentage_Variation.ToString(), Page_Objects.SA_Percentage_Variation);
        }



        public static void SA_Actual_MonthlyArrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            Thread.Sleep(12000);
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
            Thread.Sleep(2000);
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


        public static void SAWorkload_Actual_MonthlyArrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            Thread.Sleep(12000);
            bool ElementJAN = false;
            try
            {
                Find(Page_Objects.SAworkload_JAN);
                ElementJAN = false;
            }
            catch
            {
                ElementJAN = true;
            }
            if (ElementJAN)
            {
                    click(Page_Objects.SAExpand_ActualMonthlyArrival);
            }
            
            Thread.Sleep(2000);
            clear(Page_Objects.SAworkload_JAN);
            Type(JAN.ToString(), Page_Objects.SAworkload_JAN);
            clear(Page_Objects.SAworkload_FEB);
            Type(FEB.ToString(), Page_Objects.SAworkload_FEB);
            clear(Page_Objects.SAworkload_MAR);
            Type(MAR.ToString(), Page_Objects.SAworkload_MAR);
            clear(Page_Objects.SAworkload_APR);
            Type(APR.ToString(), Page_Objects.SAworkload_APR);
            clear(Page_Objects.SAworkload_MAY);
            Type(MAY.ToString(), Page_Objects.SAworkload_MAY);
            clear(Page_Objects.SAworkload_JUN);
            Type(JUN.ToString(), Page_Objects.SAworkload_JUN);
            clear(Page_Objects.SAworkload_JUL);
            Type(JUL.ToString(), Page_Objects.SAworkload_JUL);
            clear(Page_Objects.SAworkload_AUG);
            Type(AUG.ToString(), Page_Objects.SAworkload_AUG);
            clear(Page_Objects.SAworkload_SEP);
            Type(SEP.ToString(), Page_Objects.SAworkload_SEP);
            clear(Page_Objects.SAworkload_OCT);
            Type(OCT.ToString(), Page_Objects.SAworkload_OCT);
            clear(Page_Objects.SAworkload_NOV);
            Type(NOV.ToString(), Page_Objects.SAworkload_NOV);
            clear(Page_Objects.SAworkload_DEC);
            Type(DEC.ToString(), Page_Objects.SAworkload_DEC);
        }

        public static void SAArrival_Workload_Actual_MonthlyArrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            Thread.Sleep(12000);
            bool ElementJAN = false;
            try
            {
                Find(Page_Objects.SA_Arrivalworkload_JAN);
                ElementJAN = false;
            }
            catch
            {
                ElementJAN = true;
            }
            if (ElementJAN)
            {

                click(Page_Objects.SAArrival_ActualMonthlyArrival);

            }

            Thread.Sleep(2000);
            clear(Page_Objects.SA_Arrivalworkload_JAN);
            Type(JAN.ToString(), Page_Objects.SA_Arrivalworkload_JAN);
            clear(Page_Objects.SA_Arrivalworkload_FEB);
            Type(FEB.ToString(), Page_Objects.SA_Arrivalworkload_FEB);
            clear(Page_Objects.SA_Arrivalworkload_MAR);
            Type(MAR.ToString(), Page_Objects.SA_Arrivalworkload_MAR);
            clear(Page_Objects.SA_Arrivalworkload_APR);
            Type(APR.ToString(), Page_Objects.SA_Arrivalworkload_APR);
            clear(Page_Objects.SA_Arrivalworkload_MAY);
            Type(MAY.ToString(), Page_Objects.SA_Arrivalworkload_MAY);
            clear(Page_Objects.SA_Arrivalworkload_JUN);
            Type(JUN.ToString(), Page_Objects.SA_Arrivalworkload_JUN);
            clear(Page_Objects.SA_Arrivalworkload_JUL);
            Type(JUL.ToString(), Page_Objects.SA_Arrivalworkload_JUL);
            clear(Page_Objects.SA_Arrivalworkload_AUG);
            Type(AUG.ToString(), Page_Objects.SA_Arrivalworkload_AUG);
            clear(Page_Objects.SA_Arrivalworkload_SEP);
            Type(SEP.ToString(), Page_Objects.SA_Arrivalworkload_SEP);
            clear(Page_Objects.SA_Arrivalworkload_OCT);
            Type(OCT.ToString(), Page_Objects.SA_Arrivalworkload_OCT);
            clear(Page_Objects.SA_Arrivalworkload_NOV);
            Type(NOV.ToString(), Page_Objects.SA_Arrivalworkload_NOV);
            clear(Page_Objects.SA_Arrivalworkload_DEC);
            Type(DEC.ToString(), Page_Objects.SA_Arrivalworkload_DEC);
        }

        public static void SACostSummary_Workload_Actual_MonthlyArrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            Thread.Sleep(12000);
            bool ElementJAN = false;
            try
            {
                Find(Page_Objects.CostSummary_JAN);
                ElementJAN = false;
            }
            catch
            {
                ElementJAN = true;
            }
            if (ElementJAN)
            {
                
                    click(Page_Objects.SACostSummary_ActualMonthlyArrival);
                
            }

            Thread.Sleep(2000);
            clear(Page_Objects.CostSummary_JAN);
            Type(JAN.ToString(), Page_Objects.CostSummary_JAN);
            clear(Page_Objects.CostSummary_FEB);
            Type(FEB.ToString(), Page_Objects.CostSummary_FEB);
            clear(Page_Objects.CostSummary_MAR);
            Type(MAR.ToString(), Page_Objects.CostSummary_MAR);
            clear(Page_Objects.CostSummary_APR);
            Type(APR.ToString(), Page_Objects.CostSummary_APR);
            clear(Page_Objects.CostSummary_MAY);
            Type(MAY.ToString(), Page_Objects.CostSummary_MAY);
            clear(Page_Objects.CostSummary_JUN);
            Type(JUN.ToString(), Page_Objects.CostSummary_JUN);
            clear(Page_Objects.CostSummary_JUL);
            Type(JUL.ToString(), Page_Objects.CostSummary_JUL);
            clear(Page_Objects.CostSummary_AUG);
            Type(AUG.ToString(), Page_Objects.CostSummary_AUG);
            clear(Page_Objects.CostSummary_SEP);
            Type(SEP.ToString(), Page_Objects.CostSummary_SEP);
            clear(Page_Objects.CostSummary_OCT);
            Type(OCT.ToString(), Page_Objects.CostSummary_OCT);
            clear(Page_Objects.CostSummary_NOV);
            Type(NOV.ToString(), Page_Objects.CostSummary_NOV);
            clear(Page_Objects.CostSummary_DEC);
            Type(DEC.ToString(), Page_Objects.CostSummary_DEC);
        }







        public static void clearField()
        {
            click(Page_Objects.SA_clear);
        }

        //public static void Workload_clearField()
        //{
        //    click(Page_Objects.SAWorkload_clear);
        //}
        

        public static void ActualweeklyArrivalClearButton()
        {
            click(Page_Objects.SAforecatedweekly_clear_ActualHourly);
        }

        public static void Workload_ActualweeklyArrivalClearButton()
        {
            click(Page_Objects.SAWorkloadforecatedweekly_clear_ActualHourly);
        }

        public static void Workload_Arrival_ActualweeklyArrivalClearButton()
        {
            click(Page_Objects.SAWorkloadArrival_weekly_clear_ActualHourly);
        }
        
        public static void ActualHourlyArrivalClearButton()
        {
            click(Page_Objects.SAforecatedHourly_clear_ActualHourly);
        }

        public static void ActualMonthlyArrivalClearButton()
        {
            click(Page_Objects.SAforecatedweekly_clear_ActualMonthly);
        }

        public static void ForcastedHourlyArrivalClearButton()
        {
            click(Page_Objects.SAforecatedHourly_clear_ActualMonthly);
        }

        public static void WorkloadarrivalClear()
        {
            click(Page_Objects.SAWorkloadforecatedHourly_clear_ActualMonthly);
        }

        public static void SAWorkload_clear_ActualMonthly()
        {
            click(Page_Objects.SAWorkload_clear_ActualMonthly);
        }

        public static void SACostSummary_clear_ActualMonthly()
        {
            click(Page_Objects.SACostsummary_clear_ActualHourly);
        }
        public static void SACostSummary_clear_Byweek()
        {
            click(Page_Objects.SACostsummary_clear_ByWeek);
        }



        public static void SA_Refresh()
        {
            JSScrollup();
            click(Page_Objects.SA_Refresh);
            Thread.Sleep(40000);
            WaitForElement(Page_Objects.SA_Refresh);
           
        }

        public static void Workload_Refresh()
        {
            JSScrollup();
            click(Page_Objects.Workload_Refresh);
            Thread.Sleep(40000);
            WaitForElement(Page_Objects.Workload_Refresh);

        }

        public static void Workload_Arrival_Refresh()
        {
            JSScrollup();
            click(Page_Objects.Workload_Arrival_Refresh);
            Thread.Sleep(40000);
            WaitForElement(Page_Objects.Workload_Arrival_Refresh);

        }

        public static void CostSummary_Refresh()
        {
            JSScrollup();
            click(Page_Objects.CostSummary_Refresh);
            Thread.Sleep(40000);
            WaitForElement(Page_Objects.CostSummary_Refresh);

        }

        public static void ZoomGraph_ActualWeeklyArrival()
        {
            Thread.Sleep(40000);
            click(Page_Objects.GraphCheckbox);
            Thread.Sleep(35000);
            click(Page_Objects.Zoomgraph_ActualweeklyArrival);
            Thread.Sleep(36000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(5000);
        }

        public static void Workload_ZoomGraph()
        {
            Thread.Sleep(40000);
            WaitForElement(Page_Objects.workload_GraphCheckbox);
            click(Page_Objects.workload_GraphCheckbox);
            Thread.Sleep(35000);
            click(Page_Objects.Zoomgraph_Workload);
            Thread.Sleep(20000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(5000);
        }

        public static void Workload_Arrival_ZoomGraph()
        {
            Thread.Sleep(40000);
            WaitForElement(Page_Objects.workload_GraphCheckbox);
            click(Page_Objects.workload_GraphCheckbox);
            Thread.Sleep(35000);
            click(Page_Objects.Zoomgraph_Arrival_Workload);
            Thread.Sleep(20000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(5000);
        }


        public static void ZoomGraph()
        {
            Thread.Sleep(40000);
            click(Page_Objects.GraphCheckbox);
            Thread.Sleep(30000);
            click(Page_Objects.ZoomGraph);
            Thread.Sleep(30000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(5000);
        }


        public static void actualMonthlyArrivalTab()
        {
            JSScrollup();
            Thread.Sleep(10000);
            click(Page_Objects.SA_actualmonthlyArrivalTab);
            WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
        }

        public static void ForecastedWeeklyArrivalsTab()
        {
            Thread.Sleep(6000);
            click(Page_Objects.SA_ForecastedWeeklyArrivalsTab);
            WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
        }



        public static void ActualWeeklyArrivalsTab()
        {
            Thread.Sleep(6000);
            click(Page_Objects.SA_ActualWeeklyArrivalsTab);
            //WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
        }


        public static void ActualHourlyArrivalsTab()
        {
            Thread.Sleep(6000);
            click(Page_Objects.SA_ActualHourlyArrivalsTab);
            //WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
        }

        public static void forcastedHourlyArrivalsTab()
        {
            Thread.Sleep(6000);
            click(Page_Objects.SA_ForcastedHourlyArrivalsTab);
            //WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
        }
        public static void ProviderStaffing_CalculatedWorkLoadTab()
        {
            Thread.Sleep(20000);
            click(Page_Objects.Provider_Staffing_Calculated_WorkLoadTab);
            //WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
            Thread.Sleep(6000);
        }

        public static void ProviderStaffing_ArrivalWorkLoadTab()
        {
            Thread.Sleep(10000);
            click(Page_Objects.Provider_Staffing_Arrival_WorkLoadTab);
            //WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
            Thread.Sleep(6000);
        }

        public static void ProviderStaffing_CostSummary()
        {
            Thread.Sleep(10000);
            click(Page_Objects.Provider_CostSummaryTab);
            //WaitForElement(Page_Objects.Expand_ActualMonthlyArrival);
            Thread.Sleep(6000);
        }


        public static void waitpage()
        {
            Thread.Sleep(10000);
            
        }
        
        public static void expandActualWeekArrivals()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.sunday_0);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_ActualWeeklyArrival);
            }
        }


        public static void expand_Workload_ActualWeekArrivals()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.sunday_0);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.SAExpand_ActualWeeklyArrival);
            }
        }

        public static void expandArrival_Workload_ActualWeekArrivals()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.sunday_0);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.SAExpand_Arrival_ActualWeeklyArrival);
            }
        }

        public static void expandCostSummary_ActualWeekArrivals()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.sunday_0);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.SACostSummary_ArrivalByWeek);
            }
        }







        public static void expandLengthofStay()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.Admit_LOS);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_LengthOfStay);
            }
        }

        public static void expandShifts()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.importshiftbtn);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_Shifts);
            }
        }

        public static void Expand_CostSummary_Shifts()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.importshiftbtn);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_CostSummary_Shifts);
            }
        }
        public static void Expand_ArrivalWorkload_Shifts()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.importshiftbtn);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.ExpandSAArrival_Shifts);
            }
        }


        public static void ExpandProductivityTarget()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.SAMain_TargetPhyPPH);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_ProductivityTarget);
                Thread.Sleep(3000);
            }
        }

        public static void ExpandProductivityVariation()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.SAMain_FirstHr_Phy);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_ProductivityVariation);
                Thread.Sleep(3000);
            }
        }

        public static void Expand_Arrival_ProductivityTarget()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.SAMain_Arrival_TargetPhyPPH);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_Arrival_ProductivityTarget);
                Thread.Sleep(3000);
            }
        }

        public static void Expand_Arrival_ProductivityVariation()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.SAMain_Arrival_FirstHr_Phy);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.Expand_Arrival_ProductivityVariation);
                Thread.Sleep(3000);
            }
        }

        public static void ProductivityTarget(Double main_phy_pph, Double main_app_pph, Double FT_Phy_pph, Double FT_App_PPH, Double PIT_Phy_pph, Double PIT_App_PPH)
        {
            Thread.Sleep(3000);
            clear(Page_Objects.SAMain_TargetPhyPPH);
            Type(main_phy_pph.ToString(), Page_Objects.SAMain_TargetPhyPPH);
           // clear(Page_Objects.SAMain_TargetAPPPPH);
            //Type(main_app_pph.ToString(), Page_Objects.SAMain_TargetAPPPPH);
            click(Page_Objects.SAFT_TargetTab);
            Thread.Sleep(2000);
            clear(Page_Objects.SAFT_TargetPhyPPH);
            Type(FT_Phy_pph.ToString(), Page_Objects.SAFT_TargetPhyPPH);
            //clear(Page_Objects.SAFT_TargetAPPPPH);
            //Type(FT_App_PPH.ToString(), Page_Objects.SAFT_TargetAPPPPH);
            click(Page_Objects.SAPIT_TargetTab);
            Thread.Sleep(2000);
            clear(Page_Objects.SAPIT_TargetPhyPPH);
            Type(PIT_Phy_pph.ToString(), Page_Objects.SAPIT_TargetPhyPPH);
            //clear(Page_Objects.SAPIT_TargetAPPPPH);
            //Type(PIT_App_PPH.ToString(), Page_Objects.SAPIT_TargetAPPPPH);

        }

        public static void ProductivityVariation(Double SAMain_FirstHr_Phy, Double SAMain_FirstHr_APP, Double SAFT_FirstHr_Phy, Double SAFT_FirstHr_APP, Double SAPIT_FirstHr_Phy, Double SAPIT_FirstHr_APP)
        {
            Thread.Sleep(3000);
            clear(Page_Objects.SAMain_FirstHr_Phy);
            Type(SAMain_FirstHr_Phy.ToString(), Page_Objects.SAMain_FirstHr_Phy);
            //clear(Page_Objects.SAMain_FirstHr_APP);
            //Type(SAMain_FirstHr_APP.ToString(), Page_Objects.SAMain_FirstHr_APP);
            click(Page_Objects.SAFT_VariationTab);
            Thread.Sleep(2000);
            clear(Page_Objects.SAFT_FirstHr_Phy);
            Type(SAFT_FirstHr_Phy.ToString(), Page_Objects.SAFT_FirstHr_Phy);
            //clear(Page_Objects.SAFT_FirstHr_APP);
            //Type(SAFT_FirstHr_APP.ToString(), Page_Objects.SAFT_FirstHr_APP);
            click(Page_Objects.SAPIT_VariationTab);
            Thread.Sleep(2000);
            clear(Page_Objects.SAPIT_FirstHr_Phy);
            Type(SAPIT_FirstHr_Phy.ToString(), Page_Objects.SAPIT_FirstHr_Phy);
            //clear(Page_Objects.SAPIT_FirstHr_APP);
            //Type(SAPIT_FirstHr_APP.ToString(), Page_Objects.SAPIT_FirstHr_APP);

        }

        public static void Arrival_ProductivityTarget(Double main_phy_pph, Double main_app_pph, Double FT_Phy_pph, Double FT_App_PPH, Double PIT_Phy_pph, Double PIT_App_PPH)
        {
            Thread.Sleep(3000);
            clear(Page_Objects.SAMain_Arrival_TargetPhyPPH);
            Type(main_phy_pph.ToString(), Page_Objects.SAMain_Arrival_TargetPhyPPH);
            //clear(Page_Objects.SAMain_Arrival_TargetAPPPPH);
            //Type(main_app_pph.ToString(), Page_Objects.SAMain_Arrival_TargetAPPPPH);
            click(Page_Objects.SAFT_Arrival_TargetTab);
            Thread.Sleep(2000);
            clear(Page_Objects.SAFT_TargetPhyPPH);
            Type(FT_Phy_pph.ToString(), Page_Objects.SAFT_TargetPhyPPH);
            //clear(Page_Objects.SAFT_TargetAPPPPH);
            //Type(FT_App_PPH.ToString(), Page_Objects.SAFT_TargetAPPPPH);
            click(Page_Objects.SAPIT_Arrival_TargetTab);
            Thread.Sleep(5000);
            clear(Page_Objects.ArrivalPIT_TargetPhyPPH);
            Type(PIT_Phy_pph.ToString(), Page_Objects.ArrivalPIT_TargetPhyPPH);
            //clear(Page_Objects.ArrivalPIT_TargetAPPPPH);
            //Type(PIT_App_PPH.ToString(), Page_Objects.ArrivalPIT_TargetAPPPPH);

        }

        public static void Arrival_ProductivityVariation(Double SAMain_FirstHr_Phy, Double SAMain_FirstHr_APP, Double SAFT_FirstHr_Phy, Double SAFT_FirstHr_APP, Double SAPIT_FirstHr_Phy, Double SAPIT_FirstHr_APP)
        {
            Thread.Sleep(3000);
            clear(Page_Objects.SAMain_Arrival_FirstHr_Phy);
            Type(SAMain_FirstHr_Phy.ToString(), Page_Objects.SAMain_Arrival_FirstHr_Phy);
            //clear(Page_Objects.SAMain_Arrival_FirstHr_APP);
            //Type(SAMain_FirstHr_APP.ToString(), Page_Objects.SAMain_Arrival_FirstHr_APP);
            click(Page_Objects.SAFT_Arrival_VariationTab);
            Thread.Sleep(2000);
            clear(Page_Objects.SAFT_FirstHr_Phy);
            Type(SAFT_FirstHr_Phy.ToString(), Page_Objects.SAFT_FirstHr_Phy);
            //clear(Page_Objects.SAFT_FirstHr_APP);
            //Type(SAFT_FirstHr_APP.ToString(), Page_Objects.SAFT_FirstHr_APP);
            click(Page_Objects.SAPIT_Arrival_VariationTab);
            Thread.Sleep(2000);
            clear(Page_Objects.ArrivalPIT_FirstHr_Phy);
            Type(SAPIT_FirstHr_Phy.ToString(), Page_Objects.ArrivalPIT_FirstHr_Phy);
            //clear(Page_Objects.ArrivalPIT_FirstHr_APP);
            //Type(SAPIT_FirstHr_APP.ToString(), Page_Objects.ArrivalPIT_FirstHr_APP);

        }

        public static void workload_Shifts_Import()
        {
            WaitForElement(Page_Objects.importshiftbtn);

            click(Page_Objects.importshiftbtn);
            Thread.Sleep(10000);
            //WaitForElement(Page_Objects.Shiftpopup);
            //click(Page_Objects.Shiftpopup);
            try
            {
                click(Page_Objects.OKbtn);
            }
            catch
            {

            }
            Thread.Sleep(5000);
            click(Page_Objects.ShiftImportAPPCheckbox);
            click(Page_Objects.ShiftImportPhyCheckbox);
            click(Page_Objects.Workload_ShiftImportScribeCheckbox);
            JSExe(Page_Objects.shiftDatePickerBtn);
            Thread.Sleep(2000);
            click(Page_Objects.Calendar_yeararrow);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_year);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_month);
            Thread.Sleep(1000);
            click(Page_Objects.Workload_Calendar_dropdown_day);
            Thread.Sleep(5000);
            click(Page_Objects.ShiftRetrieve);
            Thread.Sleep(5000);
            JSExe(Page_Objects.OKbtn);



        }

        public static void costSummary_Shifts_Import()
        {
            WaitForElement(Page_Objects.importshiftbtn);

            click(Page_Objects.importshiftbtn);
            Thread.Sleep(10000);
            //WaitForElement(Page_Objects.Shiftpopup);
            //click(Page_Objects.Shiftpopup);
            try
            {
                click(Page_Objects.OKbtn);
            }
            catch
            {

            }
            Thread.Sleep(5000);
            click(Page_Objects.ShiftImportAPPCheckbox);
            click(Page_Objects.ShiftImportPhyCheckbox);
            click(Page_Objects.Workload_ShiftImportScribeCheckbox);
            JSExe(Page_Objects.shiftDatePickerBtn);
            Thread.Sleep(2000);
            click(Page_Objects.Calendar_yeararrow);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_year);
            Thread.Sleep(1000);
            click(Page_Objects.Calendar_dropdown_month);
            Thread.Sleep(1000);
            click(Page_Objects.Costsummary_Calendar_dropdown_day);
            Thread.Sleep(5000);
            click(Page_Objects.ShiftRetrieve);
            Thread.Sleep(5000);
            JSExe(Page_Objects.OKbtn);



        }



        

        public static void Workload_LengthDfStay(int OAL, int OAAD, int MDL, int FDL, int PDL)
        {
            WaitForElement(Page_Objects.Admit_LOS);
            clear(Page_Objects.Admit_LOS);
            Type(OAL.ToString(), Page_Objects.Admit_LOS);
            clear(Page_Objects.Admit_Decision);
            Type(OAAD.ToString(), Page_Objects.Admit_Decision);
            clear(Page_Objects.Discharge_Los);
            Type(MDL.ToString(), Page_Objects.Discharge_Los);
            clear(Page_Objects.FTWorkload_Discharge_Los);
            Type(FDL.ToString(), Page_Objects.FTWorkload_Discharge_Los);
            clear(Page_Objects.PITWorkload_Discharge_Los);
            Type(PDL.ToString(), Page_Objects.PITWorkload_Discharge_Los);


        }

        public static void Expand_CostData()
        {
            Thread.Sleep(10000);
            bool ElementSunday = false;
            try
            {
                Find(Page_Objects.Cost_PhyHour);
                ElementSunday = false;
            }
            catch
            {
                ElementSunday = true;
            }
            if (ElementSunday)
            {
                click(Page_Objects.CostData_Expand);
            }
        }

        public static void CostData(int Cost_Phyhour, int Cost_APPhour, int Cost_Scrbhour)
        {
            Thread.Sleep(5000);
            clear(Page_Objects.Cost_PhyHour);
            Type(Cost_Phyhour.ToString(), Page_Objects.Cost_PhyHour);
            clear(Page_Objects.Cost_APPHour);
            Type(Cost_APPhour.ToString(), Page_Objects.Cost_APPHour);
            clear(Page_Objects.Cost_scrbHour);
            Type(Cost_Scrbhour.ToString(), Page_Objects.Cost_scrbHour);
        }
        public static void Sensitivity_Save()
        {
            Thread.Sleep(10000);
            click(Page_Objects.Sensitivity_Save);
            try
            {
                click(Page_Objects.OKbtn);
            }
            catch
            {

            }
            Thread.Sleep(10000);
        }



    }
}
