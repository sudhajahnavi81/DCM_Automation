using DCM.POM.DCM_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DCM.POM.Page_Steps
{
    class ExecutiveSummary : MethodsAndActions
    {
        public static void ExecutiveSummaryTab()
        {
            WaitForElement(Page_Objects.Appname);
            click(Page_Objects.Appname);
            Thread.Sleep(15000);
            JSExe(Page_Objects.Editinput);
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.ExecutiveSummaryTab);
            click(Page_Objects.ExecutiveSummaryTab);
            Thread.Sleep(15000);
            WaitForElement(Page_Objects.Key_observation);

        }

        public static void KeyObservation(string KeyObservation)
        {
            Type(KeyObservation, Page_Objects.Key_observation);
        }

        public static void Executive_Save()
        {
            JSScroll();
            Thread.Sleep(3000);
            click(Page_Objects.Executive_Save);
            Thread.Sleep(2000);
            click(Page_Objects.Executive_Save_edit);
            Thread.Sleep(2000);
            click(Page_Objects.OKbtn);
            Thread.Sleep(10000);
        }

    }
}
