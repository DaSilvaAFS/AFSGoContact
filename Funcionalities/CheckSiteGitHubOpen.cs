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
    public class CheckSiteGitHubOpen
    {
        public CheckSiteGitHubOpen()
        {
        }

        [TestMethod]
        public void CheckIfElementCatExistsInPage()
        {
            try
            {
                IWebElement objElem;
                objElem = GlobalVariables.objWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ActionsOnElements.ReturnTypeOFCall(TypeOfCall.ByXPath, "/html/body/div[1]/header/div/div[1]/a")));

                if (!objElem.Displayed)
                {
                    Assert.Fail("The Cat image from the Web Site of GitHub don´t exist´s (element not found), so the page was not corretly loaded!");
                }

            }
            catch (OpenQA.Selenium.WebDriverException e)
            {
                if (e.HResult.Equals(-2146233088))
                {
                    Assert.Fail("The Cat image from the Web Site of GitHub don´t exist´s (element not found), so the page was not corretly loaded!");
                }
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
