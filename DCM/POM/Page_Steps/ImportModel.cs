using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using System.Threading;

namespace DCM.POM.Page_Steps
{
   public class ImportModel : MethodsAndActions
    {
        public static void verifyImportModel()
        {
            WaitForElement(Page_Objects.Appname);
            click(Page_Objects.Appname);
            Thread.Sleep(10000);
            JSExe(Page_Objects.createModelTab);
            // WaitForElement(Page_Objects.createModelPopUp);
            JSExe(Page_Objects.importModelbtn);
        }

        public static void selectImportModel(string SearchText)
        {
            Thread.Sleep(2000);
            WaitForElement(Page_Objects.searchImportModel);
            Type(SearchText, Page_Objects.searchImportModel);
            Thread.Sleep(2000);
            click(Page_Objects.searchmodelbtn);
            click(Page_Objects.selectImportModel);
        }

        public static void saveImportedModel()
        {
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
            String modelName = "Auto_ImportedModel_" + now.ToString("MM/dd/yyyy hh:mm tt");
            Type(modelName.ToString(), Page_Objects.modelName);
            //click(Page_Objects.EMD_ModeCategory_Operational);
            click(Page_Objects.modelSave);
            //try
            //{
            //    WaitForElement(Page_Objects.op_model_verification);
            //    click(Page_Objects.Yesbtn);
            //}
            //catch
            //{

            //}
            Thread.Sleep(40000);
            click(Page_Objects.OKbtn);

            Console.WriteLine(GetText(Page_Objects.ViewAnalysis_Tab));


            Thread.Sleep(5000);
        }

    }
}
