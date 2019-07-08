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
        public static By firstmodelname = By.XPath("//div[contains(@class,'dashTitleBar move-tooltip-right white-space')]");


        //Operational model history

        public static By OpModelHistory = By.XPath("//div[@class='model-history ml-2']");
        public static By currentmodelhistory = By.XPath("//body/div[@class='cdk-overlay-container']/div[@class='cdk-global-overlay-wrapper']/div[@id='cdk-overlay-0']/mat-dialog-container[@id='mat-dialog-0']/app-operational-model-history[@class='ng-star-inserted']/div[@class='dialog-box']/div[@class='dialog-box-content pb-5 pl-4 pr-4']/div[@class='ng-star-inserted']/div[@class='table-responsive']/table[@class='table']/tbody/tr[1]/td");
        public static By Previouslastmodel = By.XPath("//body//div[@class='ng-star-inserted']//div[@class='ng-star-inserted']//tr[1]/td[1]");
        public static By Previous2ndlastmodel = By.XPath("//div[@class='cdk-overlay-container']//tr[2]//td[1]");
        public static By Previous3rdlastmodel = By.XPath("//div[@class='cdk-overlay-container']//tr[3]//td[1]");
        public static By OKbtn = By.XPath("//button[@class='btn btn-primary']");

        // dashboard graph

        public static By selectGraphDropdown = By.XPath("//ng-select[@class='select-medium ng-select-field ng-select ng-select-single ng-select-searchable ng-untouched ng-pristine ng-valid ng-select-opened ng-select-bottom']//input");

        //floor plan
        public static By FloorPlan = By.XPath("//div[@class='floorplan']");
        public static By viewFloorPlan = By.XPath("//span[@class='floor-view floor-btn']");
        public static By deleteFloorPlan = By.XPath("//span[@class='floor-del floor-btn']");
        public static By uploadFloorPlanbtn = By.XPath("//button[@class='btn btn-upld ng-star-inserted']");
        public static By cancelnobtn = By.XPath("//button[@class='btn btn-danger']");
        public static By floorplanName = By.XPath("//ul[@class='floor-list']//li[1]//div[1]//div[1]//span[1]");

        //logout

        public static By Logout = By.XPath("//span[@class='userName']//div//a//i");


    }
}
