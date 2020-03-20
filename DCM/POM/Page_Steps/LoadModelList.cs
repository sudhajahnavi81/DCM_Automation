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
    class LoadModelList : MethodsAndActions
    {

        public static void SearchModelusingFilters(string modelname, string lastmodifiedname, string modeltype)
        {

            Thread.Sleep(20000);
            click(Page_Objects.Appname);
            Thread.Sleep(20000);
            
            bool FacilityIcon = false;
            try
            {
                Find(Page_Objects.practicepopup_txtbox);
                FacilityIcon = false;
            }
            catch
            {
                FacilityIcon = true;
            }
            if (!FacilityIcon)
            {
                click(Page_Objects.practicebutton);
            }
            Thread.Sleep(2000);
            click(Page_Objects.Tab_LoadModelList);
            Thread.Sleep(4000);
            click(Page_Objects.Searchmodel_txt);
            clear(Page_Objects.Searchmodel_txt);
            Type(modelname, Page_Objects.Searchmodel_txt);
            click(Page_Objects.LastModified_DD);
            click(Page_Objects.UncheckSelectAll);
            click(Page_Objects.Searchlastmodified_txt);
            Type(lastmodifiedname, Page_Objects.Searchlastmodified_txt);
            Thread.Sleep(2000);
            click(Page_Objects.Selectmodifieduser);
            Thread.Sleep(1000);
            click(Page_Objects.Modifieduser_OK);
            Thread.Sleep(1000);
            click(Page_Objects.FromCale);
            click(Page_Objects.Cal_Prev);
            click(Page_Objects.Selectdate);
            click(Page_Objects.ToCale);
            DateTime now = DateTime.Now;
            string currentdate = now.ToString("MM/dd/yyyy");
            Type(currentdate.ToString(), Page_Objects.ToCale);
            click(Page_Objects.SearchModelType_txt);
            Type(modeltype, Page_Objects.SearchModelType_txt);
            Console.WriteLine("Model name:" + GetText( Page_Objects.Searchedmodel));


        }

        public static void Verifysearchedmodel()
        {
            Console.WriteLine("Model name: , + Page_Objects.Searchedmodel");
        }

        public static void Editmodeldetails(string UpdateMN)
        {
            Thread.Sleep(3000);
            click(Page_Objects.EditModelDetails_btn);
            Thread.Sleep(4000);
            Type(UpdateMN, Page_Objects.EMD_ModelName);
            string updatedmodelNM = FieldText(Page_Objects.EMD_ModelName);
            String modeltype = GetText(Page_Objects.LML_EMD_Modeltype);
            click(Page_Objects.LML_EMD_Modeltype);
            if (modeltype == "Public")
            {
                click(Page_Objects.EMD_Modeltype_private);
            }
            else
            {
                click(Page_Objects.EMD_Modeltype_public);
            }

            click(Page_Objects.EMD_ModelCategory_Edu);
            Thread.Sleep(2000);
            click(Page_Objects.EMD_Modeldetails_Save);

            Thread.Sleep(5000);
            clear(Page_Objects.SearchModelType_txt);
            clear(Page_Objects.Searchmodel_txt);
            Thread.Sleep(2000);
            Type(updatedmodelNM, Page_Objects.Searchmodel_txt);
            Thread.Sleep(2000);
            try
            {


                Console.WriteLine("Updated Model name: " + MethodsAndActions.GetText(Page_Objects.LML_Updatedmodelname));
                Console.WriteLine("Last Modified By: " + MethodsAndActions.GetText(Page_Objects.LML_lastModifiedBy));
                Console.WriteLine("Last Modified On: " + MethodsAndActions.GetText(Page_Objects.LML_lastModifiedOn));
                Console.WriteLine("Updated Model Type: " + MethodsAndActions.GetText(Page_Objects.LML_Updatedmodeltype));
            }
            catch
            {
                Console.WriteLine("No result found");
            }
        }

        public static void VerifyViewAnalysistab()
        {
            Thread.Sleep(8000);
            click(Page_Objects.ViewAnalysis_btn);
            Thread.Sleep(8000);
            if (Page_Objects.ViewAnalysis_Tab != null)
            {
                Console.WriteLine("View Analysis tab is opened");

            } 
            else
            {
                Console.WriteLine("View Analsyis tab is not opened");
            }

            
        }

        public static void VerifyEditInputtab()
        {
            Thread.Sleep(7000);
            click(Page_Objects.Tab_LoadModelList);
            Thread.Sleep(8000);
            click(Page_Objects.EditInputs_btn);
            Thread.Sleep(8000);
            if (Page_Objects.Tab_EditInput != null)
            {
                Console.WriteLine("Edit Input tab is opened");

            }
            else
            {
                Console.WriteLine("Edit Input tab is not opened");
            }


        }


        
    }
}
