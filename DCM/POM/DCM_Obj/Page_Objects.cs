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




        //floor plan
        public static By FloorPlan = By.XPath("//div[@class='floorplan']");
        public static By viewFloorPlan = By.XPath("//span[@class='floor-view floor-btn']");
        public static By deleteFloorPlan = By.XPath("//li[1]//div[1]//div[3]//span[1]//i[1]");
        public static By uploadFloorPlanbtn = By.XPath("//button[@class='btn btn-upld ng-star-inserted']");
        public static By cancelnobtn = By.XPath("//button[@class='btn btn-danger']");
        public static By floorplanName = By.XPath("//ul[@class='floor-list']//li[1]//div[1]//div[1]//span[1]");

        //create Model
        public static By Appname = By.XPath("//div[@class='d-inline mr-2']");
        public static By createModelTab = By.XPath("//a[contains(text(),'Create Model')]");
        public static By createModelFreeForm = By.XPath("//a[contains(text(),'Create Model using Free Form')]");
        public static By createModelPopUp = By.XPath("//*[@id='mat-dialog-1']");

        //Practice Metrics

        public static By additem = By.XPath("//span[@class='add-items']");
        public static By area2 = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[1]/app-practice-metrics/div/div/div/div/div[1]/div[2]/div/div/input");
        public static By area3 = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[1]/app-practice-metrics/div/div/div/div/div[1]/div[3]/div/div/input");
        public static By F_Annual_arrivals = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[1]/app-practice-metrics/div/div/div/div/div[2]/div[1]/div/div/div/input");
        public static By LWBS = By.XPath("//div[@class='col-sm-5 offset-sm-1']//div[2]//div[1]//div[1]//div[1]//input[1]");
        public static By F_Annual_Voulme = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[1]/app-practice-metrics/div/div/div/div/div[2]/div[3]/div/div/div/input");
        public static By admitPercentage = By.XPath("//tab[@class='active tab-pane']//div[4]//div[1]//div[1]//div[1]//input[1]");


        //Arrival/ESI

        public static By arrivaldata_dropdown = By.XPath("//*[@id=\"arrivals-data\"]/div/div[1]/div/div/div[1]");
        public static By arrivaldata_dropdown_value = By.XPath("//*[@id=\"arrivals-data\"]/div/div[1]/div/div/div[2]/ul/li[2]");
        public static By segmentation_by_ESI_dropdown = By.XPath("//*[@id=\"segmentation-data\"]/div[1]/div/div/div");
        public static By segmentation_by_ESI_value = By.XPath("//*[@id=\"segmentation-data\"]/div[1]/div/div/div[2]/ul/li[1]");
        public static By ESI3_FT = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[2]/td[4]/div/div/input");
        public static By ESI3_PIT = By.XPath("//*[@id=\"segmentation-data\"]/div[2]/table[2]/tbody/tr[3]/td[4]/div/div/input");


        //length of stay

        public static By lengthofstay_tab = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/ul/li[3]/a/span");
        public static By Admit_LOS = By.XPath("//div[@class='col-sm-5']//div[1]//div[1]//div[1]//div[1]//input[1]");
        public static By Admit_Decision = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[3]/app-lengthofstay/div/div/div/div/div[1]/div[2]/div/div/div/input");
        public static By Discharge_Los = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[3]/app-lengthofstay/div/div/div/div/div[2]/div[1]/div/div/div/input");
        public static By FT_Discharge_Los = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[3]/app-lengthofstay/div/div/div/div/div[2]/div[2]/div/div/div/input");
        public static By PIT_Discharge_Los = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/div/tab[3]/app-lengthofstay/div/div/div/div/div[2]/div[3]/div/div/div/input");

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


        //clinician productivity

        public static By clinicianprod_tab = By.XPath("/html/body/app-root/div/div/app-input/div/div[2]/tabset/ul/li[5]/a");
        public static By main_phy_pph = By.XPath("//input[@id='targetedPphValue-1']");
        public static By main_app_pph = By.XPath("//input[@id='appCoefficientValue-1']");

        //ft
        public static By FtTab = By.XPath("//div[@class ='mat-tab-label mat-ripple ng-star-inserted'][@id='mat-tab-label-1-1']");
        public static By FT_Phy_pph = By.XPath("//input[@id='targetedPphValue0']");
        public static By FT_App_PPH = By.XPath("//input[@id='appCoefficientValue0']");
        public static By FT_segment_Tab = By.XPath("//*[@id=\"mat-tab-label-2-1\"]");
        public static By FT_PhyfirstHour = By.XPath("//input[@id='firsthourpph0']");
        public static By FT_AppfirstHour = By.XPath("//input[@id='appfirsthourpph0']");

        // PIT

        public static By PitTab = By.XPath("//div[@class ='mat-tab-label mat-ripple ng-star-inserted'][@id='mat-tab-label-1-2']");
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

        public static By EditModelDetails = By.XPath("//tr[2]//td[6]//button[3]");
        public static By EMD_ModelName = By.XPath("//input[@placeholder='modelName']");
        public static By EMD_ModelType_Selected = By.XPath("//*[starts-with(@id,'mat-dialog-')]/app-edit-model-dialog/div/div[2]/div[2]/div/div/ng-select/div/div/div[2]/span[2]");
        public static By EMD_ModeCategory_Operational = By.XPath("//span[contains(text(),'Set Model as Current Operational/Deployed model')]");
        public static By EMD_ModelCategory_Edu = By.XPath("//span[contains(text(),'Set Model as Educational or Test model')]");


        //Save

        public static By save = By.XPath("//i[@id='saveBtn']");
        public static By savepopup = By.XPath("//mat-dialog-container[@id='mat-dialog-4']");
        public static By modelName = By.XPath("//input[@placeholder='Enter Model Name']");
        public static By modelSave = By.XPath("//button[@id='popupSaveBtn']");
        public static By Yesbtn = By.XPath("//button[contains(text(),'Yes')]");




        // Next and previous 

        public static By PM_next = By.XPath("//div[2]/tabset/div/tab[1]/div/div/span");
        public static By ESI_next = By.XPath("//div[2]/tabset/div/tab[2]/div/div[2]/span");
        public static By lengthofstay_next = By.XPath("//div[2]/tabset/div/tab[3]/div/div[2]/span");
        public static By shifts_next = By.XPath("//div[2]/tabset/div/tab[4]/div[1]/div[2]/span");
        public static By clinicianpro_next = By.XPath("//div[2]/tabset/div/tab[5]/div/div[2]/span");
        public static By clinicianco_next = By.XPath("//div[2]/tabset/div/tab[5]/div/div[2]/span");

        //Graph
        public static By D_graphtooltip = By.CssSelector("#Hourly > svg > g.dxc-series-group > g:nth-child(1) > g > rect:nth-child(1)");
        public static By D_hr_graphbarone = By.XPath("//*[@class='dxc-series-group']//rect");


        //Create model using Wizard
               
        public static By clkcreatemodel = By.XPath("//a[contains(text(),'Create Model')]");

        public static By createmodelusingwizardbtn = By.XPath("//mat-dialog-container[starts-with (@id,'mat-dialog-')]/app-create-model-dialog/div/div[2]/ul/li[1]/a");                                                  
        public static By ForecastedAnnualArrivals = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[2]/div[2]/input");
        public static By Invalidinput_popup = By.XPath("//mat-dialog-container[@id='mat-dialog-11']");
        public static By Invalidinput_popupOK = By.XPath("//button[@class='btn btn-primary']");
        public static By currentwalkoutpercentage = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[3]/div[2]/input");
        public static By addmittedpatientspercentage = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[4]/div[3]/input");
        public static By databenchmarkingaverage = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[3]");
        public static By enterdatamanually = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[2]");
        public static By importdata = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[1]");
        public static By arrivalspopup = By.Id("mat-dialog-5");
        public static By clktoviewarrivals = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[5]/div/ul/li[4]");
        public static By ESI_databenchmarking = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[6]/div/ul/li[2]");
        public static By ESI_entermanually = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[6]/div/ul/li[1]");
        public static By clktoviewESI = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[6]/div/ul/li[3]");
        public static By LOSforaddmittedpatients = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[7]/div[2]/input[1]");
        public static By LOSdischargedpatients = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[8]/div[2]/input");
        public static By LOSArrivaltoadmitdecisiontime = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[9]/div[2]/input[1]");
        public static By Shft_entermanually = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[10]/div/ul/li[2]");
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
        public static By Shft_popupOKbtn = By.XPath("//*[starts-with(@id,'mat-dialog')]/app-wizard-shift-table/div/div/div[3]/div/mat-dialog-actions/button");
        
        public static By Avgcostperphyhour = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[11]/div[2]/input");

        public static By AvgcostperAPPhour = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[12]/div[2]/input[1]");

        public static By scribecost_lnkcontinue = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[13]/div/ul/li[2]");
        public static By scribecost_lnkchangeavecst = By.XPath("//li[contains(text(),'Yes, I want to change the average cost per Scribe')]");
        public static By scribecost_txtbxchangecost = By.XPath("//input[@class='ans-sec w-100 ng-pristine ng-valid ng-touched']");
        public static By Phy_patientsperhour = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[14]/div[2]/input[1]");
        public static By APP_patientsperhour = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[15]/div[2]/input[1]");
        public static By APP_Coefficient = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[16]/div[2]/ul[1]/li[2]");

        public static By Scribecoefficient_lnkcontinue = By.XPath("/html/body/app-root/div/div/app-wizard/div/div/div/div[16]/div[2]/ul/li[2]");
        public static By Scribecoefficient_lnkchangevalue = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[16]/div[2]/ul[1]/li[1]");

        public static By Scribecoefficient_txtbxchangevalue = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[16]/div[3]/div[1]/input[1]");

        public static By Phy_firsthour = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[17]/div[2]/input[1]");
        public static By App_firsthour = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[18]/div[2]/input[1]");

        public static By Lnknothatsall = By.XPath("/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-wizard[1]/div[1]/div[1]/div[1]/div[19]/div[1]/ul[1]/li[1]");

        public static By ClinicalWorkDistribution_popup = By.XPath("//mat-dialog-container[@id='mat-dialog-6']");
        public static By ClinicalWorkDistribution_popupOKbtn = By.XPath("//button[@class='btn btn-primary']");

        public static By Requiredwarningpopup = By.XPath("//mat-dialog-container[@id='mat-dialog-7']");

        public static By Requiredwarningpopup_save = By.XPath("//button[@class='btn btn-primary ng-star-inserted']");
        public static By Requiredwarningpopup_cancel = By.XPath("//button[contains(@class,'btn btn-danger')]");

        public static By Savemodel_popup = By.XPath("//mat-dialog-container[@id='mat-dialog-9']");

        public static By Successpopup_Ok = By.XPath("//*[starts-with(@id,'mat-dialog')]/inputsavealertdialog/div/div[3]/div/mat-dialog-actions/button");

        //*[@id="mat-dialog-8"]













        //logout

        public static By Logout = By.XPath("//span[@class='userName']");
        public static By Signout = By.XPath("//a[@class='dropdown-item']");


    }
}
