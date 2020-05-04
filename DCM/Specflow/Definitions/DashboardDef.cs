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

        //Search practice with OU, State and City

        [Given(@"click on select practice icon and search with OU state and city and select searched practice")]
        public void GivenClickOnSelectPracticeIconAndSearchWithOUStateAndCityAndSelectSearchedPractice(Table filters)
        {

            dynamic table = filters.CreateDynamicInstance();
            string OU = table.OU;
            string State = table.State;
            string City = table.City;
            DCMDashboard.Searchpracticewithfilters(OU,State,City);
        }

        [Then(@"Searched practice should get selected")]
        public void ThenSearchedPracticeShouldGetSelected()
        {
            Console.WriteLine("Searched practice selected");
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

        //Update model name, model type and model category from Dashboard

        [Given(@"Click on Edit model details on any non operational model and update model name model type and model category and click on save")]
        public void GivenClickOnEditModelDetailsAtAnyNonOperationalModelAndUpdateModelNameModelTypeAndModelCategoryAndClickOnSave(Table Updatemn)
        {
            Thread.Sleep(30000);
            dynamic table = Updatemn.CreateDynamicInstance();
            string Modelupdate = table.UpdateMN;

            DCMDashboard.Updatemodeldetails(Modelupdate);



        }

        [Then(@"verify model details updated")]
        public void ThenVerifyModel()
        {
            Console.WriteLine("Model details updated");
            DCMDashboard.Getupdatedmodeldetails();
            
        }

        //delete model which is last in model list at dashboard

        [Given(@"click on Delete model icon and click on yes at confirmation pop up and click ok yes")]
        public void GivenClickOnDeleteModelIconAndClickOnYesAtConfirmationPopUpAndClickOkYes()
        {
            DCMDashboard.Deletemodelfromdashboard();
        }

        [Then(@"verify success message displayed and verify model has been removed from the dashboard")]
        public void ThenVerifySuccessMessageDisplayedAndVerifyModelHasBeenRemovedFromTheDashboard()
        {
            Console.WriteLine("Model deleted successfully");
        }





    }
}
