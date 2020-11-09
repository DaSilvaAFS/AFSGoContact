using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CodedUITestGoContact.Base
{

    public class GlobalVariables
    {
        public static IWebDriver objDriver;
        public static WebDriverWait objWait;

        public static string URLApp = "https://github.com/";
        public static string UserName = "";
        public static string UserPass = "";
    }
}