using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using DCM.data;
using NUnit.Framework;
using System.Threading;
using AutoIt;

namespace DCM.POM.Page_Steps
{
    public class DCMDashboard : MethodsAndActions
    {


        public static void PracticeSearch(string practice)
        {
           
            WaitForElement(Page_Objects.practicepopup_txtbox);
            JSExe(Page_Objects.practicepopup_txtbox);
            Type(practice, Page_Objects.practicepopup_txtbox);
            WaitForElement(Page_Objects.practicepopup_linktext);
            JSExe(Page_Objects.practicepopup_linktext);
            //WaitForElement(Page_Objects.viewgraphs);
            Thread.Sleep(10000);
            //Console.WriteLine("tooltip" + Graphtooltip(Page_Objects.D_hr_graphbarone, Page_Objects.D_hr_graphbarone));
            Thread.Sleep(10000);

        }

        public static void Searchpracticewithfilters(string ou, string state, string city)
        {

            Thread.Sleep(20000);
            click(Page_Objects.practicebutton);
            Thread.Sleep(2000);
            Type(ou, Page_Objects.OU);
            click(Page_Objects.ouid);
            Thread.Sleep(2000);
            Type(state, Page_Objects.State);
            click(Page_Objects.stateid);
            Thread.Sleep(2000);
            Type(city, Page_Objects.City);
            click(Page_Objects.cityid);
            Thread.Sleep(2000);
            click(Page_Objects.practicepopup_linktext);
            Thread.Sleep(3000);
            Console.WriteLine("Selected Practice :" + FieldText(Page_Objects.selectedpractice));

        }

        public static void Verifypractice()
        {

            Console.WriteLine("Selected Model :" + GetText(Page_Objects.firstmodelname));
            Console.WriteLine("DCM Version Number" + GetText(Page_Objects.DCMVersion));

        }

        public static void OperationalHistroy()

        {

            Thread.Sleep(20000);
            click(Page_Objects.OpModelHistory);
            Thread.Sleep(10000);
            WaitForElement(Page_Objects.OKbtn);
            Console.WriteLine("Previous Operational Model(s) :");
            Console.WriteLine("Current Operational Model :" + GetText(Page_Objects.currentmodelhistory));
            try
            {
                Console.WriteLine("Previous Operational Model :" + GetText(Page_Objects.Previouslastmodel));
                Console.WriteLine("Previous Operational Model :" + GetText(Page_Objects.Previous2ndlastmodel));
                Console.WriteLine("Previous Operational Model :" + GetText(Page_Objects.Previous3rdlastmodel));
            }
            catch
            {

            }


        }

        public static void okbtn()

        {
            Thread.Sleep(3000);
            click(Page_Objects.OKbtn);
        }

        public static void Floorplan()
        {
            click(Page_Objects.Appname);
            Thread.Sleep(15000);
            click(Page_Objects.FloorPlan);
            WaitForElement(Page_Objects.uploadFloorPlanbtn);
            Thread.Sleep(1000);
            click(Page_Objects.uploadFloorPlanbtn);
            Thread.Sleep(1000);
            uploadfile(@"D:\Floorplan\Floorplan.png", "Open", "Edit1", "Button1");

            //AutoItX.ControlFocus("open", "", "Edit1");
            //upload(Page_Objects.uploadFloorPlanbtn, "Floorplan");
            ////Type("Floorplan.png", Page_Objects.uploadFloorPlanbtn);
            //Enterkey();
            Thread.Sleep(10000);
            WaitForElement(Page_Objects.viewFloorPlan);
            click(Page_Objects.viewFloorPlan);
            Thread.Sleep(10000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(8000);
            Console.WriteLine("Name of deleted Floorplan :" + MethodsAndActions.GetText(Page_Objects.floorplanName));
            //WaitForElement(Page_Objects.deleteFloorPlan);
            click(Page_Objects.deleteFloorPlan);
            elementToBeClickable(Page_Objects.OKbtn);
            click(Page_Objects.OKbtn);
            Thread.Sleep(500);


        }

        public static void FloorplanName()
        {
            Thread.Sleep(10000);

            click(Page_Objects.cancelnobtn);

        }

        //Update model name, model type and model category from Dashboard

        public static void Updatemodeldetails(string UpdateMN)
        {

            Thread.Sleep(40000);
            click(Page_Objects.EditModelDetails);
            Type(UpdateMN, Page_Objects.EMD_ModelName);
            String modeltype = GetText(Page_Objects.EMD_Modeltype);
            click(Page_Objects.EMD_Modeltype);
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


        }

        public static void Getupdatedmodeldetails()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Model name: " + MethodsAndActions.GetText(Page_Objects.Updatedmodelname));
            Console.WriteLine("Model Type: " + MethodsAndActions.GetText(Page_Objects.Updatedmodeltype));

        }

        public static void Deletemodelfromdashboard()
        {

            Thread.Sleep(40000);
            Console.WriteLine("Modelname: " + MethodsAndActions.GetText(Page_Objects.lastmodelname));
            click(Page_Objects.Deletemodelicon);
            click(Page_Objects.deleteconfirmpopup_OK);
            Thread.Sleep(20000);
            Console.WriteLine("Success Message : " + MethodsAndActions.GetText(Page_Objects.deletedmessage));
            click(Page_Objects.successpopup_OK);



        }

    }
}
