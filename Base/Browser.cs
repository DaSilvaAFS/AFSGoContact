using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CodedUITestGoContact.Base
{
    public class Browser
    {
        //public static void IniciaSessao(string inUser, string inPWD, string inCodCli)
        //{
        //    // Indicar o utilizador
        //    var objElemUser = AtribuiValorElementos.Atribui_ByID("UserName", inUser);
        //    // Indicar a password
        //    var objElemPassW = AtribuiValorElementos.Atribui_ByID("Password", inPWD);
        //    // Indicar o cliente
        //    if (!inCodCli.Equals(""))
        //    {
        //        var objElemCliente = AtribuiValorElementos.Atribui_ByID("CodCliente", inCodCli);
        //    }
        //    // Clicar no botão entrar
        //    //var objElemBtnAut = AcoesElementos.Click_ByID("btnAutenticacao");
        //    //AcoesElementos.EsperarAteFicarInvisivel_ByID("btnAutenticacao");
        //    var objElemBtnAut = AcoesElementos.LocalizaExecutaAcaoElemento(Constantes.TipoChamada.ByID, "btnAutenticacao", Constantes.AcaoAExecutar.Click);
        //}

        //public static void TerminaSessao()
        //{
        //    // Abrir o menu
        //    //user-name-area dropdown-toggle
        //    //var objElemUser = AcoesElementos.Click_ByXPath("//a[@class='user-name-area dropdown-toggle']");
        //    var objElemUser = AcoesElementos.LocalizaExecutaAcaoElemento(Constantes.TipoChamada.ByXPath, "//a[contains(@class, 'user-name-area') and contains(@class, 'dropdown-toggle')]", Constantes.AcaoAExecutar.Click);

        //    // Clicar na opção terminar sessão
        //    //var objElemOpcaoMenu = AcoesElementos.Click_ByID("mnuTerminaSessao");
        //    //AcoesElementos.EsperarAteFicarInvisivel_ByID("mnuTerminaSessao");
        //    var objElemOpcaoMenu = AcoesElementos.LocalizaExecutaAcaoElemento(Constantes.TipoChamada.ByID, "mnuTerminaSessao", Constantes.AcaoAExecutar.Click);

        //    //Thread.Sleep(500);
        //    // Confirma ou não o fecho da sessão 
        //    //VariaveisGlobais.objEspera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("JanelaAlertaConfirma")));
        //    var objElemJanela = AcoesElementos.LocalizaExecutaAcaoElemento(Constantes.TipoChamada.ByID, "JanelaAlertaConfirma", Constantes.AcaoAExecutar.NaoExecutaAcao);

        //    //var objElemBtnSim = AcoesElementos.Click_ByXPath("//button[contains(@class, 'Confirma') and contains(@class, 'btn')]");
        //    //AcoesElementos.EsperarAteFicarInvisivel_ByXPath("//button[contains(@class, 'Confirma') and contains(@class, 'btn')]");
        //    var objElemBtnSim = AcoesElementos.LocalizaExecutaAcaoElemento(Constantes.TipoChamada.ByXPath, "//button[contains(@class, 'Confirma') and contains(@class, 'btn')]", Constantes.AcaoAExecutar.Click);
        //}
    }

    public class ActionsBeginEndTest
    {
        public static void OpenBrowser(bool inDoLogin)
        {
            // Open browser 
            GlobalVariables.objDriver = new ChromeDriver(Constants.PathChromeWebDriver);
            GlobalVariables.objDriver.Manage().Window.Maximize();
            GlobalVariables.objDriver.Navigate().GoToUrl(GlobalVariables.URLApp);
            // Sometimes with need to wait for a few seconds that all the poage is loaded
            GlobalVariables.objWait = new WebDriverWait(GlobalVariables.objDriver, TimeSpan.FromSeconds(3));
        }

        public static void CloseBrowser()
        {
            if (GlobalVariables.objDriver != null)
            {
                GlobalVariables.objDriver.Close();
            }
        }
    }
}