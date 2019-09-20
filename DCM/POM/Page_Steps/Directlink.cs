using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using System.Threading;
using System.Diagnostics;

namespace DCM.POM.Page_Steps 
{
    public class Directlink : MethodsAndActions
    {
        static string currenturl = null;
        public static void verifyLoginLink()
        {
            string currenturl = Geturl();

            if (currenturl == "https://dcmqa.evhc.net/v2/dashboard")
            {
               
                DCM_Login.DCMlogout();
                //closeBrowser();
            }

        }

        public static void verifyDirectlink(string url)
        {
            Thread.Sleep(15000);
            directlink(url);
            DCM_Login.viewLoginDCM();
            DCM_Login.viewtwofa();
            Thread.Sleep(15000);

            if (currenturl == "https://dcmqa.evhc.net/v2/input?modelId=4258")
            {
                Console.WriteLine("User Has Access of Edit input Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/analysis?modelId=4258")
            {
                Console.WriteLine("User Has Access of View Analysis Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/sensitivityanalysis?modelId=4258")
            {
                Console.WriteLine("User Has Access of Sensitivity Analysis Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/executivesummary?modelId=4258")
            {
                Console.WriteLine("User Has Access of Executive Summary Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/accessdenied?type=2" 
                || currenturl == "https://dcmqa.evhc.net/v2/accessdenied?type=1" 
                || currenturl == "https://dcmqa.evhc.net/v2/accessdenied?type=3")
            {
                Console.WriteLine("Access Denied");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/accessdenied?type=4")
            {
                Console.WriteLine("Requested Model Is Deleted");
            }
            else
            {
                Console.WriteLine("No Access For DCM");
            }
        }
    }
}
