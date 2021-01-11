using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace siecApresentaçãoSefaz
{
    [Binding][TestClass]
    public class PesquisaInstrutorSteps
    {

        private readonly IWebDriver browser = new ChromeDriver();

        [TestMethod][TestInitialize]
        [When(@"escolho a subseção Instrutoria interna")]
        public void QuandoEscolhoASubsecaoInstrutoriaInterna()
        {
            this.browser.Navigate().GoToUrl("https://dsistemasweb.sefaz.ba.gov.br/sistemas/siec");

            browser.Manage().Window.Maximize();

            var acessoInicial = this.browser.FindElement(By.CssSelector(".fa-times"));
            acessoInicial.Click();

            var usuario = this.browser.FindElement(By.Id("usuario"));
            usuario.SendKeys("dservidor");
            var txtSenha = this.browser.FindElement(By.Id("senha"));
            txtSenha.SendKeys("dserv29");
            var botaoEntrar = this.browser.FindElement(By.ClassName("btn-primary"));
            botaoEntrar.Click();
            Thread.Sleep(9000);

            var portalUcs = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-menu/nav/aslib-menu-item/ul[3]/li/a"));
            portalUcs.Click();
            Thread.Sleep(2000);

            var instrutoriaInterna = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-menu/nav/aslib-menu-item/ul[3]/li/aslib-menu-item/ul[3]/li/a"));
            instrutoriaInterna.Click();
            Thread.Sleep(2000);

            var instrutor = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-menu/nav/aslib-menu-item/ul[3]/li/aslib-menu-item/ul[3]/li/aslib-menu-item/ul[1]/li/a"));
            instrutor.Click();
            Thread.Sleep(9000);
        }

        [TestMethod]
        [When(@"preencho o Fazendario com ""(.*)""")]
        public void QuandoPreenchoOFazendarioCom(string p0)
        {
            SelectElement fazendario = new SelectElement(browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-content/div/div[3]/app-instrutor-lista/form/div[1]/select")));
            fazendario.SelectByText("Não");
            Thread.Sleep(5000);
        }

        [TestMethod]
        [When(@"preencho a Situação com ""(.*)""")]
        public void QuandoPreenchoASituacaoCom(string p0)
        {
            SelectElement situacao = new SelectElement(browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-content/div/div[3]/app-instrutor-lista/form/div[4]/select")));
            situacao.SelectByText("Ativo");
            Thread.Sleep(5000);
        }

        [TestMethod]
        [When(@"preencho o Curso SAEB com ""(.*)""")]
        public void QuandoPreenchoOCursoSAEBCom(string p0)
        {
            SelectElement cursoSaeb = new SelectElement(browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-content/div/div[3]/app-instrutor-lista/form/div[6]/select[1]")));
            cursoSaeb.SelectByText("Sim");
            Thread.Sleep(5000);
        }

        [TestMethod]
        [Then(@"clico no botão Pesquisar")]
        public void QuandoClicoNoBotaoPesquisar()
        {
            var botaoPesquisar = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-content/div/div[3]/app-instrutor-lista/form/div[9]/div/button[1]"));
            botaoPesquisar.Click();
            Thread.Sleep(9000);
        }
        
    }
}
