using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using DCM.POM;
using System.Threading;
using NUnit.Framework;


namespace DCM.POM.Page_Steps
{
    class ViewAnalysis : MethodsAndActions
    {

        public static double AE_Forcasted_monthly_Ariival = 0;
        public static double AE_ActualMonthlyArrival = 0;
        public static double Forcasted_Arrival_sun = 0;
        

        public static void editmodel()
        {
            Thread.Sleep(10000);
            click(Page_Objects.Appname);
            Thread.Sleep(10000);
            click(Page_Objects.dashboard);
            Thread.Sleep(5000);
            click(Page_Objects.EditInput);
            Thread.Sleep(10000);
            click(Page_Objects.PM_next);
            Thread.Sleep(10000);
            
        }


        public static void PMAEvalues()
        {
            //Average of Monthly Historical Arrivals = Forecasted Annual Volume/12

            int  FAA = Int32.Parse(GetText(Page_Objects.AE_Forcasted_Annual_Volume));
            double MonthlyArrivals = Convert.ToDouble(FAA) / Convert.ToDouble(12);

            //Average Monthly Volume  = Actual Annual Volume/12

            int AE_AAV = Int32.Parse(GetText(Page_Objects.AE_Actual_Annual_Volume));

            double AveMonthlyVolume = Convert.ToDouble(AE_AAV) / 12;

            //Cal pattern for Jan 

            var Monthly_Arrivals_ptrn = Int32.Parse(FieldText(Page_Objects.january))/ AveMonthlyVolume;

            // calculation of Actual Monthly Arrival Data

             AE_ActualMonthlyArrival = Convert.ToDouble(FieldText(Page_Objects.january)) / 31;

            // Forcasted monthly arrival = month arrival* monthly arrival pattern

            var Forcasted_monthly_Ariival = MonthlyArrivals * Monthly_Arrivals_ptrn;

            //Forecasted Monthly Arrival Data = Forcasted monthly arrival/ number of days in month

            AE_Forcasted_monthly_Ariival = Convert.ToDouble(Forcasted_monthly_Ariival) / 31;

            
            Console.WriteLine("Forcasted monthly Ariival for Jan : " + AE_Forcasted_monthly_Ariival);

            Console.WriteLine("Forcasted monthly Ariival for Jan : " + AE_ActualMonthlyArrival);

            // calculation of calculation of sunday arrival by esi


            double ArrivalbyESI_sun = FieldTextToDouble(Page_Objects.sunday_0) +
            FieldTextToDouble(Page_Objects.sunday_1) + FieldTextToDouble(Page_Objects.sunday_2) + FieldTextToDouble(Page_Objects.sunday_3) +
            FieldTextToDouble(Page_Objects.sunday_4) + FieldTextToDouble(Page_Objects.sunday_5) + FieldTextToDouble(Page_Objects.sunday_6) +
            FieldTextToDouble(Page_Objects.sunday_7) + FieldTextToDouble(Page_Objects.sunday_8) + FieldTextToDouble(Page_Objects.sunday_9) +
            FieldTextToDouble(Page_Objects.sunday_10) + FieldTextToDouble(Page_Objects.sunday_11) + FieldTextToDouble(Page_Objects.sunday_12) +
            FieldTextToDouble(Page_Objects.sunday_13) + FieldTextToDouble(Page_Objects.sunday_14) + FieldTextToDouble(Page_Objects.sunday_15) +
            FieldTextToDouble(Page_Objects.sunday_16) + FieldTextToDouble(Page_Objects.sunday_17) + FieldTextToDouble(Page_Objects.sunday_18) +
            FieldTextToDouble(Page_Objects.sunday_19) + FieldTextToDouble(Page_Objects.sunday_20) + FieldTextToDouble(Page_Objects.sunday_21) +
            FieldTextToDouble(Page_Objects.sunday_22) + FieldTextToDouble(Page_Objects.sunday_23);

            double ArrivalbyESI_Mon = FieldTextToDouble(Page_Objects.Monday_0) +
            FieldTextToDouble(Page_Objects.Monday_1) + FieldTextToDouble(Page_Objects.Monday_2) + FieldTextToDouble(Page_Objects.Monday_3) +
            FieldTextToDouble(Page_Objects.Monday_4) + FieldTextToDouble(Page_Objects.Monday_5) + FieldTextToDouble(Page_Objects.Monday_6) +
            FieldTextToDouble(Page_Objects.Monday_7) + FieldTextToDouble(Page_Objects.Monday_8) + FieldTextToDouble(Page_Objects.Monday_9) +
            FieldTextToDouble(Page_Objects.Monday_10) + FieldTextToDouble(Page_Objects.Monday_11) + FieldTextToDouble(Page_Objects.Monday_12) +
            FieldTextToDouble(Page_Objects.Monday_13) + FieldTextToDouble(Page_Objects.Monday_14) + FieldTextToDouble(Page_Objects.Monday_15) +
            FieldTextToDouble(Page_Objects.Monday_16) + FieldTextToDouble(Page_Objects.Monday_17) + FieldTextToDouble(Page_Objects.Monday_18) +
            FieldTextToDouble(Page_Objects.Monday_19) + FieldTextToDouble(Page_Objects.Monday_20) + FieldTextToDouble(Page_Objects.Monday_21) +
            FieldTextToDouble(Page_Objects.Monday_22) + FieldTextToDouble(Page_Objects.Monday_23);


            double ArrivalbyESI_Tue = FieldTextToDouble(Page_Objects.Tuesday_0) +
            FieldTextToDouble(Page_Objects.Tuesday_1) + FieldTextToDouble(Page_Objects.Tuesday_2) + FieldTextToDouble(Page_Objects.Tuesday_3) +
            FieldTextToDouble(Page_Objects.Tuesday_4) + FieldTextToDouble(Page_Objects.Tuesday_5) + FieldTextToDouble(Page_Objects.Tuesday_6) +
            FieldTextToDouble(Page_Objects.Tuesday_7) + FieldTextToDouble(Page_Objects.Tuesday_8) + FieldTextToDouble(Page_Objects.Tuesday_9) +
            FieldTextToDouble(Page_Objects.Tuesday_10) + FieldTextToDouble(Page_Objects.Tuesday_11) + FieldTextToDouble(Page_Objects.Tuesday_12) +
            FieldTextToDouble(Page_Objects.Tuesday_13) + FieldTextToDouble(Page_Objects.Tuesday_14) + FieldTextToDouble(Page_Objects.Tuesday_15) +
            FieldTextToDouble(Page_Objects.Tuesday_16) + FieldTextToDouble(Page_Objects.Tuesday_17) + FieldTextToDouble(Page_Objects.Tuesday_18) +
            FieldTextToDouble(Page_Objects.Tuesday_19) + FieldTextToDouble(Page_Objects.Tuesday_20) + FieldTextToDouble(Page_Objects.Tuesday_21) +
            FieldTextToDouble(Page_Objects.Tuesday_22) + FieldTextToDouble(Page_Objects.Tuesday_23);


            double ArrivalbyESI_Wed = FieldTextToDouble(Page_Objects.wednesday_0) +
           FieldTextToDouble(Page_Objects.wednesday_1) + FieldTextToDouble(Page_Objects.wednesday_2) + FieldTextToDouble(Page_Objects.wednesday_3) +
           FieldTextToDouble(Page_Objects.wednesday_4) + FieldTextToDouble(Page_Objects.wednesday_5) + FieldTextToDouble(Page_Objects.wednesday_6) +
           FieldTextToDouble(Page_Objects. wednesday_7) + FieldTextToDouble(Page_Objects.wednesday_8) + FieldTextToDouble(Page_Objects.wednesday_9) +
           FieldTextToDouble(Page_Objects. wednesday_10) + FieldTextToDouble(Page_Objects.wednesday_11) + FieldTextToDouble(Page_Objects.wednesday_12) +
           FieldTextToDouble(Page_Objects. wednesday_13) + FieldTextToDouble(Page_Objects.wednesday_14) + FieldTextToDouble(Page_Objects.wednesday_15) +
           FieldTextToDouble(Page_Objects. wednesday_16) + FieldTextToDouble(Page_Objects.wednesday_17) + FieldTextToDouble(Page_Objects.wednesday_18) +
           FieldTextToDouble(Page_Objects. wednesday_19) + FieldTextToDouble(Page_Objects.wednesday_20) + FieldTextToDouble(Page_Objects.wednesday_21) +
           FieldTextToDouble(Page_Objects. wednesday_22) + FieldTextToDouble(Page_Objects.wednesday_23);


            double ArrivalbyESI_Thu = FieldTextToDouble(Page_Objects.Thursday_0) +
           FieldTextToDouble(Page_Objects.Thursday_1) + FieldTextToDouble(Page_Objects.Thursday_2) + FieldTextToDouble(Page_Objects.Thursday_3) +
           FieldTextToDouble(Page_Objects.Thursday_4) + FieldTextToDouble(Page_Objects.Thursday_5) + FieldTextToDouble(Page_Objects.Thursday_6) +
           FieldTextToDouble(Page_Objects.Thursday_7) + FieldTextToDouble(Page_Objects.Thursday_8) + FieldTextToDouble(Page_Objects.Thursday_9) +
           FieldTextToDouble(Page_Objects.Thursday_10) + FieldTextToDouble(Page_Objects.Thursday_11) + FieldTextToDouble(Page_Objects.Thursday_12) +
           FieldTextToDouble(Page_Objects.Thursday_13) + FieldTextToDouble(Page_Objects.Thursday_14) + FieldTextToDouble(Page_Objects.Thursday_15) +
           FieldTextToDouble(Page_Objects.Thursday_16) + FieldTextToDouble(Page_Objects.Thursday_17) + FieldTextToDouble(Page_Objects.Thursday_18) +
           FieldTextToDouble(Page_Objects.Thursday_19) + FieldTextToDouble(Page_Objects.Thursday_20) + FieldTextToDouble(Page_Objects.Thursday_21) +
           FieldTextToDouble(Page_Objects.Thursday_22) + FieldTextToDouble(Page_Objects.Thursday_23);



            double ArrivalbyESI_Fri = FieldTextToDouble(Page_Objects.Friday_0) +
           FieldTextToDouble(Page_Objects.Friday_1) + FieldTextToDouble(Page_Objects.Friday_2) + FieldTextToDouble(Page_Objects.Friday_3) +
           FieldTextToDouble(Page_Objects.Friday_4) + FieldTextToDouble(Page_Objects.Friday_5) + FieldTextToDouble(Page_Objects.Friday_6) +
           FieldTextToDouble(Page_Objects.Friday_7) + FieldTextToDouble(Page_Objects.Friday_8) + FieldTextToDouble(Page_Objects.Friday_9) +
           FieldTextToDouble(Page_Objects.Friday_10) + FieldTextToDouble(Page_Objects.Friday_11) + FieldTextToDouble(Page_Objects.Friday_12) +
           FieldTextToDouble(Page_Objects.Friday_13) + FieldTextToDouble(Page_Objects.Friday_14) + FieldTextToDouble(Page_Objects.Friday_15) +
           FieldTextToDouble(Page_Objects.Friday_16) + FieldTextToDouble(Page_Objects.Friday_17) + FieldTextToDouble(Page_Objects.Friday_18) +
           FieldTextToDouble(Page_Objects.Friday_19) + FieldTextToDouble(Page_Objects.Friday_20) + FieldTextToDouble(Page_Objects.Friday_21) +
           FieldTextToDouble(Page_Objects.Friday_22) + FieldTextToDouble(Page_Objects.Friday_23);


            double ArrivalbyESI_Sat = FieldTextToDouble(Page_Objects.Saturday_0) +
           FieldTextToDouble(Page_Objects.Saturday_1) + FieldTextToDouble(Page_Objects.Saturday_2) + FieldTextToDouble(Page_Objects.Saturday_3) +
           FieldTextToDouble(Page_Objects.Saturday_4) + FieldTextToDouble(Page_Objects.Saturday_5) + FieldTextToDouble(Page_Objects.Saturday_6) +
           FieldTextToDouble(Page_Objects.Saturday_7) + FieldTextToDouble(Page_Objects.Saturday_8) + FieldTextToDouble(Page_Objects.Saturday_9) +
           FieldTextToDouble(Page_Objects.Saturday_10) + FieldTextToDouble(Page_Objects.Saturday_11) + FieldTextToDouble(Page_Objects.Saturday_12) +
           FieldTextToDouble(Page_Objects.Saturday_13) + FieldTextToDouble(Page_Objects.Saturday_14) + FieldTextToDouble(Page_Objects.Saturday_15) +
           FieldTextToDouble(Page_Objects.Saturday_16) + FieldTextToDouble(Page_Objects.Saturday_17) + FieldTextToDouble(Page_Objects.Saturday_18) +
           FieldTextToDouble(Page_Objects.Saturday_19) + FieldTextToDouble(Page_Objects.Saturday_20) + FieldTextToDouble(Page_Objects.Saturday_21) +
           FieldTextToDouble(Page_Objects.Saturday_22) + FieldTextToDouble(Page_Objects.Saturday_23);
           

            //Actual weekly avg for all days

            double WeeklyAvgAllDay = (ArrivalbyESI_sun + ArrivalbyESI_Mon + ArrivalbyESI_Tue + ArrivalbyESI_Wed + ArrivalbyESI_Thu + ArrivalbyESI_Fri + ArrivalbyESI_Sat) / 7;

           

            //Calculated pattern for Sun = Actual total hourly volume for sun/ Actual weekly avg for all days

            double Sun_pattern = ArrivalbyESI_sun / WeeklyAvgAllDay;

            

            //Forecasted arrival for sun = (forecasted monthly arrival for Jan/31[no of days in Jan]) * cal pattern for sun

            Forcasted_Arrival_sun = (Convert.ToDouble(FieldText(Page_Objects.JAN_forcasted_monthlyArriavl)) / 31) * Sun_pattern;

            

        }

        public static void VA_MonthlyArrival(double AE_Forcasted_monthly_Ariival, double AE_ActualMonthlyArrival)
        {
            click(Page_Objects.ViewAnalysis_Tab);
            Thread.Sleep(10000);
            double VA_forcastedmonthly_JAN = Convert.ToDouble(FieldText(Page_Objects.PV_MA_ForcastedMonthlyArrival_Jan));
            double VA_ActualMonthlyArrival_JAN = Convert.ToDouble(FieldText(Page_Objects.PV_MA_ActualMonthlyArrival_Jan));
            

            AE_Forcasted_monthly_Ariival = Math.Round(AE_Forcasted_monthly_Ariival, 2);
            AE_ActualMonthlyArrival = Math.Round(AE_ActualMonthlyArrival, 2);
            if (VA_forcastedmonthly_JAN == AE_Forcasted_monthly_Ariival && VA_ActualMonthlyArrival_JAN == AE_ActualMonthlyArrival)
            {
                
                Console.WriteLine("Forecasted Monthly Arrival Data: JAN : " + VA_forcastedmonthly_JAN + "");
                Console.WriteLine("Actual Monthly Arrival Data: JAN : " + VA_ActualMonthlyArrival_JAN + "");

            }
            else
            {
                Assert.Fail("Forecasted Monthly Arrival Data and Actual Monthly Arrival Data calculations are not matched");
            }
        }

        public static void WA_DayoftheWeek(double Forcasted_Arrival_sun)
        {
            Thread.Sleep(5000);
            click(Page_Objects.Weekly_ArrivalTab);
            Thread.Sleep(10000);
            double WA_EachDayofWeek_sun = Convert.ToDouble(FieldText(Page_Objects.PV_WA_EachDayofWeek_Sun));

            Console.WriteLine("Forecasted Monthly Arrival Data: JAN : " + WA_EachDayofWeek_sun );
            Console.WriteLine("Forecasted Monthly Arrival Data: JAN : " + Forcasted_Arrival_sun);

            Forcasted_Arrival_sun = Math.Round(Forcasted_Arrival_sun, 2);
            WA_EachDayofWeek_sun = Math.Round(WA_EachDayofWeek_sun, 2);

            if (Forcasted_Arrival_sun == WA_EachDayofWeek_sun)
            {

                Console.WriteLine("Forecasted Monthly Arrival Data: JAN : " + WA_EachDayofWeek_sun );
                

            }
            else
            {
                Assert.Fail("culations Weekly Arrival Data for sunday is not matched");
            }
        }


    }
}
