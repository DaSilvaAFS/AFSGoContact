using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using static CodedUITestGoContact.Base.Constants;

namespace CodedUITestGoContact.Base
{
    public class ActionsOnElements
    {
        #region ClickElement
            public static IWebElement Click_ByXPath(string inAtribute)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(inAtribute)));
            
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(inAtribute)));
                    if (objElemClicavel.Enabled)
                    {
                        objElemClicavel.Click();
                        return objElemClicavel;
                    }
                }
                return null;
            }
            public static IWebElement Click_ByID(string inID)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(inID)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(inID)));
                    if (objElemClicavel.Enabled)
                    {
                        objElemClicavel.Click();
                        return objElemClicavel;
                    }
                }
                return null;
            }
            public static IWebElement Click_ByName(string inName)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(inName)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(inName)));
                    if (objElemClicavel.Enabled)
                    {
                        objElemClicavel.Click();
                        return objElemClicavel;
                    }
                }
                return null;
            }
            public static IWebElement Click_ByClass(string inClass)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(inClass)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(inClass)));
                    if (objElemClicavel.Enabled)
                    {
                        objElemClicavel.Click();
                        return objElemClicavel;
                    }
                }
                return null;
            }
            public static IWebElement Click_ByInnerText(string inText)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(inText)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.LinkText(inText)));
                    if (objElemClicavel.Enabled)
                    {
                        objElemClicavel.Click();
                        return objElemClicavel;
                    }
                }
                return null;
            }
        #endregion

        #region DoubleClickElement
            public static IWebElement DoubleClick_ByXPath(string inAtribute)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(inAtribute)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(objElem));
                    if (objElemClicavel.Enabled)
                    {
                        Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                        acaoDClick.DoubleClick(objElem).Build().Perform();
                        return objElem;
                    }
                }
                return null;
            }
            public static IWebElement DoubleClick_ByID(string inID)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(inID)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(objElem));
                    if (objElemClicavel.Enabled)
                    {
                        Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                        acaoDClick.DoubleClick(objElem).Build().Perform();
                        return objElem;
                    }
                }
                return null;
            }
            public static IWebElement DoubleClick_ByName(string inName)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(inName)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(objElem));
                    if (objElemClicavel.Enabled)
                    {
                        Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                        acaoDClick.DoubleClick(objElem).Build().Perform();
                        return objElem;
                    }
                }
                return null;
            }
            public static IWebElement DoubleClick_ByClass(string inClass)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(inClass)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(objElem));
                    if (objElemClicavel.Enabled)
                    {
                        Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                        acaoDClick.DoubleClick(objElem).Build().Perform();
                        return objElem;
                    }
                }
                return null;
            }
            public static IWebElement DoubleClick_ByInnerText(string inText)
            {
                var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(inText)));
                if (objElem.Displayed)
                {
                    var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(objElem));
                    if (objElemClicavel.Enabled)
                    {
                        Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                        acaoDClick.DoubleClick(objElem).Build().Perform();
                        return objElem;
                    }
                }
                return null;
            }
        #endregion

        #region ElementStayInvisible
            public static bool WaitTillStayInvisible_ByXPath(string inAtribute)
            {
                return GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath(inAtribute)));
            }
            public static bool WaitTillStayInvisible_ByID(string inID)
            {
                return GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Id(inID)));
            }
            public static bool WaitTillStayInvisible_ByName(string inName)
            {
                return GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.Name(inName)));
            }
            public static bool WaitTillStayInvisible_ByClass(string inClass)
            {
                return GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(inClass)));
            }
            public static bool WaitTillStayInvisible_ByInnerText(string inText)
            {
                return GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.LinkText(inText)));
            }
        #endregion
      
        public static By ReturnTypeOFCall(string inTypeOfCall, string inValueCall)
        {
            switch (inTypeOfCall)
            {
                case TypeOfCall.ByID:
                    return By.Id(inValueCall);
                case TypeOfCall.ByXPath:
                    return By.XPath(inValueCall);
                case TypeOfCall.ByName:
                    return By.Name(inValueCall);
                case TypeOfCall.ByClass:
                    return By.ClassName(inValueCall);
                case TypeOfCall.ByInnerText:
                    return By.LinkText(inValueCall);
                default:
                    break;
            }
            return null;
        }
        public static void ExecuteAction(IWebElement objElem, int inAction)
        {
            var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(objElem));
            if (objElemClicavel.Enabled)
            {
                if (inAction == ActionToExecute.Click)
                {
                    Actions acaoClick = new Actions(GlobalVariables.objDriver);
                    acaoClick.Click(objElemClicavel).Build().Perform();
                }
                else if (inAction == ActionToExecute.DoubleClick)
                {
                    Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                    acaoDClick.DoubleClick(objElemClicavel).Build().Perform();
                }
            }
            else
            {
                // Executa 30 vezes a espera de 1 segundo
                for (int i = 0; i < 30; i++)
                {
                    // Espera 1 segundo
                    Thread.Sleep(1000);
                    if (objElemClicavel.Enabled)
                    {
                        if (inAction == ActionToExecute.Click)
                        {
                            Actions acaoClick = new Actions(GlobalVariables.objDriver);
                            acaoClick.Click(objElemClicavel).Build().Perform();
                        }
                        else if (inAction == ActionToExecute.DoubleClick)
                        {
                            Actions acaoDClick = new Actions(GlobalVariables.objDriver);
                            acaoDClick.DoubleClick(objElemClicavel).Build().Perform();
                        }
                        break;
                    }
                }
            }

        }
        public static IWebElement LocateAndExecuteActionForElement(string inTypeCall, string inValueCall, int inAction)
        {
            // ***************************************************************************************************
            // The porpose is to wait 30 seconds till the element saty available
            // ***************************************************************************************************

            // Declare and pull the element.
            IWebElement objElem;
            objElem = GlobalVariables.objDriver.FindElement(ActionsOnElements.ReturnTypeOFCall(inTypeCall, inValueCall));

            if (objElem.Displayed)
            {
                if (inAction != ActionToExecute.DontExecuteAction)
                {
                    ExecuteAction(objElem, inAction);
                }
            }
            else
            {
                // Execute 30 times the wait of 1 second
                for (int i = 0; i < 30; i++)
                {
                    // Wait 1 second
                    Thread.Sleep(1000);
                    objElem = GlobalVariables.objDriver.FindElement(ActionsOnElements.ReturnTypeOFCall(inTypeCall, inValueCall));
                    if (objElem.Displayed)
                    {
                        if (inAction != ActionToExecute.DontExecuteAction)
                        {
                            ExecuteAction(objElem, inAction);
                        }
                        break;
                    }
                }
            }

            return objElem;
        }

    }
}