using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace siecApresentaçãoSefaz
{
    [Binding]
    public class LoginValidoSteps
    {
        IWebDriver browser;

        [Given(@"que eu navego pela url")]
        public void aDadoQueEuNavegoPelaUrl()
        {
            this.browser = new ChromeDriver();
            
            browser.Manage().Window.Maximize();

            this.browser.Navigate().GoToUrl("https://dsistemasweb.sefaz.ba.gov.br/sistemas/siec");
        
            var acessoInicial = this.browser.FindElement(By.CssSelector(".fa-times"));
            acessoInicial.Click();
            Thread.Sleep(2000);
        }

        
        [When(@"informo o usuario")]
        public void cQuandoInformoOUsuario()
        {
            var usuario = this.browser.FindElement(By.Id("usuario"));
            usuario.SendKeys("dservidor");
            Thread.Sleep(2000);
        }

        
        [When(@"informo a senha valida")]
        public void dQuandoInformoASenhaValida()
        {
            var txtSenha = this.browser.FindElement(By.Id("senha"));
            txtSenha.SendKeys("dserv29");
            Thread.Sleep(2000);
        }

        
        [When(@"clico no botão Entrar")]
        public void eQuandoClicoNoBotaoEntrar()
        {
            var botaoEntrar = this.browser.FindElement(By.ClassName("btn-primary"));
            botaoEntrar.Click();
            Thread.Sleep(2000);
        }

        
        [Then(@"acesso deve ser realizado com sucesso")]
        public void fEntaoAcessoDeveSerRealizadoComSucesso()
        {
            this.browser.FindElement(By.ClassName("text-muted"));
            Thread.Sleep(5000);
        }
    }
}
