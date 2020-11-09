using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodedUITestGoContact.Base;
using OpenQA.Selenium;
using static CodedUITestGoContact.Base.Constants;
using CodedUITestGoContact.Base;

namespace CodedUITestGoContact.Funcionalities
{
    /// <summary>
    /// Summary description for CheckSiteGitHubOpen
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class GitHubCreateRepository
    {
        public GitHubCreateRepository()
        {
        }

        [TestMethod]
        public void GitHubCreateRepositoryBYPlusMenu()
        {
            try
            {
                IWebElement objElem;

                // Click in acept button of cookies
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[8]/div/div/div/div[1]/div/div/button[1]", ActionToExecute.Click);

                // Click on button Sign
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div/div[2]/div[2]/a[1]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button for Sign in don´t exists on the web page of GitHub!");
                }

                // Enter the user name
                objElem = AddValueToElements.AddValue_ByID("login_field", CodedUITestGoContact.Properties.Resources.User);

                // Enter the password
                objElem = AddValueToElements.AddValue_ByID("password", CodedUITestGoContact.Properties.Resources.Password);

                // Click on the button Sign in after the credentials are typed
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "//*[@id='login']/form/div[4]/input[12]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button for Sign in don´t exists on the web page of Sign In for GitHub!");
                }
               
                // Open menu to create new repository
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div[6]/details/summary/span", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button that shows the menu about quickly actions not found!");
                }

                // Click on option related with new repository
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div[6]/details/details-menu/a[1]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The menu option to create a new repository not found!");
                }

                // Add a repository name
                objElem = AddValueToElements.AddValue_ByID("repository_name", CodedUITestGoContact.Properties.Resources.RepositoryName);

                // Add Description
                objElem = AddValueToElements.AddValue_ByID("repository_description", CodedUITestGoContact.Properties.Resources.RepositoryDescription);

                // Select private option 
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByID, "repository_visibility_private", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The radio button private not found!");
                }

                // Check a ReadMe file
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByID, "repository_auto_init", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The radio button private not found!");
                }

                // Click on create repository       /html/body/div[4]/main/div/form/div[4]/button         
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[4]/main/div/form/div[4]/button", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button to create the repository not found or not available!");
                }

                // Click on ther button that makes apear de menu with the logout option
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div[7]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button that shows the menus about the profile don´t found!");
                }

                // Click on the option logout
                objElem =  ActionsOnElements.Click_ByXPath("/html/body/div[1]/header/div[7]/details/details-menu/form/button");
                if (objElem == null)
                {
                    Assert.Fail("The logout option not found!");
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
