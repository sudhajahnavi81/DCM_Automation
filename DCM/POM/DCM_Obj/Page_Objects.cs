using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCM.POM.DCM_Objects
{
    public static class Page_Objects
    {

        //Login page

       public static By signIn = By.Id("okta-signin-username");
        public static By oktapswd = By.Id("okta-signin-password");
        public static By oktasubmit = By.Id("okta-signin-submit");

        // 2Fa

        public static By oktatwofa = By.XPath("//input[@name='answer']");
        public static By oktaverify = By.XPath("//input[@value='Verify']");

        //okta page and DCM QA logo 

        public static By DCMoktalogo = By.XPath("//a[@data-se='app-button-0oalv1edwb83ftgN90x7']");

        //Practice popup

        public static By practicebutton = By.XPath("//strong[@class='facility-icon']");
        public static By practicepopup = By.XPath("//div[@class='facility-dropdown ng-star-inserted']");
        public static By practicepopup_txtbox = By.XPath("//input[@placeholder='Search for Practice']");
        public static By practicepopup_linktext = By.XPath("//li[@class='ng-star-inserted']");
        public static By viewgraphs = By.XPath("//button[@class='btn btn-primary-default btn-primary-shadow']");
        public static By DashboardGrid = By.XPath("//th[@class='mat-header-cell ng-tns-c12-20 cdk-column-ModelName mat-column-ModelName ng-star-inserted']");
        public static By DCMVersion = By.XPath("//div[@class='d-inline mr-2']//span");
        public static By firstmodelname = By.XPath("//div[contains(@class,'dashboard-sec-subbar  dashTitleBar move-tooltip-right white-space')]");
        public static By OU = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/app-header[1]/div[1]/app-topbar[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/ng-select[1]/div[1]/div[1]/div[2]/input[1]");
        public static By State = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/app-header[1]/div[1]/app-topbar[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/ng-select[1]/div[1]/div[1]/div[2]/input[1]");
        public static By City = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/app-header[1]/div[1]/app-topbar[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/div[1]/ng-select[1]/div[1]/div[1]/div[2]/input[1]");
        public static By ouid = By.XPath("//span[contains(text(),'Southeast')]");
        public static By stateid = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/app-header[1]/div[1]/app-topbar[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/ng-select[1]/ng-dropdown-panel[1]/div[1]/div[2]/div[1]");
        public static By cityid = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/app-header[1]/div[1]/app-topbar[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/div[1]/ng-select[1]/ng-dropdown-panel[1]/div[1]/div[2]/div[1]");
        public static By selectedpractice = By.XPath("//input[@placeholder='Select Practice']");
        //Operational model history

        public static By OpModelHistory = By.XPath("//div[@class='model-history ml-2']");
        public static By currentmodelhistory = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-operational-model-history/div/div[2]/div/div[2]/table/tbody/tr/td[1]");
        public static By Previouslastmodel = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-operational-model-history/div/div[2]/div/div[3]/div[2]/table/tbody/tr[1]/td[1]");
        public static By Previous2ndlastmodel = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-operational-model-history/div/div[2]/div/div[3]/div[2]/table/tbody/tr[2]/td[1]");
        public static By Previous3rdlastmodel = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-operational-model-history/div/div[2]/div/div[3]/div[2]/table/tbody/tr[3]/td[1]");
        public static By OKbtn = By.XPath("//button[@class='btn btn-primary']");

        // dashboard graph

        public static By dashboard = By.XPath("//a[contains(text(),'Dashboard')]");
        public static By selectGraphDropdown = By.XPath("//ng-select[@class='select-medium ng-select-field ng-select ng-select-single ng-select-searchable ng-untouched ng-pristine ng-valid ng-select-opened ng-select-bottom']//input");
        public static By selectDay = By.XPath("//ng-select[@class='select-small ng-select-field ng-select ng-select-single ng-select-searchable ng-pristine ng-valid ng-select-bottom ng-touched ng-select-opened']//input");
        public static By EditInput = By.XPath("//tr[1]//td[6]//button[2]");



        //floor plan
        public static By FloorPlan = By.XPath("//div[@class='floorplan']");
        public static By viewFloorPlan = By.XPath("//span[@class='floor-view floor-btn']");
        public static By deleteFloorPlan = By.XPath("//span[contains(text(),'Floorplan')]//following::div[2]/span[1]/i[1]");
        public static By uploadFloorPlanbtn = By.XPath("//button[@class='btn btn-upld ng-star-inserted']");
        public static By cancelnobtn = By.XPath("//button[@class='btn btn-danger']");
        public static By floorplanName = By.XPath("//ul[@class='floor-list']//li[1]//div[1]//div[1]//span[1]");


        //Delete model
        public static By lastmodelname = By.XPath("//table[@class='mat-elevation-z8 mat-table']/tbody/tr[10]/td[1]");
        public static By Deletemodelicon = By.XPath("/html/body/app-root/div/div/div/app-dashboard/div/div[2]/app-dashboard-model-list/div/table/tbody/tr[10]/td[6]/span");
        public static By deleteconfirmpopup_OK = By.XPath("//button[@class='btn btn-primary']");
        public static By deletedmessage = By.XPath("//mat-dialog-content[@class='mat-dialog-content']");
        public static By successpopup_OK = By.XPath("//button[@class='btn btn-primary']");


        //create Model
        public static By Appname = By.XPath("//div[@class='d-inline mr-2']");
        public static By createModelTab = By.XPath("//a[contains(text(),'Create Model')]");
        public static By createModelFreeForm = By.XPath("//a[contains(text(),'Create Model using Free Form')]");
        public static By createModelPopUp = By.XPath("//*[@id='mat-dialog-1']");
        public static By importModelbtn = By.XPath("//a[contains(text(),'Import from Existing Model')]");

        //Import Model
        public static By searchImportModel = By.XPath("//input[@placeholder='Search for Model Name']");
        public static By searchmodelbtn = By.XPath("//i[@class='fa fa-search']");
        public static By selectImportModel = By.XPath("//div[@class='cdk-overlay-container']//tbody//tr[1]/td[1]");

        //Practice Metrics

        public static By additem = By.XPath("//span[@class='add-items']");
        public static By area2 = By.XPath("//label[contains(text(),'Area 2')]//following::div/input");
        public static By area3 = By.XPath("//label[contains(text(),'Area 3')]//following::div/input");
        public static By F_Annual_arrivals = By.XPath("//label[contains(text(),'Forecasted Annual Arrivals (walkouts included)')]//following::div/div/input");
        public static By LWBS = By.XPath("//label[contains(text(),'Current LWBS rate (walkouts)')]//following::div/div/input");
        public static By F_Annual_Voulme = By.XPath("//label[@class='d-block'][contains(text(),'Forecasted Annual Volume')]//following::div/div/input");
        public static By admitPercentage = By.XPath("//tab[@class='active tab-pane']//div[4]//div[1]//div[1]//div[1]//input[1]");


        //Arrival/ESI

        public static By arrivaldata_dropdown = By.XPath("//*[@id=\"arrivals-data\"]/div/div[1]/div/div/div[1]");
        public static By arrivaldata_dropdown_value = By.XPath("//*[@id=\"arrivals-data\"]/div/div[1]/div/div/div[2]/ul/li[2]");
        public static By arrivaldata_dropdown_Import = By.XPath("//li[contains(text(),'Import Data')]");
        public static By arrivaldata_dropdown_datepicker = By.XPath("//*[@id='mat-dialog-1']/app-import-data/div/div[2]/div/div[1]/div/mat-form-field/div/div[1]/div[2]/mat-datepicker-toggle/button");

        public static By Calendar_yeararrow = By.XPath("//div[@class='mat-calendar-arrow']");
        public static By Calendar_dropdown_year = By.XPath("//mat-multi-year-view[@class='ng-star-inserted']//table//tbody//tr/td[3]/div[contains(text(),'2018')]");
        public static By Calendar_dropdown_month = By.XPath("//div[contains(text(),'JAN')]");
        public static By Calendar_dropdown_day = By.XPath("//div[contains(text(),'14')]");

        public static By import_ok = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-import-data[1]/div[1]/div[3]/div[1]/button[1]");
        public static By segmentation_by_ESI_dropdown = By.XPath("//*[@id=\"segmentation-data\"]/div[1]/div/div/div");
        public static By segmentation_by_ESI_value = By.XPath("//*[@id=\"segmentation-data\"]/div[1]/div/div/div[2]/ul/li[1]");
        public static By ESI3_FT = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[4]/div/div/input");
        public static By ESI3_PIT = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[4]/div/div/input");
        public static By january = By.XPath("//a[@class='btn-month-label pb-2 d-block'][contains(text(),'JAN')]/following::input[1]");
        public static By AE_Actual_Annual_Volume = By.XPath("//*[@id='arrivals-data']/app-actual-monthly-arrival/div[1]/div/div[2]/div/div");
        public static By AE_Forcasted_Annual_Volume = By.XPath("//*[@id='arrivals-data']/app-actual-monthly-arrival/div[2]/app-forecasted-monthly-arrival/div/div/div[2]/div/div");
        public static By JAN_forcasted_monthlyArriavl = By.XPath("//app-forecasted-monthly-arrival//div[@class='row']//div[1]//div[1]//a[contains(text(),'JAN')]/following::input[1]");
        public static By Area1_24hr = By.XPath("//tr[2]//td[7]//div[1]//div[3]//label[1]//span[1]");
        public static By Area2_24hr = By.XPath("//tr[3]//td[7]//div[1]//div[3]//label[1]//span[1]");

        public static By overallED_ESI1 = By.XPath("//table[starts-with(@class,'segmentation mt-')]//td[2]//div[1]//div[1]//input[1]");
        public static By overallED_ESI2 = By.XPath("//table[starts-with(@class,'segmentation mt-')]//td[3]//div[1]//div[1]//input[1]");
        public static By overallED_ESI3 = By.XPath("//table[starts-with(@class,'segmentation mt-')]//td[4]//div[1]//div[1]//input[1]");
        public static By overallED_ESI4 = By.XPath("//table[starts-with(@class,'segmentation mt-')]//td[5]//div[1]//div[1]//input[1]");
        public static By overallED_ESI5 = By.XPath("//input[@id='mainesi5']");

        public static By Area1_ESI1 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[2]/div/div/input");
        public static By Area1_ESI2 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[3]/div/div/input");
        public static By Area1_ESI3 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[4]/div/div/input");
        public static By Area1_ESI4 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[5]/div/div/input");
        public static By Area1_ESI5 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[6]/div/div/input");

        public static By Area2_ESI1 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[2]/div/div/input");
        public static By Area2_ESI2 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[3]/div/div/input");
        public static By Area2_ESI3 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[4]/div/div/input");
        public static By Area2_ESI4 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[5]/div/div/input");
        public static By Area2_ESI5 = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[6]/div/div/input");



        public static By Arrival_letMeEnterMyOwn = By.XPath("//li[contains(text(),'Let me enter my Own')]");
        public static By JAN = By.XPath("//input[@id='JAN']");
        public static By FEB = By.XPath("//input[@id='FEB']");
        public static By MAR = By.XPath("//input[@id='MAR']");
        public static By APR = By.XPath("//input[@id='APR']");
        public static By MAY = By.XPath("//input[@id='MAY']");
        public static By JUN = By.XPath("//input[@id='JUN']");
        public static By JUL = By.XPath("//input[@id='JUL']");
        public static By AUG = By.XPath("//input[@id='AUG']");
        public static By SEP = By.XPath("//input[@id='SEP']");
        public static By OCT = By.XPath("//input[@id='OCT']");
        public static By NOV = By.XPath("//input[@id='NOV']");
        public static By DEC = By.XPath("//input[@id='DEC']");

        

        //Actual Hourly Arrivals By Day Of Week 

        public static By sunday_0 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By sunday_1 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By sunday_2 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By sunday_3 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By sunday_4 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By sunday_5 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By sunday_6 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By sunday_7 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By sunday_8 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By sunday_9 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By sunday_10 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By sunday_11 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By sunday_12 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By sunday_13 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By sunday_14 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By sunday_15 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By sunday_16 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By sunday_17 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By sunday_18 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By sunday_19 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By sunday_20 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By sunday_21 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By sunday_22 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By sunday_23 = By.XPath("//div[@class='weekly-timeline']//div[1]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");


        public static By Monday_0 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Monday_1 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By Monday_2 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By Monday_3 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By Monday_4 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By Monday_5 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By Monday_6 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By Monday_7 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By Monday_8 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By Monday_9 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By Monday_10 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By Monday_11 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By Monday_12 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By Monday_13 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By Monday_14 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By Monday_15 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By Monday_16 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By Monday_17 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By Monday_18 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By Monday_19 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By Monday_20 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By Monday_21 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By Monday_22 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By Monday_23 = By.XPath("//div[@class='weekly-timeline']//div[2]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");


        public static By Tuesday_0 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Tuesday_1 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By Tuesday_2 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By Tuesday_3 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By Tuesday_4 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By Tuesday_5 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By Tuesday_6 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By Tuesday_7 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By Tuesday_8 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By Tuesday_9 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By Tuesday_10 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By Tuesday_11 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By Tuesday_12 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By Tuesday_13 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By Tuesday_14 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By Tuesday_15 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By Tuesday_16 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By Tuesday_17 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By Tuesday_18 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By Tuesday_19 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By Tuesday_20 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By Tuesday_21 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By Tuesday_22 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By Tuesday_23 = By.XPath("//div[@class='weekly-timeline']//div[3]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");


        public static By wednesday_0 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By wednesday_1 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By wednesday_2 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By wednesday_3 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By wednesday_4 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By wednesday_5 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By wednesday_6 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By wednesday_7 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By wednesday_8 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By wednesday_9 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By wednesday_10 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By wednesday_11 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By wednesday_12 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By wednesday_13 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By wednesday_14 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By wednesday_15 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By wednesday_16 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By wednesday_17 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By wednesday_18 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By wednesday_19 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By wednesday_20 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By wednesday_21 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By wednesday_22 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By wednesday_23 = By.XPath("//div[@class='weekly-timeline']//div[4]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");


        public static By Thursday_0 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Thursday_1 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By Thursday_2 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By Thursday_3 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By Thursday_4 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By Thursday_5 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By Thursday_6 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By Thursday_7 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By Thursday_8 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By Thursday_9 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By Thursday_10 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By Thursday_11 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By Thursday_12 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By Thursday_13 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By Thursday_14 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By Thursday_15 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By Thursday_16 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By Thursday_17 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By Thursday_18 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By Thursday_19 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By Thursday_20 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By Thursday_21 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By Thursday_22 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By Thursday_23 = By.XPath("//div[@class='weekly-timeline']//div[5]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");



        public static By Friday_0 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Friday_1 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By Friday_2 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By Friday_3 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By Friday_4 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By Friday_5 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By Friday_6 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By Friday_7 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By Friday_8 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By Friday_9 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By Friday_10 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By Friday_11 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By Friday_12 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By Friday_13 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By Friday_14 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By Friday_15 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By Friday_16 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By Friday_17 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By Friday_18 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By Friday_19 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By Friday_20 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By Friday_21 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By Friday_22 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By Friday_23 = By.XPath("//div[@class='weekly-timeline']//div[6]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");



        public static By Saturday_0 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Saturday_1 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[2]//input[1]");
        public static By Saturday_2 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[3]//input[1]");
        public static By Saturday_3 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[4]//input[1]");
        public static By Saturday_4 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[5]//input[1]");
        public static By Saturday_5 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[6]//input[1]");
        public static By Saturday_6 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[7]//input[1]");
        public static By Saturday_7 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[8]//input[1]");
        public static By Saturday_8 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[9]//input[1]");
        public static By Saturday_9 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[10]//input[1]");
        public static By Saturday_10 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[11]//input[1]");
        public static By Saturday_11 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[12]//input[1]");
        public static By Saturday_12 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[13]//input[1]");
        public static By Saturday_13 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[14]//input[1]");
        public static By Saturday_14 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[15]//input[1]");
        public static By Saturday_15 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[16]//input[1]");
        public static By Saturday_16 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[17]//input[1]");
        public static By Saturday_17 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[18]//input[1]");
        public static By Saturday_18 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[19]//input[1]");
        public static By Saturday_19 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[20]//input[1]");
        public static By Saturday_20 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[21]//input[1]");
        public static By Saturday_21 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[22]//input[1]");
        public static By Saturday_22 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[23]//input[1]");
        public static By Saturday_23 = By.XPath("//div[@class='weekly-timeline']//div[7]//div[2]//app-input-child[1]//div[1]//div[1]//div[24]//input[1]");







        //length of stay

        public static By lengthofstay_tab = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/ul/li[3]/a/span");
        public static By Admit_LOS = By.XPath("//div[@class='col-sm-5']//div[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Admit_Decision = By.XPath("//div[@class='col-sm-5']//div[2]//div[1]//div[1]//div[1]//input[1]");
        public static By Discharge_Los = By.XPath("//label[contains(text(),'Main Discharge LOS')]//following::div/div/input");
        public static By FT_Discharge_Los = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-input[1]/div[1]/div[2]/tabset[1]/div[1]/tab[3]/app-lengthofstay[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/input[1]");
        public static By PIT_Discharge_Los = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-input[1]/div[1]/div[2]/tabset[1]/div[1]/tab[3]/app-lengthofstay[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/input[1]");

        //Shifts 

        public static By Shifts_tab = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/ul/li[4]/a/span");
        public static By addShifts = By.XPath("//li[2]//button[1]");
        public static By Shiftpopup = By.Id("mat-dialog-1");
        public static By selectalldays = By.XPath("//span[contains(text(),'Select All')]");
        public static By fromDropdown = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-add-edit-shift/div/div[2]/div[3]/div/div[1]/div/div/ng-select/div/div/div[2]/input");
        public static By fromtime = By.XPath("//span[contains(text(),'00:00')]");
        public static By toTimeDropdown = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-add-edit-shift/div/div[2]/div[3]/div/div[2]/div/div/ng-select/div/div/div[2]/input");
        public static By toTime = By.XPath("//*[@class='ng-option ng-option-selected ng-star-inserted ng-option-marked']/div/span[contains(text(),'06:00')]");
        public static By copytoProposed = By.XPath("//span[contains(text(),'Copy over to Proposed')]");
        public static By saveShiftPopup = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-add-edit-shift/div/div[3]/div/button[1]");
        public static By dropdownmenu = By.XPath("//div[@class='ng-option ng-star-inserted']");
        public static By Todropdownmenu = By.XPath("//div[@id='a1c36111a55b']");
        public static By importshiftbtn = By.XPath("//li[1]//button[1]//img[1]");
        public static By ShiftImportPhyCheckbox = By.XPath("//label[@class='label-checkbx d-inline-block mb-1']//span[contains(text(),'Physician')]");
        public static By ShiftImportAPPCheckbox = By.XPath("//label[@class='label-checkbx d-inline-block mb-1']//span[contains(text(),'APP')]");
        public static By ShiftImportScribeCheckbox = By.XPath("//span[contains(text(),'Scribe')]");
        public static By shiftDatePickerBtn = By.XPath("//div[contains(@class,'col-sm-6')]//div//span[contains(@class,'mat-button-wrapper')]");
            //("//button[@class='mat-icon-button'][@tabindex='0']");
            //("//button[@class='mat-icon-button']");
        public static By ShiftRetrieve = By.XPath("//button[@class='btn btn-primary btn-retrive']");
        public static By Shift_OKbtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-shift-table[1]/div[1]/div[1]/div[3]/div[1]/mat-dialog-actions[1]/button[1]");
        


        //public static By importshiftbtn = By.XPath("//li[1]//button[1]//img[1]");
        //public static By ShiftImportPhyCheckbox = By.XPath("//label[@class='label-checkbx d-inline-block mb-1']//span[contains(text(),'Physician')]");
        //public static By ShiftImportAPPCheckbox = By.XPath("//label[@class='label-checkbx d-inline-block mb-1']//span[contains(text(),'APP')]");
        //public static By ShiftImportScribeCheckbox = By.XPath("//span[contains(text(),'Scribe')]");
        //public static By shiftDatePickerBtn = By.XPath("//button[@class='mat-icon-button'][@tabindex='0']");
        ////("//button[@class='mat-icon-button']");
        //public static By ShiftRetrieve = By.XPath("//button[@class='btn btn-primary btn-retrive']");
        //public static By arrivaldata_dropdown_Import = By.XPath("//li[contains(text(),'Import Data')]");
        //public static By arrivaldata_dropdown_datepicker = By.XPath("//*[@id='mat-dialog-1']/app-import-data/div/div[2]/div/div[1]/div/mat-form-field/div/div[1]/div[2]/mat-datepicker-toggle/button");

        //public static By Calendar_yeararrow = By.XPath("//div[@class='mat-calendar-arrow']");
        //public static By Calendar_dropdown_year = By.XPath("//mat-multi-year-view[@class='ng-star-inserted']//table//tbody//tr/td[3]/div[contains(text(),'2018')]");
        //public static By Calendar_dropdown_month = By.XPath("//div[contains(text(),'JAN')]");
        //public static By Calendar_dropdown_day = By.XPath("//div[contains(text(),'14')]");

        //clinician productivity

        public static By clinicianprod_tab = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/ul/li[5]/a");
        public static By main_phy_pph = By.XPath("//input[@id='targetedPphValue-1']");
        public static By main_app_pph = By.XPath("//input[@id='appCoefficientValue-1']");

        //ft
        public static By FtTab = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-input[1]/div[1]/div[2]/tabset[1]/div[1]/tab[5]/app-clinicianproductivity[1]/div[1]/div[1]/div[1]/div[1]/mat-tab-group[1]/mat-tab-header[1]/div[2]/div[1]/div[1]/div[2]/div[1]");
            //("//div[@class ='mat-tab-label mat-ripple ng-star-inserted'][contains(@id,'mat-tab-content-1']");
        public static By FT_Phy_pph = By.XPath("//input[@id='targetedPphValue0']");
        public static By FT_App_PPH = By.XPath("//input[@id='appCoefficientValue0']");
        public static By FT_segment_Tab = By.XPath("//*[@id=\"mat-tab-label-2-1\"]");
        public static By FT_PhyfirstHour = By.XPath("//input[@id='firsthourpph0']");
        public static By FT_AppfirstHour = By.XPath("//input[@id='appfirsthourpph0']");

        // PIT

        public static By PitTab = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-input[1]/div[1]/div[2]/tabset[1]/div[1]/tab[5]/app-clinicianproductivity[1]/div[1]/div[1]/div[1]/div[1]/mat-tab-group[1]/mat-tab-header[1]/div[2]/div[1]/div[1]/div[3]/div[1]");
            //("//div[@class ='mat-tab-label mat-ripple ng-star-inserted'][contains(@id,'mat-tab-label-content-2')]");
	    public static By PIT_Phy_pph = By.XPath("//input[@id='targetedPphValue1']");
        public static By PIT_App_PPH = By.XPath("//input[@id='appCoefficientValue1']");
        public static By PIT_segment_Tab = By.XPath("//div[@id='mat-tab-label-2-2']");
        public static By PIT_PhyfirstHour = By.XPath("//input[@id='firsthourpph1']");
        public static By PIT_AppFirstHour = By.XPath("//input[@id='appfirsthourpph1']");

        // shift segment

        public static By main_PhyFirstHour = By.XPath("//input[@id='firsthourpph-1']");
        public static By main_phylasstHour = By.XPath("//input[@id='lasthourpph-1']");
        public static By main_appFirstHour = By.XPath("//input[@id='appfirsthourpph-1']");
        public static By main_applasstHour = By.XPath("//input[@id='applasthourpph-1']");


        // clinical cost

        public static By clinicalCost_tab = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/ul/li[6]/a");
        public static By Cost_Per_Phy_Hour = By.XPath("//div[@class='row clinician-sec-rows']//div[1]//div[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Cost_Per_App_Hour = By.XPath("//tab[@class='tab-pane active']//div[2]//div[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Cost_Per_Scribe_Hour = By.XPath("//tab[@class='tab-pane active']//div[3]//div[1]//div[1]//div[1]//div[1]//input[1]");


        //Edit Model Details

        public static By EditEDUModelDetails = By.XPath("//td[@class='model-name mat-cell cdk-column-ModelName mat-column-ModelName ng-star-inserted']//sub[contains(text(),'(Educational)')][1]//following::td[5]//button[3]");
        public static By EditModelDetails = By.XPath("//td[@class='model-name mat-cell cdk-column-ModelName mat-column-ModelName ng-star-inserted']//sub[contains(text(),'(Operational)')]//following::td[5]//button[3]");
        public static By EMD_ModelName = By.XPath("//input[@placeholder='modelName']");
        public static By EMD_ModelType_Selected = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-edit-model-dialog/div/div[2]/div[2]/div/div/ng-select/div/div/div[2]/span[2]");
        public static By EMD_Modeltype = By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/mat-dialog-container[1]/app-edit-model-dialog[1]/div[1]/div[2]/div[2]/div[1]/div[1]/ng-select[1]/div[1]/div[1]/div[3]/input[1]");
        public static By EMD_Modeltype_private = By.XPath("//span[@class='ng-option-label ng-star-inserted'][contains(text(),'Private')]");
        public static By EMD_Modeltype_public = By.XPath("//span[@class='ng-option-label ng-star-inserted'][contains(text(),'Public')]");
        public static By EMD_ModeCategory_Operational = By.XPath("//span[contains(text(),'Set Model as Current Operational/Deployed model')]");
        public static By EMD_ModelCategory_Edu = By.XPath("//span[contains(text(),'Set Model as Educational or Test model')]");
        public static By EMD_Modeldetails_Save = By.XPath("/html[1]/body[1]/div[2]/div[2]/div[1]/mat-dialog-container[1]/app-edit-model-dialog[1]/div[1]/div[3]/div[1]/button[1]");
        public static By Updatedmodelname = By.XPath("/html/body/app-root/div/div/div/app-dashboard/div/div[2]/app-dashboard-model-list/div/table/tbody/tr[2]/td[1]");
        public static By Updatedmodeltype = By.XPath("/html/body/app-root/div/div/div/app-dashboard/div/div[2]/app-dashboard-model-list/div/table/tbody/tr[2]/td[5]");
        
        //Save

        public static By save = By.XPath("//i[@id='saveBtn']"); 
        public static By savepopup = By.XPath("//mat-dialog-container[@id='mat-dialog-4']");
        public static By modelName = By.XPath("//input[@placeholder='Enter Model Name']");
        public static By modelSave = By.XPath("//button[@id='popupSaveBtn']");
        public static By Yesbtn = By.XPath("//button[contains(text(),'Yes')]");
        public static By OK = By.XPath("//button[contains(text(),'OK')]");
        public static By Ok_Req = By.XPath("//button[@class='btn btn-primary ng-star-inserted']");
        public static By op_model_verification = By.XPath("//div[contains(text(),'Set Model Operational')]");




        // Next and previous 

        public static By PM_next = By.XPath("//div[2]/tabset/div/tab[1]/div/div/span");
        public static By ESI_next = By.XPath("//div[2]/tabset/div/tab[2]/div/div[2]/span");
        public static By lengthofstay_next = By.XPath("//div[2]/tabset/div/tab[3]/div/div[2]/span");
        public static By shifts_next = By.XPath("//div[2]/tabset/div/tab[4]/div[1]/div[2]/span");
        public static By clinicianpro_next = By.XPath("//div[2]/tabset/div/tab[5]/div/div[2]/span");
        public static By clinicianco_next = By.XPath("//div[2]/tabset/div/tab[5]/div/div[2]/span");

        //Graph
        public static By D_graphtooltip = By.CssSelector("#Hourly > svg > g.dxc-series-group > g:nth-child(1) > g > rect:nth-child(1)");
        public static By D_hr_graphbarone = By.XPath("//*[@id='Hourly']/svg/g[8]/g[1]/g/rect[3]");


        //Create model using Wizard
               
        public static By clkcreatemodel = By.XPath("//a[contains(text(),'Create Model')]");

        public static By createmodelusingwizardbtn = By.XPath("//mat-dialog-container[starts-with (@id,'mat-dialog-')]/app-create-model-dialog/div/div[2]/ul/li[1]/a");                                                  
        public static By ForecastedAnnualArrivals = By.XPath("//div[contains(text(),'What is the Forecasted Annual Arrivals (walkouts i')]//following::div/input");
        public static By Invalidinput_popup = By.XPath("//mat-dialog-container[@id='mat-dialog-11']");
        public static By Invalidinput_popupOK = By.XPath("//button[@class='btn btn-primary']");
        public static By currentwalkoutpercentage = By.XPath("/html/body/app-root/div/div/div/app-wizard/div/div/div/div[3]/div[2]/input");
        public static By addmittedpatientspercentage = By.XPath("//div[@class='qaModule pb-2 ng-star-inserted']//div[3]//input[1]");
        public static By Forecastedannualvolume = By.XPath("//b[contains(text(),'')]");
        public static By databenchmarkingaverage = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[3]");
        public static By enterdatamanually = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[2]");
        public static By importdata = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[5]/div[1]/ul[1]/li[1]");
        public static By arrivalspopup = By.Id("mat-dialog-5");
        public static By arrivals_missingdataalert = By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/mat-dialog-container[1]/alert-message[1]/div[1]/div[3]/div[1]/mat-dialog-actions[1]/button[1]");
        public static By Arrivals_OKbtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-arrivals-hourly-monthly-prepopulated[1]/div[1]/div[1]/div[3]/div[1]/mat-dialog-actions[1]/button[1]");
        public static By clktoviewarrivals = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[4]");
        public static By ESI_databenchmarking = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[6]/div/ul/li[2]");
        public static By ESI_entermanually = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[6]/div[1]/ul[1]/li[1]");
        public static By FT_ESI_entermanually = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[20]/div[1]/div[2]/div[1]/ul[1]/li[1]");
        public static By ESI_1 = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-arrivals-esi[1]/div[1]/div[1]/div[2]/app-segmentation-esi-levels[1]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]");
        public static By ESI_2 = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-arrivals-esi[1]/div[1]/div[1]/div[2]/app-segmentation-esi-levels[1]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[3]/div[1]/div[1]/input[1]");
        public static By ESI_3 = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-arrivals-esi[1]/div[1]/div[1]/div[2]/app-segmentation-esi-levels[1]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[4]/div[1]/div[1]/input[1]");
        public static By ESI_4 = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-arrivals-esi[1]/div[1]/div[1]/div[2]/app-segmentation-esi-levels[1]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[5]/div[1]/div[1]/input[1]");
        public static By ESI_5 = By.XPath("//input[@id='mainesi5']");
        public static By ESI_OKbtn = By.XPath("//button[@class='btn btn-primary']");
        public static By clktoviewESI = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[6]/div/ul/li[3]");
        public static By LOSforaddmittedpatients = By.XPath("//div[contains(text(),'What is the Length of Stay (in minutes) for Admitt')]//following::div/input");
        public static By LOSdischargedpatients = By.XPath("//div[contains(text(),'What is the Length of Stay (in minutes) for Discha')]//following::div/input");
        public static By LOSArrivaltoadmitdecisiontime = By.XPath("//div[contains(text(),'What is your Arrival to Admit Decision time (in mi')]//following::div/input");
        public static By Shft_entermanually = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[10]/div/ul/li[2]");
        public static By Shift_import = By.XPath("/html/body/app-root/div/div/div/app-wizard/div/div/div/div[10]/div/ul/li[1]");
        public static By Shft_popup = By.Id("mat-dialog-4");
        public static By Shft_Addbtn = By.XPath("//li[2]//button[1]");
        public static By Shft_Addeditpopup = By.XPath("//mat-dialog-container[@id='mat-dialog-5']");
        public static By Shft_Selectallchkbx = By.XPath("//span[contains(text(),'Select All')]");
        public static By Shft_currentFromdd = By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/mat-dialog-container[1]/app-add-edit-shift[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/ng-select[1]/div[1]/div[1]/div[2]/input[1]");
        public static By shft_selectcurrentfromtime = By.XPath("//span[contains(text(),'01:30')]");
        public static By Shft_currentTodd = By.XPath("//*[starts-with(@id,'mat-dialog')]/app-add-edit-shift/div/div[2]/div[3]/div/div[2]/div/div/ng-select/div/div/div[2]/input");
        public static By shft_selectcurrenttotime = By.XPath("//span[contains(text(),'18:00')]");
        public static By Shft_proposedFromdd = By.XPath("//div[@class='pt-4 border-bottom pb-4']//div[@class='row center-align mt-1']//div[1]//div[1]//div[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
        public static By shft_selectproposedfromtime = By.XPath("//span[contains(text(),'05:00')]");
        public static By Shft_proposedTodd = By.XPath("//div[@class='pt-4 border-bottom pb-4']//div[2]//div[1]//div[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
        public static By shft_selectproposedtotime = By.XPath("//span[contains(text(),'19:00')]");
        public static By Shft_copytoprpsdchkbx = By.XPath("//span[contains(text(),'Copy over to Proposed')]");

        public static By Shft_txtduplicateshifts = By.XPath("//*[starts-with(@id,'mat-dialog')]/app-add-edit-shift/div/div[2]/div[6]/div[1]/div/div/input");

        public static By Shft_Addscribeshiftchkbx = By.XPath("//span[contains(text(),'Add Scribe shift')]");

        public static By Shft_Savebtn = By.XPath("//button[contains(text(),'Save')]");
        public static By Shft_cancelbtn = By.XPath("//button[@class='btn btn-danger']");
        public static By shft_12houeswarning_Yes = By.XPath("//*[starts-with(@id,'mat-dialog')]/app-shiftswarning/div/div[3]/div/button[1]");
        public static By Shft_popupOKbtn = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-shift-table[1]/div[1]/div[1]/div[3]/div[1]/mat-dialog-actions[1]/button[1]");
        
        public static By Avgcostperphyhour = By.XPath("//div[contains(text(),'What is your average cost (in dollars) per Physici')]//following::div/input");

        public static By AvgcostperAPPhour = By.XPath("//div[contains(text(),'If you use Advanced Practice Providers (APPs), wha')]//following::div/input");

        public static By scribecost_lnkcontinue = By.XPath("//li[contains(text(),'No, I want to continue with the default average co')]");
        public static By scribecost_lnkchangeavecst = By.XPath("//li[contains(text(),'Yes, I want to change the average cost per Scribe')]");
        public static By scribecost_txtbxchangecost = By.XPath("//input[@class='ans-sec w-100 ng-pristine ng-valid ng-touched']");
        public static By Phy_patientsperhour = By.XPath("//div[contains(text(),'How many patients does your Physicians see per hou')]//following::div/input");
        public static By APP_patientsperhour = By.XPath("//div[contains(text(),'How many patients does your APPs see per hour (PPH')]//following::div/input");
        public static By APP_Coefficient = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[16]/div[2]/ul[1]/li[2]");

        public static By Scribecoefficient_lnkcontinue = By.XPath("//li[contains(text(),'No, I want to continue with the default Scribe coe')]");
        public static By Scribecoefficient_lnkchangevalue = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[16]/div[2]/ul[1]/li[1]");

        public static By Scribecoefficient_txtbxchangevalue = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[16]/div[3]/div[1]/input[1]");

        public static By Phy_firsthour = By.XPath("//div[contains(text(),'Do your Physicians have a higher than average PPH')]//following::div/input");
        public static By App_firsthour = By.XPath("//div[contains(text(),'Do your APPs have a higher than average PPH during')]//following::div/input");

        public static By Lnknothatsall = By.XPath("//div[19]//div[1]//ul//li[1]");
        public static By FT_Lnknothatsall = By.XPath("//div[@class='areaGroup']//div[10]//div//ul//li[1]");
        
        public static By LnkFasttrack = By.XPath("//div[contains(text(),'Are there any other areas in your Emergency Depart')]//following::ul/li[2]");
        public static By FT_Hours = By.XPath("//div[@class='areaGroup']//div[@class='qaModule pb-2']//div[1]//following::div/input");
        public static By FT_ESI = By.XPath("//div[@class='qaModule p-1 ng-star-inserted']//li[@class='nav-item pl-2 pr-2'][contains(text(),'I'd like to enter the data manually')]");
        public static By FT_ESI3 = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-wizard-arrivals-esi[1]/div[1]/div[1]/div[2]/app-segmentation-esi-levels[1]/div[1]/div[2]/table[2]/tbody[1]/tr[2]/td[4]/div[1]/div[1]/input[1]");
        public static By FT_LOS = By.XPath("//div[@class='areaGroup']//div[3]//div[2]//input[1]");
        public static By FT_ShiftManually = By.XPath("//div[@class='areaGroup']//div[4]//div//ul//li[2]");
        public static By FT_Shift = By.XPath("//div[@class='mat-tab-label-content'][contains(text(),'Fast Track')]");
        public static By FT_PHY_PPH = By.XPath("//div[@class='areaGroup']//div[5]//div[2]//input");
        public static By FT_APP_PPH = By.XPath("//div[@class='areaGroup']//div[6]//div[2]//input");
        public static By FT_Scribe_Cooff_Cont = By.XPath("//div[@class='areaGroup']//div[7]//div[2]//ul//li[2]");
        public static By FT_PHY_FirstHour = By.XPath("//div[@class='areaGroup']//div[8]//div[3]/input");
        public static By FT_APP_FirstHour = By.XPath("//div[@class='areaGroup']//div[9]//div[3]/input");

        public static By ClinicalWorkDistribution_popup = By.XPath("//mat-dialog-container[@id='mat-dialog-6']");
        public static By ClinicalWorkDistribution_popupOKbtn = By.XPath("//button[@class='btn btn-primary']");

        public static By Requiredwarningpopup = By.XPath("//mat-dialog-container[@id='mat-dialog-7']");
        public static By Requiredfields_OK = By.XPath("//button[contains(text(),'OK')]");

        public static By Requiredwarningpopup_save = By.XPath("//button[@class='btn btn-primary ng-star-inserted']");
        public static By Requiredwarningpopup_cancel = By.XPath("//button[contains(@class,'btn btn-danger')]");

        public static By Savemodel_popup = By.XPath("//mat-dialog-container[@id='mat-dialog-9']");

        public static By Successpopup_Ok = By.XPath("//*[starts-with(@id,'mat-dialog')]/inputsavealertdialog/div/div[3]/div/mat-dialog-actions/button");

        //*[@id="mat-dialog-8"]




        //View Analysis


        public static By ViewAnalysis_Tab = By.XPath("//a[contains(text(),'View Analysis')]");
        public static By PV_MA_ForcastedMonthlyArrival_Jan = By.XPath("//div[@class='forecasted-monthly-arrival-data pt-4']//label[@class='d-block m-0'][contains(text(),'JAN')]/following::input[1]");
        public static By PV_MA_ActualMonthlyArrival_Jan = By.XPath("//div[@class='actual-monthly-arrival-data pt-4']//label[@class='d-block m-0'][contains(text(),'JAN')]/following::input[1]");
        
       

            // Weekly Arriaval

        public static By Weekly_ArrivalTab = By.XPath("//div[@id='mat-tab-label-2-1']");
        public static By PV_WA_EachDayofWeek_Sun = By.XPath("//tab[@class='active tab-pane']//td[1]//label[contains(text(),'SUN')]/following::input[1]");



        //logout

        public static By Logout = By.XPath("//span[@class='userName']");
        public static By Signout = By.XPath("//a[@class='dropdown-item']");
        public static By Oktalogout = By.XPath("//span[@class='option-selected-text']");
        public static By OktaSignout = By.XPath("//p[contains(text(),'Sign out')]");

        

    }
}
