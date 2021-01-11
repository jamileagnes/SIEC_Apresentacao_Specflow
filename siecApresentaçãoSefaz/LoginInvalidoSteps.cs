using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace siecApresentaçãoSefaz
{
    [Binding][TestClass]
    public class LoginInvalidoSteps
    {
        private readonly IWebDriver browser = new ChromeDriver();

        [TestCleanup]
        public void Close()
        {
            this.browser.Close();
            this.browser.Dispose();
        }

        [TestMethod][TestInitialize]
        [Given(@"fecho o acesso inicial")]
        public void DadoFechoOAcessoInicial()
        {
            browser.Manage().Window.Maximize();

            this.browser.Navigate().GoToUrl("https://dsistemasweb.sefaz.ba.gov.br/sistemas/siec");

            var acessoInicial = this.browser.FindElement(By.CssSelector(".fa-times"));
            acessoInicial.Click();
            Thread.Sleep(2000);
        }

        [TestMethod]
        [When(@"informo o usuario invalido")]
        public void QuandoInformoOUsuarioInvalido()
        {
            var txtUsuario = this.browser.FindElement(By.Name("usuario"));
            txtUsuario.SendKeys("dservidor");
            Thread.Sleep(2000);
        }

        [TestMethod]
        [When(@"informo a senha incorreta")]
        public void QuandoInformoASenhaIncorreta()
        {
            var txtSenha = this.browser.FindElement(By.Name("senha"));
            txtSenha.SendKeys("dserv27");
            Thread.Sleep(2000);
        }

        [TestMethod]
        [Then(@"exibir mensagem de usuario e senha incorreto")]
        public void EntaoExibirMensagemDeUsuarioESenhaIncorreto()
        {
            var botaoEntrar = this.browser.FindElement(By.ClassName("btn-primary"));
            botaoEntrar.Click();

            this.browser.FindElement(By.ClassName("form-control"));
            Thread.Sleep(5000);
        }
    }
}
