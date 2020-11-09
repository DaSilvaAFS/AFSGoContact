namespace CodedUITestGoContact.Base
{
    public class Constants
    {
        #region General
            public const string PathChromeWebDriver = @"C:\Projetos\CodedUITestGoContact\Components\";

            public const string PathLogFile = @"C:\Projetos\CodedUITestGoContact\TestResults\LOG\";
            public const string NameLogFile = "CUITGoContact.txt";
        #endregion

        #region Structures
            public struct TypeOfCall
            {
                public const string ByXPath = "XPath";
                public const string ByID = "ID";
                public const string ByName = "Name";
                public const string ByClass = "Class";
                public const string ByInnerText = "InnerText";
            }

            public struct ActionToExecute
            {
                public const int DontExecuteAction = 0;
                public const int Click = 1;
                public const int DoubleClick = 2;
            }
        #endregion
    }
}