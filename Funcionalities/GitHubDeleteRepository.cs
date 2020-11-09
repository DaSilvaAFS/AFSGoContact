using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodedUITestGoContact.Base;
using OpenQA.Selenium;
using static CodedUITestGoContact.Base.Constants;
using CodedUITestGoContact.Base;
using System.Threading;

namespace CodedUITestGoContact.Funcionalities
{
    /// <summary>
    /// Summary description for CheckSiteGitHubOpen
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class GitHubDeleteRepository
    {
        public GitHubDeleteRepository()
        {
        }

        [TestMethod]
        public void GitHubDeleteRepositoryThatExists()
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

                // Click on the button that makes apear de menu with the your repositories option
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div[7]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button that shows the menus about the profile was not found!");
                }

                // Click the option your repositories
                objElem = ActionsOnElements.Click_ByXPath("/html/body/div[1]/header/div[7]/details/details-menu/a[2]");
                if (objElem == null)
                {
                    Assert.Fail("Logout option not found!");
                }

                // Chose a repository 
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[4]/main/div[2]/div/div[2]/div[2]/div/div[2]/ul/li/div[1]/div[1]/h3/a", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("Repository don´t found!");
                }

                // Go to settings 
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[4]/div/main/div[1]/nav/ul/li[8]/a/span[1]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("Repository settings not found!");
                }

                Thread.Sleep(1000);
                // Click on the delete repository button 
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[4]/div/main/div[2]/div/div/div[2]/div/div[9]/ul/li[4]/details/summary", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("Button for delete repository not found!");
                }

                // Enter de key for deletion 
                objElem = AddValueToElements.AddValue_ByXPath("/html/body/div[4]/div/main/div[2]/div/div/div[2]/div/div[9]/ul/li[4]/details/details-dialog/div[3]/form/p/input", "AFSGoContact/TestProject");

                // Click i understand and delete
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[4]/div/main/div[2]/div/div/div[2]/div/div[9]/ul/li[4]/details/details-dialog/div[3]/form/button/span[1]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("Button do confirm the delete not found!");
                }

                // Click on ther button that makes apear de menu with the logout option
                objElem = ActionsOnElements.LocateAndExecuteActionForElement(TypeOfCall.ByXPath, "/html/body/div[1]/header/div[7]", ActionToExecute.Click);
                if (objElem == null)
                {
                    Assert.Fail("The button that shows the menus about the profile was not found!");
                }

                // Click on the option logout
                objElem =  ActionsOnElements.Click_ByXPath("/html/body/div[1]/header/div[7]/details/details-menu/form/button");
                if (objElem == null)
                {
                    Assert.Fail("Logout option not found!");
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
