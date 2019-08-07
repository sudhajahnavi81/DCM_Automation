using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using DCM.POM.Page_Steps;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using DCM.POM;
using DCM.POM.DCM_Objects;
using OpenQA.Selenium;
using AventStack.ExtentReports.Model;
using System.Threading;

namespace DCM.Specflow.Definitions
{
    [Binding]
    public sealed class DashboardDef : Steps
    {

        [Given(@"Enter practice name into search practice textbox and select searched practice\.")]
        public void GivenEnterPracticeIntoSearchPracticeTextboxAndSelectSearchedPractice_(Table practice)
        {
            dynamic table = practice.CreateDynamicInstance();
            string name = table.name;

            DCMDashboard.PracticeSearch(name);
            Thread.Sleep(1000);
            //CreateModel.graphdetails();


        }

        [Then(@"models should show from selected practice")]
        public void ThenModelsShouldShowFromSelectedPractice()
        {
            DCMDashboard.Verifypractice();
        }

        // Operational Model history

        [Given(@"click on operational model history")]
        public void GivenClickOnOperationalModelHistory()
        {
            DCMDashboard.OperationalHistroy();
        }


        [Then(@"verify operational model history")]
        [Then(@"verify current operational model name and previous operational model names")]
        public void ThenVerifyCurrentOperationalModelNameAndPriviousOpearationModelNames()
        {


            var selectmodel = MethodsAndActions.GetText(Page_Objects.firstmodelname);
            var CurrentOPModel = MethodsAndActions.GetText(Page_Objects.currentmodelhistory) +" (Operational)";
            try
            {
                Assert.AreEqual(selectmodel, CurrentOPModel);
               // Assert.That(CurrentOPModel, Is.Null, "Operational Model is not equal to current operational model of history");
                Console.WriteLine("Operational Model is equal to current operational model of history");


            }
            catch (AssertionException)
            {
                Assert.Fail();
                //Console.WriteLine("No operational model found for selected practice");
            }
            finally
            {
                DCMDashboard.okbtn();
            }
            


        }

        // Floor Plan upload

        [Given(@"click on Floor Plan link and verify View, delete and upload floor plan")]
        public void GivenClickOnFloorPlanLinkAndVerifyViewDeleteAndUploadFloorPlan()
        {
            DCMDashboard.Floorplan();
        }


        [Then(@"verify uploaded image")]
        public void ThenVerifyUploadedImage_()
        {
            DCMDashboard.FloorplanName();
        }





    }
}
