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
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.IE;

namespace DCM.POM
{

    
    public  class MethodsAndActions 
    {


        
        

        public static void Type(string element, By element1)
        {
            try
            {
                Initialize.driver.FindElement(element1).SendKeys(element);
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
                Initialize.driver.FindElement(element1).Clear();
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
                Initialize.driver.FindElement(element).Click();
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
               if (!pageTitle.Equals(Initialize.driver.Title))
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


                WebDriverWait wait = new WebDriverWait(Initialize.driver, TimeSpan.FromSeconds(30));
                //IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(element));
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
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
            Initialize.driver.SwitchTo().Window(Initialize.driver.WindowHandles.Last());
        }

        public static bool IsElementPresent(By locator, string expectedText)
        {
            try { 
            IList<IWebElement> subelements = Initialize.driver.FindElements(locator);
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
                return Initialize.driver.FindElement(locator).Text;
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
            return Initialize.driver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + locator + "' was not found in current context page.");
                throw;
            }
        }

        public static void wait()
        {
            Initialize.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
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

        public static void Spacebar()
        {
            Actions builder = new Actions(Initialize.driver);
            builder.SendKeys(Keys.Space);
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
                IWebElement upload = Initialize.driver.FindElement(element);
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

        public static double FieldTextToDouble(By ele)
        {
           return Convert.ToDouble(FieldText(ele));
        }

        public static string FieldText(By ele)
        {

            var input = Initialize.driver.FindElement(ele).GetAttribute("value");
            return input;
            //IJavaScriptExecutor executor = (IJavaScriptExecutor)Initialize.driver;
            //return (String)executor.ExecuteScript("return $('" + ele + "').val();");



            //IWebElement demoDiv = Initialize.driver.FindElement(ele);

            //IJavaScriptExecutor executor = (IJavaScriptExecutor)Initialize.driver;

            //demoDiv.GetAttribute("innerHTML");
            //executor.ExecuteScript("return arguments[0].innerHTML", demoDiv);

            //demoDiv.GetAttribute("textContent");
            //executor.ExecuteScript("return arguments[0].textContent", demoDiv);

            //return Int32.Parse(demoDiv.ToString());

        }

        public static void JSExe(By element)
        {
            IWebElement element1 = Initialize.driver.FindElement(element);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Initialize.driver;
            executor.ExecuteScript("arguments[0].click()", element1);
        }


        public static void JSScroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Initialize.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

        }

        public static string Graphtooltip(By element, By element1)
        {
            var bar = Initialize.driver.FindElement(element);
            Actions builder = new Actions(Initialize.driver);

            builder.ClickAndHold().MoveToElement(bar);
            builder.MoveToElement(bar).Build().Perform();

            return GetText(element1);
        }

        public static void directlink(string url)
        {
            if (Initialize.driver == null)
            {


                if (FeatureContext.Current.FeatureInfo.Tags.Contains("chrome"))
                {
                    Initialize.driver = new ChromeDriver();

                }
                else if (FeatureContext.Current.FeatureInfo.Tags.Contains("IE"))
                {
                    Initialize.driver = new InternetExplorerDriver();

                }

            }


            Initialize.driver.Navigate().GoToUrl(url);
            Initialize.driver.Manage().Window.Maximize();
        }

        public static string Geturl()
        {
            String URL = Initialize.driver.Url;
            return URL;          
        }
        public static void closeBrowser()
        {
            Initialize.driver.Quit();
            Initialize.driver.Dispose();
        }

    }
}
