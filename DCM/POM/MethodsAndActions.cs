using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DCM.POM.DCM_Objects;
using OpenQA.Selenium.Remote;
using DCM.Specflow.Hooks;
using OpenQA.Selenium.Interactions;
using AutoIt;

namespace DCM.POM
{

    
    public  class MethodsAndActions 
    {


        
        

        public static void Type(string element, By element1)
        {
            try
            {
                Initialize.GetDriver().FindElement(element1).SendKeys(element);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element1 + "' was not found in current context page.");
                throw;
            }
        }

        public static void clear(By element1)
        {
            try
            {
                Initialize.GetDriver().FindElement(element1).Clear();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element1 + "' was not found in current context page.");
                throw;
            }
        }

        public static void click(By element)
        {
            try
            {
                Initialize.GetDriver().FindElement(element).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element + "' was not found in current context page.");
                throw;
            }
        }

        public void VerifyPage(string pageTitle)
        {
            try
            {
               if (!pageTitle.Equals(Initialize.GetDriver().Title))
                {
                    throw new InvalidOperationException("This page is not " + pageTitle + ". The title is: " + Initialize.driver.Title);
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + pageTitle + "' was not found in current context page.");
                throw;
            }
        }

        public static IWebElement WaitForElement(By element)
        {

            try
            {


                WebDriverWait wait = new WebDriverWait(Initialize.driver, TimeSpan.FromMinutes(3));
                //IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(element));
                wait.Until(ExpectedConditions.ElementIsVisible(element));
                return Initialize.driver.FindElement(element);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element + "' was not found in current context page.");
                throw;
            }

        }

        public static void movepointer()
        {
            Initialize.GetDriver().SwitchTo().Window(Initialize.GetDriver().WindowHandles.Last());
        }

        public static bool IsElementPresent(By locator, string expectedText)
        {
            try { 
            IList<IWebElement> subelements = Initialize.GetDriver().FindElements(locator);
            for (int i = 0; i < subelements.Count; i++)
            {

                //Console.Write(subelements[i].Text);

                if (subelements[i].Text == expectedText)
                {
                    Console.Write("Element Found " + subelements[i].Text);
                    return true;

                }

            }
            return false;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + locator + "' was not found in current context page.");
                throw;
            }
        }

        public static string GetText(By locator)
        {
            try
            {
                return Find(locator).Text;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + locator + "' was not found in current context page.");
                throw;
            }
        }

        public static IWebElement Find(By locator)
        {

            try { 
            WebDriverWait wait = new WebDriverWait(Initialize.driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return Initialize.GetDriver().FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + locator + "' was not found in current context page.");
                throw;
            }
        }

        public static void wait()
        {
            Initialize.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        public static void Enterkey(By ele)
        {
            Initialize.driver.FindElement(ele).SendKeys(Keys.Enter);
        }
        public static void TabKey()
        {
            Actions builder = new Actions(Initialize.driver);
            builder.SendKeys(Keys.Tab);
        }
        public static void elementToBeClickable(By element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Initialize.driver, TimeSpan.FromSeconds(15));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element + "' was not found in current context page.");
                throw;
            }
        }

        public static void upload(By element , string path)
        {
            try
            {
                IWebElement upload = Initialize.GetDriver().FindElement(element);
                upload.SendKeys(path);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + element + "' was not found in current context page.");
                throw;
            }
        }

        public static void uploadfile(string file, string winTitle, string idEditBox, string idBtnLoad)
        {

            AutoItX.Init();

            AutoItX.WinWait(winTitle);
            AutoItX.WinActivate(winTitle);

            AutoItX.ControlSetText(winTitle, "", idEditBox, file);
            AutoItX.ControlClick(winTitle, "", idBtnLoad);
        }

        public static string FieldText(By ele)
        {


            String elevalue = (String)((((IJavaScriptExecutor)Initialize.driver)).ExecuteScript("return arguments[0].value", Initialize.driver.FindElement(ele)));
            return elevalue;
            
        }

        public static void JSExe(By element)
        {
            IWebElement element1 = Initialize.driver.FindElement(element);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Initialize.driver;
            executor.ExecuteScript("arguments[0].click()", element1);
        }

    }
}
