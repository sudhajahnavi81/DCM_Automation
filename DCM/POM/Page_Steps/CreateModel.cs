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

            Type(F_Annual_arrivals.ToString() ,Page_Objects.F_Annual_arrivals);
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




        public static void LengthDfStay(int OAL, int OAAD,int MDL,int FDL,int PDL)
        {
            WaitForElement(Page_Objects.Admit_LOS);
            Type(OAL.ToString(),Page_Objects.Admit_LOS);
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
            Type(FromTime,Page_Objects.fromDropdown);
            Enterkey(Page_Objects.fromDropdown);
            Type(ToTime,Page_Objects.toTimeDropdown);
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
            Type(MPP.ToString(),Page_Objects.main_phy_pph);
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
            try
            {
                WaitForElement(Page_Objects.Ok_Req);
                click(Page_Objects.Ok_Req);
            }
            catch
            {

            }
            WaitForElement(Page_Objects.modelName);
            //click(savepopup);
            DateTime now = DateTime.Now;
            String modelName = "Automation_" + now.ToString("MM/dd/yyyy hh:mm tt");
            Type(modelName.ToString(), Page_Objects.modelName);
            click(Page_Objects.modelSave);
            Thread.Sleep(40000);
            click(Page_Objects.OKbtn);
           
            
            
            Thread.Sleep(5000);
        }


        public static void EditModelDetail()
        {
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
            click(Page_Objects.Yesbtn);
            Thread.Sleep(5000);
            DCMDashboard.OperationalHistroy();
        }

        

    }   
}
