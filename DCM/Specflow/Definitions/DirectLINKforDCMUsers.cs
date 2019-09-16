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
        [Given(@"Click on below link and login to open edit input tab of other's private model")]
        public void GivenClickOnBelowLinkAndLoginToOpenEditInputTabOfOtherSPrivateModel(Table table)
        {
            dynamic Url = table.CreateDynamicInstance();

            string link = Url.link;

            Directlink.verifyDirectlink(link);
        }

        [Then(@"Verify edit input tab for logout from DCM and Okta\.")]
        public void ThenVerifyEditInputTabForLogoutFromDCMAndOkta_()
        {
            Thread.Sleep(5000);
            DCM_Login.DCMlogout();
        }

    }
}
