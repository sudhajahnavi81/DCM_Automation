// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DCM.Specflow.Features.LoadModelList
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LoadModelList")]
    [NUnit.Framework.CategoryAttribute("chrome")]
    [NUnit.Framework.CategoryAttribute("SanityTest")]
    public partial class LoadModelListFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LoadModelList.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LoadModelList", "\tSearch models, Sort model list and perform Actions", ProgrammingLanguage.CSharp, new string[] {
                        "chrome",
                        "SanityTest"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Search models with different filters")]
        public virtual void _01SearchModelsWithDifferentFilters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Search models with different filters", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Modelname",
                        "Modifieduser",
                        "Modeltype"});
            table35.AddRow(new string[] {
                        "Automation",
                        "Sunil",
                        "Private"});
#line 9
 testRunner.Given("Go to Load model list - Models in Selected practice and enter partial model name " +
                    "and click on last modeified by DD and deselect Select all and search one user an" +
                    "d select that user and enter from and To date and enter model type", ((string)(null)), table35, "Given ");
#line 12
 testRunner.And("verify model displayed accorinf to selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Updatemodelname"});
            table36.AddRow(new string[] {
                        "_Updated"});
#line 13
 testRunner.Then("Click on Edit Model Details update model information and verify updated informati" +
                    "on", ((string)(null)), table36, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 verify View Analysis and Edit input tabs opened")]
        public virtual void _02VerifyViewAnalysisAndEditInputTabsOpened()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 verify View Analysis and Edit input tabs opened", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Modelname",
                        "Modifieduser",
                        "Modeltype"});
            table37.AddRow(new string[] {
                        "Automation",
                        "Sunil",
                        "Private"});
#line 18
 testRunner.Given("Go to Load model list - Models in Selected practice and enter partial model name " +
                    "and click on last modeified by DD and deselect Select all and search one user an" +
                    "d select that user and enter from and To date and enter model type", ((string)(null)), table37, "Given ");
#line 21
 testRunner.And("Search model and click on View Analysis and check view analysis tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("Come back to load model list and click on Edit Input button and verify Edit input" +
                    " tab opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
