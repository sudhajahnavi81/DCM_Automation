using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using System.Threading;


namespace DCM.POM.Page_Steps
{
    public class CreateModel : MethodsAndActions
    {
        public static void verifyCreateModel()
        {
            WaitForElement(Page_Objects.Appname);
            click(Page_Objects.Appname);
            Thread.Sleep(10000);
            JSExe(Page_Objects.createModelTab);
            // WaitForElement(Page_Objects.createModelPopUp);
            JSExe(Page_Objects.createModelFreeForm);
        }

        public static void patcticeMetrics(string area2, string area3, int F_Annual_arrivals, int LWBS, int admitPercentage)
        {

            WaitForElement(Page_Objects.additem);

            for (int i = 0; i < 2; i++)
            {

                click(Page_Objects.additem);
                if (i == 0)
                {
                    WaitForElement(Page_Objects.area2);
                    clear(Page_Objects.area2);
                    Type(area2, Page_Objects.area2);
                }
                else
                {
                    WaitForElement(Page_Objects.area3);
                    clear(Page_Objects.area3);
                    Type(area3, Page_Objects.area3);
                }


            }

            Type(F_Annual_arrivals.ToString(), Page_Objects.F_Annual_arrivals);
            Type(LWBS.ToString(), Page_Objects.LWBS);
            Type(admitPercentage.ToString(), Page_Objects.admitPercentage);


        }

        public static void ArrivalESI(int FTESI3, int PITESI3)
        {
            click(Page_Objects.arrivaldata_dropdown);
            click(Page_Objects.arrivaldata_dropdown_value);
            click(Page_Objects.segmentation_by_ESI_dropdown);
            click(Page_Objects.segmentation_by_ESI_value);


            clear(Page_Objects.ESI3_FT);
            Type(FTESI3.ToString(), Page_Objects.ESI3_FT);

            clear(Page_Objects.ESI3_PIT);
            Type(PITESI3.ToString(), Page_Objects.ESI3_PIT);
            WaitForElement(Page_Objects.Area1_24hr);
            click(Page_Objects.Area1_24hr);
            click(Page_Objects.Area2_24hr);

            JSExe(Page_Objects.ESI_next);

        }

        public static void ArrivalESI_import(int FTESI3, int PITESI3)
        {
            click(Page_Objects.arrivaldata_dropdown);
            click(Page_Objects.arrivaldata_dropdown_Import);
            WaitForElement(Page_Objects.arrivaldata_dropdown_datepicker);

            click(Page_Objects.arrivaldata_dropdown_datepicker);

            click(Page_Objects.Calendar_yeararrow);
            WaitForElement(Page_Objects.Calendar_dropdown_year);

            click(Page_Objects.Calendar_dropdown_year);
            WaitForElement(Page_Objects.Calendar_dropdown_month);
            click(Page_Objects.Calendar_dropdown_month);
            WaitForElement(Page_Objects.Calendar_dropdown_day);
            click(Page_Objects.Calendar_dropdown_day);
            click(Page_Objects.OKbtn);
            Thread.Sleep(5000);
            try
            {
                WaitForElement(Page_Objects.OK);
                click(Page_Objects.OK);
            }
            catch
            {

            }
            WaitForElement(Page_Objects.import_ok);
            click(Page_Objects.import_ok);
            Thread.Sleep(5000);
            click(Page_Objects.segmentation_by_ESI_dropdown);
            click(Page_Objects.segmentation_by_ESI_value);


            clear(Page_Objects.ESI3_FT);
            Type(FTESI3.ToString(), Page_Objects.ESI3_FT);

            clear(Page_Objects.ESI3_PIT);
            Type(PITESI3.ToString(), Page_Objects.ESI3_PIT);

            WaitForElement(Page_Objects.Area1_24hr);
            click(Page_Objects.Area1_24hr);
            click(Page_Objects.Area2_24hr);

            JSExe(Page_Objects.ESI_next);

        }




        public static void LengthDfStay(int OAL, int OAAD, int MDL, int FDL, int PDL)
        {
            WaitForElement(Page_Objects.Admit_LOS);
            Type(OAL.ToString(), Page_Objects.Admit_LOS);
            Type(OAAD.ToString(), Page_Objects.Admit_Decision);
            Type(MDL.ToString(), Page_Objects.Discharge_Los);
            Type(FDL.ToString(), Page_Objects.FT_Discharge_Los);
            Type(PDL.ToString(), Page_Objects.PIT_Discharge_Los);

            JSExe(Page_Objects.lengthofstay_next);
        }

        public static void Shifts(string FromTime, string ToTime)
        {
            WaitForElement(Page_Objects.addShifts);
            click(Page_Objects.addShifts);
            Thread.Sleep(10000);
            //WaitForElement(Page_Objects.Shiftpopup);
            //click(Page_Objects.Shiftpopup);

            JSExe(Page_Objects.selectalldays);
            Thread.Sleep(5000);
            JSExe(Page_Objects.fromDropdown);
            Type(FromTime, Page_Objects.fromDropdown);
            Enterkey(Page_Objects.fromDropdown);
            Type(ToTime, Page_Objects.toTimeDropdown);
            Enterkey(Page_Objects.toTimeDropdown);
            JSExe(Page_Objects.copytoProposed);
            JSExe(Page_Objects.saveShiftPopup);


            JSExe(Page_Objects.shifts_next);
        }

        public static void Shifts_Import()
        {
            WaitForElement(Page_Objects.importshiftbtn);
            click(Page_Objects.importshiftbtn);
            Thread.Sleep(10000);
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
            Thread.Sleep(2000);
            JSExe(Page_Objects.OKbtn);


            JSExe(Page_Objects.shifts_next);
        }






        public static void ClinicianProductivity(Double MPP, Double MAP, Double MPF, Double MAF, Double FPP, Double FAP, Double FPF, Double FAF, Double PPP, Double PAP, Double PPF, Double PAF)
        {
            //click(clinicianprod_tab);
            Type(MPP.ToString(), Page_Objects.main_phy_pph);
            Type(MAP.ToString(), Page_Objects.main_app_pph);
            Type(MPF.ToString(), Page_Objects.main_PhyFirstHour);
            //Type(main_phylasstHour, mainPhyLasthour);
            Type(MAF.ToString(), Page_Objects.main_appFirstHour);
            //Type(main_applasstHour, mainAppLasthour);

            click(Page_Objects.FtTab);
            Type(FPP.ToString(), Page_Objects.FT_Phy_pph);
            Type(FAP.ToString(), Page_Objects.FT_App_PPH);
            //click(FT_segment_Tab);
            Type(FPF.ToString(), Page_Objects.FT_PhyfirstHour);
            //Type(main_phylasstHour, mainPhyLasthour);
            Type(FAF.ToString(), Page_Objects.FT_AppfirstHour);
            //Type(main_applasstHour, mainAppLasthour);

            click(Page_Objects.PitTab);
            Type(PPP.ToString(), Page_Objects.PIT_Phy_pph);
            Type(PAP.ToString(), Page_Objects.PIT_App_PPH);
            //click(PIT_segment_Tab);
            Type(PPF.ToString(), Page_Objects.PIT_PhyfirstHour);
            //Type(main_phylasstHour, mainPhyLasthour);
            Type(PAF.ToString(), Page_Objects.PIT_AppFirstHour);
            //Type(main_applasstHour, mainAppLasthour);
            JSExe(Page_Objects.clinicianpro_next);
        }

        public static void ClinicianCost(int CPPH, int CPAH, int CPSH)
        {
            Type(CPPH.ToString(), Page_Objects.Cost_Per_Phy_Hour);
            Type(CPAH.ToString(), Page_Objects.Cost_Per_App_Hour);
            Type(CPSH.ToString(), Page_Objects.Cost_Per_Scribe_Hour);
        }

        public static void SaveModel()
        {
            click(Page_Objects.save);
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
            Thread.Sleep(40000);
            click(Page_Objects.OKbtn);



            Thread.Sleep(5000);
        }


        public static void EditModelDetail()
        {
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.Appname);
            click(Page_Objects.Appname);
            Thread.Sleep(15000);
            click(Page_Objects.dashboard);
            Thread.Sleep(10000);
            click(Page_Objects.EditEDUModelDetails);

        }

        public static void EMDOperationalcheck()
        {
            Thread.Sleep(5000);

            click(Page_Objects.EMD_ModeCategory_Operational);
            click(Page_Objects.OKbtn);
            Thread.Sleep(5000);
            //TabKey();
            try
            {
                click(Page_Objects.Yesbtn);
            }
            catch
            {

            }
            Thread.Sleep(5000);
            DCMDashboard.OperationalHistroy();
        }

        // Arrival ESI manual

        public static void manual_Actual_Monthly_Arrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            WaitForElement(Page_Objects.arrivaldata_dropdown);
            click(Page_Objects.arrivaldata_dropdown);
            click(Page_Objects.Arrival_letMeEnterMyOwn);
            //click(Page_Objects.OKbtn);
            Type(JAN.ToString(), Page_Objects.JAN);
            Type(FEB.ToString(), Page_Objects.FEB);
            Type(MAR.ToString(), Page_Objects.MAR);
            Type(APR.ToString(), Page_Objects.APR);
            Type(MAY.ToString(), Page_Objects.MAY);
            Type(JUN.ToString(), Page_Objects.JUN);
            Type(JUL.ToString(), Page_Objects.JUL);
            Type(AUG.ToString(), Page_Objects.AUG);
            Type(SEP.ToString(), Page_Objects.SEP);
            Type(OCT.ToString(), Page_Objects.OCT);
            Type(NOV.ToString(), Page_Objects.NOV);
            Type(DEC.ToString(), Page_Objects.DEC);
        }

        //Manually enter arrivals data from Wziard

        public static void Wizard_manual_Actual_Monthly_Arrival(int JAN, int FEB, int MAR, int APR, int MAY, int JUN, int JUL, int AUG, int SEP, int OCT, int NOV, int DEC)
        {
            click(Page_Objects.enterdatamanually);
            //click(Page_Objects.OKbtn);
            Thread.Sleep(2000);
            Type(JAN.ToString(), Page_Objects.JAN);
            Type(FEB.ToString(), Page_Objects.FEB);
            Type(MAR.ToString(), Page_Objects.MAR);
            Type(APR.ToString(), Page_Objects.APR);
            Type(MAY.ToString(), Page_Objects.MAY);
            Type(JUN.ToString(), Page_Objects.JUN);
            Type(JUL.ToString(), Page_Objects.JUL);
            Type(AUG.ToString(), Page_Objects.AUG);
            Type(SEP.ToString(), Page_Objects.SEP);
            Type(OCT.ToString(), Page_Objects.OCT);
            Type(NOV.ToString(), Page_Objects.NOV);
            Type(DEC.ToString(), Page_Objects.DEC);
        }

        public static void Sunday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.sunday_0);
            Type(Hr_01.ToString(), Page_Objects.sunday_1);
            Type(Hr_02.ToString(), Page_Objects.sunday_2);
            Type(Hr_03.ToString(), Page_Objects.sunday_3);
            Type(Hr_04.ToString(), Page_Objects.sunday_4);
            Type(Hr_05.ToString(), Page_Objects.sunday_5);
            Type(Hr_06.ToString(), Page_Objects.sunday_6);
            Type(Hr_07.ToString(), Page_Objects.sunday_7);
            Type(Hr_08.ToString(), Page_Objects.sunday_8);
            Type(Hr_09.ToString(), Page_Objects.sunday_9);
            Type(Hr_10.ToString(), Page_Objects.sunday_10);
            Type(Hr_11.ToString(), Page_Objects.sunday_11);
            Type(Hr_12.ToString(), Page_Objects.sunday_12);
            Type(Hr_13.ToString(), Page_Objects.sunday_13);
            Type(Hr_14.ToString(), Page_Objects.sunday_14);
            Type(Hr_15.ToString(), Page_Objects.sunday_15);
            Type(Hr_16.ToString(), Page_Objects.sunday_16);
            Type(Hr_17.ToString(), Page_Objects.sunday_17);
            Type(Hr_18.ToString(), Page_Objects.sunday_18);
            Type(Hr_19.ToString(), Page_Objects.sunday_19);
            Type(Hr_20.ToString(), Page_Objects.sunday_20);
            Type(Hr_21.ToString(), Page_Objects.sunday_21);
            Type(Hr_22.ToString(), Page_Objects.sunday_22);
            Type(Hr_23.ToString(), Page_Objects.sunday_23);
        }

        public static void Monday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.Monday_0);
            Type(Hr_01.ToString(), Page_Objects.Monday_1);
            Type(Hr_02.ToString(), Page_Objects.Monday_2);
            Type(Hr_03.ToString(), Page_Objects.Monday_3);
            Type(Hr_04.ToString(), Page_Objects.Monday_4);
            Type(Hr_05.ToString(), Page_Objects.Monday_5);
            Type(Hr_06.ToString(), Page_Objects.Monday_6);
            Type(Hr_07.ToString(), Page_Objects.Monday_7);
            Type(Hr_08.ToString(), Page_Objects.Monday_8);
            Type(Hr_09.ToString(), Page_Objects.Monday_9);
            Type(Hr_10.ToString(), Page_Objects.Monday_10);
            Type(Hr_11.ToString(), Page_Objects.Monday_11);
            Type(Hr_12.ToString(), Page_Objects.Monday_12);
            Type(Hr_13.ToString(), Page_Objects.Monday_13);
            Type(Hr_14.ToString(), Page_Objects.Monday_14);
            Type(Hr_15.ToString(), Page_Objects.Monday_15);
            Type(Hr_16.ToString(), Page_Objects.Monday_16);
            Type(Hr_17.ToString(), Page_Objects.Monday_17);
            Type(Hr_18.ToString(), Page_Objects.Monday_18);
            Type(Hr_19.ToString(), Page_Objects.Monday_19);
            Type(Hr_20.ToString(), Page_Objects.Monday_20);
            Type(Hr_21.ToString(), Page_Objects.Monday_21);
            Type(Hr_22.ToString(), Page_Objects.Monday_22);
            Type(Hr_23.ToString(), Page_Objects.Monday_23);
        }

        public static void Tuesday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.Tuesday_0);
            Type(Hr_01.ToString(), Page_Objects.Tuesday_1);
            Type(Hr_02.ToString(), Page_Objects.Tuesday_2);
            Type(Hr_03.ToString(), Page_Objects.Tuesday_3);
            Type(Hr_04.ToString(), Page_Objects.Tuesday_4);
            Type(Hr_05.ToString(), Page_Objects.Tuesday_5);
            Type(Hr_06.ToString(), Page_Objects.Tuesday_6);
            Type(Hr_07.ToString(), Page_Objects.Tuesday_7);
            Type(Hr_08.ToString(), Page_Objects.Tuesday_8);
            Type(Hr_09.ToString(), Page_Objects.Tuesday_9);
            Type(Hr_10.ToString(), Page_Objects.Tuesday_10);
            Type(Hr_11.ToString(), Page_Objects.Tuesday_11);
            Type(Hr_12.ToString(), Page_Objects.Tuesday_12);
            Type(Hr_13.ToString(), Page_Objects.Tuesday_13);
            Type(Hr_14.ToString(), Page_Objects.Tuesday_14);
            Type(Hr_15.ToString(), Page_Objects.Tuesday_15);
            Type(Hr_16.ToString(), Page_Objects.Tuesday_16);
            Type(Hr_17.ToString(), Page_Objects.Tuesday_17);
            Type(Hr_18.ToString(), Page_Objects.Tuesday_18);
            Type(Hr_19.ToString(), Page_Objects.Tuesday_19);
            Type(Hr_20.ToString(), Page_Objects.Tuesday_20);
            Type(Hr_21.ToString(), Page_Objects.Tuesday_21);
            Type(Hr_22.ToString(), Page_Objects.Tuesday_22);
            Type(Hr_23.ToString(), Page_Objects.Tuesday_23);
        }

        public static void wednesday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.wednesday_0);
            Type(Hr_01.ToString(), Page_Objects.wednesday_1);
            Type(Hr_02.ToString(), Page_Objects.wednesday_2);
            Type(Hr_03.ToString(), Page_Objects.wednesday_3);
            Type(Hr_04.ToString(), Page_Objects.wednesday_4);
            Type(Hr_05.ToString(), Page_Objects.wednesday_5);
            Type(Hr_06.ToString(), Page_Objects.wednesday_6);
            Type(Hr_07.ToString(), Page_Objects.wednesday_7);
            Type(Hr_08.ToString(), Page_Objects.wednesday_8);
            Type(Hr_09.ToString(), Page_Objects.wednesday_9);
            Type(Hr_10.ToString(), Page_Objects.wednesday_10);
            Type(Hr_11.ToString(), Page_Objects.wednesday_11);
            Type(Hr_12.ToString(), Page_Objects.wednesday_12);
            Type(Hr_13.ToString(), Page_Objects.wednesday_13);
            Type(Hr_14.ToString(), Page_Objects.wednesday_14);
            Type(Hr_15.ToString(), Page_Objects.wednesday_15);
            Type(Hr_16.ToString(), Page_Objects.wednesday_16);
            Type(Hr_17.ToString(), Page_Objects.wednesday_17);
            Type(Hr_18.ToString(), Page_Objects.wednesday_18);
            Type(Hr_19.ToString(), Page_Objects.wednesday_19);
            Type(Hr_20.ToString(), Page_Objects.wednesday_20);
            Type(Hr_21.ToString(), Page_Objects.wednesday_21);
            Type(Hr_22.ToString(), Page_Objects.wednesday_22);
            Type(Hr_23.ToString(), Page_Objects.wednesday_23);
        }

        public static void Thursday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.Thursday_0);
            Type(Hr_01.ToString(), Page_Objects.Thursday_1);
            Type(Hr_02.ToString(), Page_Objects.Thursday_2);
            Type(Hr_03.ToString(), Page_Objects.Thursday_3);
            Type(Hr_04.ToString(), Page_Objects.Thursday_4);
            Type(Hr_05.ToString(), Page_Objects.Thursday_5);
            Type(Hr_06.ToString(), Page_Objects.Thursday_6);
            Type(Hr_07.ToString(), Page_Objects.Thursday_7);
            Type(Hr_08.ToString(), Page_Objects.Thursday_8);
            Type(Hr_09.ToString(), Page_Objects.Thursday_9);
            Type(Hr_10.ToString(), Page_Objects.Thursday_10);
            Type(Hr_11.ToString(), Page_Objects.Thursday_11);
            Type(Hr_12.ToString(), Page_Objects.Thursday_12);
            Type(Hr_13.ToString(), Page_Objects.Thursday_13);
            Type(Hr_14.ToString(), Page_Objects.Thursday_14);
            Type(Hr_15.ToString(), Page_Objects.Thursday_15);
            Type(Hr_16.ToString(), Page_Objects.Thursday_16);
            Type(Hr_17.ToString(), Page_Objects.Thursday_17);
            Type(Hr_18.ToString(), Page_Objects.Thursday_18);
            Type(Hr_19.ToString(), Page_Objects.Thursday_19);
            Type(Hr_20.ToString(), Page_Objects.Thursday_20);
            Type(Hr_21.ToString(), Page_Objects.Thursday_21);
            Type(Hr_22.ToString(), Page_Objects.Thursday_22);
            Type(Hr_23.ToString(), Page_Objects.Thursday_23);
        }

        public static void Friday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.Friday_0);
            Type(Hr_01.ToString(), Page_Objects.Friday_1);
            Type(Hr_02.ToString(), Page_Objects.Friday_2);
            Type(Hr_03.ToString(), Page_Objects.Friday_3);
            Type(Hr_04.ToString(), Page_Objects.Friday_4);
            Type(Hr_05.ToString(), Page_Objects.Friday_5);
            Type(Hr_06.ToString(), Page_Objects.Friday_6);
            Type(Hr_07.ToString(), Page_Objects.Friday_7);
            Type(Hr_08.ToString(), Page_Objects.Friday_8);
            Type(Hr_09.ToString(), Page_Objects.Friday_9);
            Type(Hr_10.ToString(), Page_Objects.Friday_10);
            Type(Hr_11.ToString(), Page_Objects.Friday_11);
            Type(Hr_12.ToString(), Page_Objects.Friday_12);
            Type(Hr_13.ToString(), Page_Objects.Friday_13);
            Type(Hr_14.ToString(), Page_Objects.Friday_14);
            Type(Hr_15.ToString(), Page_Objects.Friday_15);
            Type(Hr_16.ToString(), Page_Objects.Friday_16);
            Type(Hr_17.ToString(), Page_Objects.Friday_17);
            Type(Hr_18.ToString(), Page_Objects.Friday_18);
            Type(Hr_19.ToString(), Page_Objects.Friday_19);
            Type(Hr_20.ToString(), Page_Objects.Friday_20);
            Type(Hr_21.ToString(), Page_Objects.Friday_21);
            Type(Hr_22.ToString(), Page_Objects.Friday_22);
            Type(Hr_23.ToString(), Page_Objects.Friday_23);
        }

        public static void Saturday_Arrival(int Hr_00, int Hr_01, int Hr_02, int Hr_03, int Hr_04, int Hr_05, int Hr_06, int Hr_07, int Hr_08, int Hr_09, int Hr_10, int Hr_11, int Hr_12, int Hr_13, int Hr_14, int Hr_15, int Hr_16, int Hr_17, int Hr_18, int Hr_19, int Hr_20, int Hr_21, int Hr_22, int Hr_23)
        {
            Thread.Sleep(2000);
            Type(Hr_00.ToString(), Page_Objects.Saturday_0);
            Type(Hr_01.ToString(), Page_Objects.Saturday_1);
            Type(Hr_02.ToString(), Page_Objects.Saturday_2);
            Type(Hr_03.ToString(), Page_Objects.Saturday_3);
            Type(Hr_04.ToString(), Page_Objects.Saturday_4);
            Type(Hr_05.ToString(), Page_Objects.Saturday_5);
            Type(Hr_06.ToString(), Page_Objects.Saturday_6);
            Type(Hr_07.ToString(), Page_Objects.Saturday_7);
            Type(Hr_08.ToString(), Page_Objects.Saturday_8);
            Type(Hr_09.ToString(), Page_Objects.Saturday_9);
            Type(Hr_10.ToString(), Page_Objects.Saturday_10);
            Type(Hr_11.ToString(), Page_Objects.Saturday_11);
            Type(Hr_12.ToString(), Page_Objects.Saturday_12);
            Type(Hr_13.ToString(), Page_Objects.Saturday_13);
            Type(Hr_14.ToString(), Page_Objects.Saturday_14);
            Type(Hr_15.ToString(), Page_Objects.Saturday_15);
            Type(Hr_16.ToString(), Page_Objects.Saturday_16);
            Type(Hr_17.ToString(), Page_Objects.Saturday_17);
            Type(Hr_18.ToString(), Page_Objects.Saturday_18);
            Type(Hr_19.ToString(), Page_Objects.Saturday_19);
            Type(Hr_20.ToString(), Page_Objects.Saturday_20);
            Type(Hr_21.ToString(), Page_Objects.Saturday_21);
            Type(Hr_22.ToString(), Page_Objects.Saturday_22);
            Type(Hr_23.ToString(), Page_Objects.Saturday_23);

            try
            {
                click(Page_Objects.Arrivals_OKbtn);
            }
            catch
            {

            }
        }


        public static void Overall_ED(int ESI1, int ESI2, int ESI3, int ESI4)
        {
            clear(Page_Objects.overallED_ESI1);
            Type(ESI1.ToString(), Page_Objects.overallED_ESI1);

            clear(Page_Objects.overallED_ESI2);
            Type(ESI1.ToString(), Page_Objects.overallED_ESI2);

            clear(Page_Objects.overallED_ESI3);
            Type(ESI1.ToString(), Page_Objects.overallED_ESI3);

            clear(Page_Objects.overallED_ESI4);
            Type(ESI1.ToString(), Page_Objects.overallED_ESI4);

        }

        public static void Area1_ED(int ESI1, int ESI2, int ESI3, int ESI4, int ESI5)
        {
            clear(Page_Objects.Area1_ESI1);
            Type(ESI1.ToString(), Page_Objects.Area1_ESI1);

            clear(Page_Objects.Area1_ESI2);
            Type(ESI1.ToString(), Page_Objects.Area1_ESI2);

            clear(Page_Objects.Area1_ESI3);
            Type(ESI1.ToString(), Page_Objects.Area1_ESI3);

            clear(Page_Objects.Area1_ESI4);
            Type(ESI1.ToString(), Page_Objects.Area1_ESI4);

            clear(Page_Objects.Area1_ESI5);
            Type(ESI1.ToString(), Page_Objects.Area1_ESI5);

            click(Page_Objects.Area1_24hr);
                               
        }
        public static void Area2_ED(int ESI1, int ESI2, int ESI3, int ESI4, int ESI5)
        {
            clear(Page_Objects.Area2_ESI1);
            Type(ESI1.ToString(), Page_Objects.Area2_ESI1);

            clear(Page_Objects.Area2_ESI2);
            Type(ESI1.ToString(), Page_Objects.Area2_ESI2);

            clear(Page_Objects.Area2_ESI3);
            Type(ESI1.ToString(), Page_Objects.Area2_ESI3);

            clear(Page_Objects.Area2_ESI4);
            Type(ESI1.ToString(), Page_Objects.Area2_ESI4);

            clear(Page_Objects.Area2_ESI5);
            Type(ESI1.ToString(), Page_Objects.Area2_ESI5);

            click(Page_Objects.Area2_24hr);

            JSExe(Page_Objects.ESI_next);

        }
    }      
}
