using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;

namespace DCM.Specflow.Hooks
{


    [Binding]
    public  class Initialize
    {
        public static IWebDriver driver;

        [BeforeFeature]
        public static IWebDriver GetDriver()
        {

            if (driver == null)
            {
                if (FeatureContext.Current.FeatureInfo.Tags.Contains("chrome"))
                {
                    driver = new ChromeDriver();
                    
                }
                else if (FeatureContext.Current.FeatureInfo.Tags.Contains("IE"))
                {
                    driver = new InternetExplorerDriver();
                    
                }

                driver.Navigate().GoToUrl("https://dcmqa.evhc.net/v2");
                driver.Manage().Window.Maximize();
                DCM_Login.LoginDCM();
                DCM_Login.twofa();
                //DCM_Login.DCMoktalogo();

            }
             return driver;
            

        }
       

    [AfterFeature("SanityTest")]
        public static void Afterfeature()
        {
            DCM_Login.DCMlogout();
            driver.Close();
        }
    }
}