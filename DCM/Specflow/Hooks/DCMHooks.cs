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

namespace DCM.Specflow.Hooks
{


    [Binding]
    public  class Initialize
    {
        public static IWebDriver driver;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private static KlovReporter klov;
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
            //klov = new KlovReporter();

            //klov.InitMongoDbConnection("localhost", 27017);

            //klov.ProjectName = "DCM Automation Test";

            //// URL of the KLOV server
            //klov.KlovUrl = "http://localhost:5689";

            //klov.ReportName = "DCM Automation" + DateTime.Now.ToString();


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

            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            object TestResult = getter.Invoke(ScenarioContext.Current, null);


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
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            //Pending Status
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

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
            driver.Close();
            extent.Flush();
        }
    }
}