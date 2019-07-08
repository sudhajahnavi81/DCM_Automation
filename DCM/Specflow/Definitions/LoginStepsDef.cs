using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;
using NUnit.Framework;
using DCM.Specflow.Hooks;


namespace DCM.Specflow.LoginDef
{
    [Binding]
    public  class LoginStepsDef 
    {
        

        //[Given(@"Chrome opens and loads the DCM login page")]
        //public void GivenChromeOpensAndLoadsTheDCMLoginPage()
        //{
        //    DCM_Login.LoginDCM();
        //    DCM_Login.twofa();
        //    DCM_Login.DCMoktalogo();
        //}

        //[Then(@"DCM login page loads")]
        //public void ThenDCMLoginPageLoads()
        //{
        //    Assert.AreEqual("DCM", Hooks.Initialize.GetDriver().Title);
        //}

    }
}
