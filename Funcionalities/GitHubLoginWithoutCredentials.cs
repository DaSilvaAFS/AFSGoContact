using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodedUITestGoContact.Base;
using OpenQA.Selenium;
using static CodedUITestGoContact.Base.Constants;

namespace CodedUITestGoContact.Funcionalities
{
    /// <summary>
    /// Summary description for CheckSiteGitHubOpen
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class GitHubLoginWithoutCredentials
    {
        public GitHubLoginWithoutCredentials()
        {
        }

        [TestMethod]
        public void CheckIfLoginFailWhitoutCredentials()
        {
            try
            {
                // Click on button Sign
                IWebElement objElem;
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div/div[2]/div[2]/a[1]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button for Sign in don´t exists on the web page of GitHub!");
                }

                // Click on button Sign in withou indicate de credentials
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "//*[@id='login']/form/div[4]/input[12]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button for Sign in don´t exists on the web page of Sign In for GitHub!");
                }

                // Check if the message indicating that the user or pwd are incorrect
                objElem = GlobalVariables.objDriver.FindElement(ActionsOnElements.ReturnTypeOFCall(TypeOfCall.ByID, "js-flash-container"));
                if (objElem.Displayed)
                {
                    // test passed nothing to do
                }
                else
                {
                    Assert.Fail("The message indicating that the user or pwd are incorrect was not displayed!");
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
