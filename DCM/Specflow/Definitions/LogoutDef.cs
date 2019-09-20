using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.DCM_Objects;
using DCM.POM;
using NUnit.Framework;


namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class LogoutDef : MethodsAndActions
    {
        [Given(@"click on logout from dashboard")]
        public void GivenClickOnLogoutFromDashboard()
        {
            Console.WriteLine("Logout user name:" +  GetText(Page_Objects.Logout));
        }

        [Then(@"user should get logout from DCM and browser should get closed")]
        public void ThenUserShouldGetLogoutFromDCMAndBrowserShouldGetClosed()
        {
            string username =  GetText(Page_Objects.Logout);
           
        }

    }
}
