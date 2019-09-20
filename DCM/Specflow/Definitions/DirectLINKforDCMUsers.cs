using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DCM.POM.Page_Steps;
using System.Threading;

namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class DirectLINKforDCMUsers
    {
        [Given(@"verify current URL")]
        public void GivenVerifyCurrentURL()
        {
            Directlink.verifyLoginLink();
        }


        [Given(@"Click on below link and login to open edit input tab of other's private model")]
        public void GivenClickOnBelowLinkAndLoginToOpenEditInputTabOfOtherSPrivateModel(Table table)
        {
            dynamic Url = table.CreateDynamicInstance();

            string link = Url.link;

            Directlink.verifyDirectlink(link);
        }

        [Given(@"Click on below link and login to open View Analysis tab of other's private model")]
        public void GivenClickOnBelowLinkAndLoginToOpenViewAnalysisTabOfOtherSPrivateModel(Table table)
        {
            dynamic Url = table.CreateDynamicInstance();

            string link = Url.link;

            Directlink.verifyDirectlink(link);
        }

        [Given(@"Click on below link and login to open Sensitivity Analysis tab of other's private model")]
        public void GivenClickOnBelowLinkAndLoginToOpenSensitivityAnalysisTabOfOtherSPrivateModel(Table table)
        {
            dynamic Url = table.CreateDynamicInstance();

            string link = Url.link;

            Directlink.verifyDirectlink(link);
        }

        [Given(@"Click on below link and login to open Executive Summary tab of other's private model")]
        public void GivenClickOnBelowLinkAndLoginToOpenExecutiveSummaryTabOfOtherSPrivateModel(Table table)
        {
            dynamic Url = table.CreateDynamicInstance();

            string link = Url.link;

            Directlink.verifyDirectlink(link);
        }
                                  
        [Then(@"Verify edit input tab And logout from DCM and Okta\.")]
        public void ThenVerifyEditInputTabAndLogoutFromDCMAndOkta_()
        {
            Thread.Sleep(5000);
            DCM_Login.DCMlogout();
        }

        [Given(@"Click on below link and login to open edit input tab using Viewer role")]
        public void GivenClickOnBelowLinkAndLoginToOpenEditInputTabUsingViewerRole(Table table)
        {
            dynamic Url = table.CreateDynamicInstance();

            string link = Url.link;

            Directlink.verifyDirectlink(link);
        }



    }
}
