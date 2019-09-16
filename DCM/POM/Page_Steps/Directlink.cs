using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using System.Threading;

namespace DCM.POM.Page_Steps 
{
    public class Directlink : MethodsAndActions
    {
        public static void verifyDirectlink(string url)
        {
            directlink(url);
            //DCM_Login.LoginDCM();
            //DCM_Login.twofa();
            string currenturl = Geturl();

            if(currenturl == "https://dcmqa.evhc.net/v2/input?modelId=")
            {
                Console.WriteLine("User Has Access of Edit input Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/analysis?modelId=")
            {
                Console.WriteLine("User Has Access of View Analysis Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/sensitivityanalysis?modelId=")
            {
                Console.WriteLine("User Has Access of Sensitivity Analysis Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/executivesummary?modelId=")
            {
                Console.WriteLine("User Has Access of Executive Summary Tab");
            }
            else if (currenturl == "https://dcmqa.evhc.net/v2/accessdenied?type=")
            {
                Console.WriteLine("Access Denied");
            }
            else
            {
                Console.WriteLine("No Access For DCM");
            }
        }
    }
}
