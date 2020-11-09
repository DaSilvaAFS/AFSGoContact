using CodedUITestGoContact.Base;
using OpenQA.Selenium;
using System.Threading;

namespace CodedUITestGoContact.Base
{
    public static class AddValueToElements
    {
        public static IWebElement AddValue_ByXPath(string inAtribute, string inValue)
        {
            var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(inAtribute)));
            FillElement(objElem, inValue);
            return objElem;
        }

        public static IWebElement AddValue_ByID(string inID, string inValue)
        {
            var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(inID)));
            FillElement(objElem, inValue);
            return objElem;
        }
        public static IWebElement Addvalue_ByName(string inName, string inValue)
        {
            var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(inName)));
            FillElement(objElem, inValue);
            return objElem;
        }
        public static IWebElement AddValue_ByClass(string inClass, string inValue)
        {
            var objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(inClass)));
            FillElement(objElem, inValue);
            return objElem;
        }

        private static void FillElement(IWebElement inOBJElem, string inValue)
        {
            if (inOBJElem.Displayed)
            {
                var objElemClicavel = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(inOBJElem));
                if (objElemClicavel.Enabled)
                {
                    inOBJElem.Clear();
                    GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(inOBJElem, ""));
                    inOBJElem.SendKeys(inValue);
                    GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(inOBJElem, inValue));
                    inOBJElem.SendKeys(Keys.Tab);
                }
            }
        }
    }
}
