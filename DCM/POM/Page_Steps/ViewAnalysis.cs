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
    class ViewAnalysis : MethodsAndActions
    {

        
            string FAA =  GetText(Page_Objects.ForecastedAnnualArrivals);
            string LWBS =  GetText(Page_Objects.LWBS);
            string FAV =  GetText(Page_Objects.F_Annual_Voulme);
            string AdmitPercentage =  GetText(Page_Objects.admitPercentage);
            string jan =  GetText(Page_Objects.january);
            string AE_AAV =  GetText(Page_Objects.AE_Actual_Annual_Volume);
            string AE_FAV =  GetText(Page_Objects.AE_Forcasted_Annual_Volume);
            string sun_1 =  GetText(Page_Objects.sunday_0);
            string sun_2 =  GetText(Page_Objects.sunday_1);
            string sun_3 =  GetText(Page_Objects.sunday_2);
            string sun_4 =  GetText(Page_Objects.sunday_3);
            string sun_5 =  GetText(Page_Objects.sunday_4);
            string sun_6 =  GetText(Page_Objects.sunday_5);
            string sun_7 =  GetText(Page_Objects.sunday_6);
            string sun_8 =  GetText(Page_Objects.sunday_7);
            string sun_9 =  GetText(Page_Objects.sunday_8);
            string sun_10 =  GetText(Page_Objects.sunday_9);
            string sun_11 =  GetText(Page_Objects.sunday_10);
            string sun_12 =  GetText(Page_Objects.sunday_11);
            string sun_13 =  GetText(Page_Objects.sunday_12);
            string sun_14 =  GetText(Page_Objects.sunday_13);
            string sun_15 =  GetText(Page_Objects.sunday_14);
            string sun_16 =  GetText(Page_Objects.sunday_15);
            string sun_17 =  GetText(Page_Objects.sunday_16);
            string sun_18 =  GetText(Page_Objects.sunday_17);
            string sun_19 =  GetText(Page_Objects.sunday_18);
            string sun_20 =  GetText(Page_Objects.sunday_19);
            string sun_21 =  GetText(Page_Objects.sunday_20);
            string sun_22 =  GetText(Page_Objects.sunday_21);
            string sun_23 =  GetText(Page_Objects.sunday_22);
            string sun_24 =  GetText(Page_Objects.sunday_23);

        public static void editmodel()
        {
            click(Page_Objects.Appname);
            Thread.Sleep(10000);
            click(Page_Objects.dashboard);
            Thread.Sleep(5000);
            click(Page_Objects.EditInput);
            Thread.Sleep(10000);
            
        }


        public static void PMAEvalues()
        {


        }
    }
}
