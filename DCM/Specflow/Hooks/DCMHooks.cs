using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using System.Reflection;
using BoDi;
using OpenQA.Selenium.Remote;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace DCM.Specflow.Hooks
{


    [Binding]
    public  class Initialize
    {
        
        public static IWebDriver driver;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private readonly IObjectContainer _objectContainer;

        

        public Initialize(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }


        [BeforeTestRun]
        public static void InitializeReport()
        {
            //Initialize Extent report before test starts
            var htmlReporter = new ExtentHtmlReporter(@"D:\DCMAutomation\DCM\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //Attach report to reporter
            extent = new ExtentReports();
            
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }


        [BeforeFeature]
        public static IWebDriver GetDriver()
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

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



        [AfterStep]
        public void InsertReportingSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            var pendingDef = ScenarioContext.Current.ScenarioExecutionStatus.ToString();
            


            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);


                //var Pass = ScenarioContext.Current.ScenarioInfo;
                //var passmessage = "<pre>" + Pass.Title + "</pre>";

                //extent.AddTestRunnerLogs(passmessage);
                //scenario.Log(Status.Error, passmessage);


            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError);

                //var error = ScenarioContext.Current.TestError;
                //var errormessage = "<pre>" + error.Message + "</pre>";

                //extent.AddTestRunnerLogs(errormessage);
                //scenario.Log(Status.Error, errormessage);
                
            }

            //Pending Status
            if (pendingDef == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
              

                //var skip = ScenarioContext.Current.ScenarioInfo;
                //var skipmsg = "<pre>" + skip.Title + "</pre>";

                //extent.AddTestRunnerLogs(skipmsg);
                //scenario.Log(Status.Skip, skipmsg);
            }

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "<pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            Status logstatus;
            try
            {
                
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        // string screenShotPath = Capture(driver, TestContext.CurrentContext.Test.Name);
                        scenario.Log(Status.Error, "Test ended with" + logstatus);
                        // scenario.Log(logstatus, 'Snapshot below: ” +_test.AddScreenCaptureFromPath(screenShotPath));
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        scenario.Log(Status.Skip, "Test ended with" + logstatus);
                        break;
                    default:
                        logstatus = Status.Pass;
                        scenario.Log(Status.Error, "Test ended with" + logstatus);
                        break;
                }
                extent.Flush();
            }
            catch (Exception e)
            {
                throw (e);
            }
            extent.Flush();


        }
        [BeforeScenario]
        public void Init()
        {
            
            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }
    [AfterFeature]
        public static void Afterfeature()
        {
            DCM_Login.DCMlogout();
            driver.Quit();
            extent.Flush();
        }
    }
}