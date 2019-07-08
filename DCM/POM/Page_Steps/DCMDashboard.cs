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
            click(Page_Objects.practicepopup_txtbox);
            Type(practice, Page_Objects.practicepopup_txtbox);
            WaitForElement(Page_Objects.practicepopup_linktext);
            click(Page_Objects.practicepopup_linktext);
            WaitForElement(Page_Objects.viewgraphs);
        }

        public static void Verifypractice()
        {

            Console.WriteLine("Selected Model :" + GetText(Page_Objects.firstmodelname));
            Console.WriteLine("DCM Version Number" + GetText(Page_Objects.DCMVersion));

        }
        
        public static void OperationalHistroy()

        {


            Thread.Sleep(30000);
            click(Page_Objects.OpModelHistory);
            Thread.Sleep(30000);
            WaitForElement(Page_Objects.OKbtn);
            Console.WriteLine("Previous Operational Model(s) :");
            Console.WriteLine("Current Operational Model :" + GetText(Page_Objects.currentmodelhistory));
            Console.WriteLine("Previous Operational Model :" + GetText(Page_Objects.Previouslastmodel));
            Console.WriteLine("Previous Operational Model :" + GetText(Page_Objects.Previous2ndlastmodel));
            Console.WriteLine("Previous Operational Model :" + GetText(Page_Objects.Previous3rdlastmodel));
            
            
        }

        public static void okbtn()

        {
            click(Page_Objects.OKbtn);
        }

        public static void Floorplan()
        {

            Thread.Sleep(30000);
            click(Page_Objects.FloorPlan);
            WaitForElement(Page_Objects.uploadFloorPlanbtn);
            Thread.Sleep(1000);
            click(Page_Objects.uploadFloorPlanbtn);
            Thread.Sleep(1000);
            uploadfile(@"C:\Users\sunil\Documents\ShareX\Screenshots\2019-06\Floorplan.png", "Open","Edit1", "Button1");

            //AutoItX.ControlFocus("open", "", "Edit1");
            //upload(Page_Objects.uploadFloorPlanbtn, "Floorplan");
            ////Type("Floorplan.png", Page_Objects.uploadFloorPlanbtn);
            //Enterkey();
            Thread.Sleep(10000);
            WaitForElement(Page_Objects.viewFloorPlan);
            click(Page_Objects.viewFloorPlan);
           Thread.Sleep(10000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(10000);
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


    }
}
