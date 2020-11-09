using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodedUITestGoContact.Base;
using OpenQA.Selenium;
using static CodedUITestGoContact.Base.Constants;
using System.Threading;

namespace CodedUITestGoContact.Funcionalities
{
    /// <summary>
    /// Summary description for CheckSiteGitHubOpen
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class GitHubSiteWithoutErrorsInCookiesMessage
    {
        public GitHubSiteWithoutErrorsInCookiesMessage()
        {
        }

        [TestMethod]
        public void CheckIfCookiesMessageAsNoErrors()
        {
            try
            {
                // Wait 1.5 seconds to the page be fully loaded
                Thread.Sleep(1500);

                // Find the element that has de cookies message
                IWebElement objElem;
                objElem = GlobalVariables.objDriver.FindElement(ActionsOnElements.ReturnTypeOFCall(TypeOfCall.ByXPath, "/html/body/div[8]/div/div/div/div[1]/div/p"));
                if (objElem.Displayed)
                {
                    // Check if the test for aceptance of cookies is correct
                    if (!objElem.Text.Equals(CodedUITestGoContact.Properties.Resources.CookiesMessage))
                    {
                        Assert.Fail("The message related with cookies is not correct!");
                    }
                    else
                    {
                        // Click in acept button
                        objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[8]/div/div/div/div[1]/div/div/button[1]", ActionToExecute.Click);
                    }
                }
                else
                {
                    Assert.Fail("The message related with cookies is not been show!");
                }

            }
            catch (OpenQA.Selenium.WebDriverException e)
            {
                Assert.Fail(e.Message);
            }
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            // Open browser
            ActionsBeginEndTest.OpenBrowser(false);

        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            // Close the browser
            ActionsBeginEndTest.CloseBrowser();
        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
