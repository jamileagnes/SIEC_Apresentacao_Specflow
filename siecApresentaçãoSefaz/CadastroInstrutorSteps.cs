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
    public class CadastroInstrutorSteps
    {

        private readonly IWebDriver browser = new ChromeDriver();

        [When(@"escolho a seção Portal UCS")]
        public void QuandoEscolhoASecaoPortalUCS()
        {
            browser.Manage().Window.Maximize();

            this.browser.Navigate().GoToUrl("https://dsistemasweb.sefaz.ba.gov.br/sistemas/siec");

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
        }
        
        [TestMethod]
        [When(@"seleciono a opção Instrutor")]
        public void QuandoSelecionoAOpcaoInstrutor()
        {
            var instrutoriaInterna = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-menu/nav/aslib-menu-item/ul[3]/li/aslib-menu-item/ul[3]/li/a"));
            instrutoriaInterna.Click();
            Thread.Sleep(2000);

            var instrutor = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-menu/nav/aslib-menu-item/ul[3]/li/aslib-menu-item/ul[3]/li/aslib-menu-item/ul[1]/li/a"));
            instrutor.Click();
            Thread.Sleep(9000);
        }

        [TestMethod]
        [When(@"clico botão incluir")]
        public void QuandoClicoBotaoIncluir()
        {
            var botaoIncluir = this.browser.FindElement(By.Id("btnIncluir"));
            botaoIncluir.Click();
            Thread.Sleep(9000);
        }

        [TestMethod]
        [When(@"preenche o CPF com CPF ""(.*)""")]
        public void QuandoPreencheOCPFComCPF(Decimal p0)
        {
            var cpf = this.browser.FindElement(By.Id("textCPF"));
            cpf.SendKeys("03160950522");
            Thread.Sleep(5000);
        }

        [TestMethod]
        [When(@"matricula ""(.*)""")]
        public void QuandoMatricula(int p0)
        {
            var matricula = this.browser.FindElement(By.Id("txtMatricula"));
            matricula.Click();
            Thread.Sleep(2000);

            var matricula1 = this.browser.FindElement(By.Id("txtMatricula"));
            matricula1.SendKeys("644654644");
            Thread.Sleep(2000);
        }

        [TestMethod]
        [When(@"preencho o Orgão com Bahia Pesca")]
        public void QuandoPreenchoOOrgaoComBahiaPesca()
        {
            var entidade = this.browser.FindElement(By.Id("selectClienteSRH"));
            entidade.Click();
            Thread.Sleep(2000);

            SelectElement entidade1 = new SelectElement(browser.FindElement(By.Id("selectClienteSRH")));
            entidade1.SelectByText("BAPREV - PENSIONISTA");
        }

        [TestMethod]
        [When(@"regime de trabalho do tipo ""(.*)""")]
        public void QuandoRegimeDeTrabalhoDoTipo(string p0)
        {
            var regimeTrabalho = this.browser.FindElement(By.Id("selectRegimeDeTrabalho"));
            regimeTrabalho.Click();
            Thread.Sleep(2000);

            SelectElement regimeTrabalho1 = new SelectElement(browser.FindElement(By.Id("selectRegimeDeTrabalho")));
            regimeTrabalho1.SelectByText("30 Horas");
        }

        [TestMethod]
        [When(@"telefone ""(.*)""")]
        public void QuandoTelefone(Decimal p0)
        {
            var celular = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-content/div/div[3]/app-instrutor-cadastrar/form/div[7]/div[2]/input"));
            celular.SendKeys("99999999999");
        }

        [TestMethod]
        [When(@"E-mail Institucional com ""(.*)""")]
        public void QuandoE_MailInstitucionalCom(string p0)
        {
            var emailInstitucional = this.browser.FindElement(By.Id("txtEmailInstitucional"));
            emailInstitucional.SendKeys("teste@sefaz.gov.ba.br");
        }

        [TestMethod]
        [When(@"Conclusão curso da SAEB como não\.")]
        public void QuandoConclusaoCursoDaSAEBComoNao_()
        {
            SelectElement cursoSaeb1 = new SelectElement(browser.FindElement(By.Id("selectConclusaoCursoDaSAEB")));
            cursoSaeb1.SelectByText("Não");
        }

        [TestMethod]
        [When(@"Habilito para EAD")]
        public void QuandoHabilitoParaEAD()
        {
            SelectElement habilitadoEad1 = new SelectElement(browser.FindElement(By.Id("selectHabilitadoParaEAD")));
            habilitadoEad1.SelectByText("Sim");
        }

        [TestMethod]
        [When(@"escolaridade de ensino superior completo")]
        public void QuandoEscolaridadeDeEnsinoSuperiorCompleto()
        {
            var escolaridade = this.browser.FindElement(By.Id("selectEscolaridade"));
            escolaridade.Click();
            Thread.Sleep(2000);

            SelectElement escolaridade1 = new SelectElement(browser.FindElement(By.Id("selectEscolaridade")));
            escolaridade1.SelectByText("SUPERIOR COMPLETO");
        }

        [TestMethod]
        [Then(@"clico em Confirmar")]
        public void EntaoClicoEmConfirmar()
        {
            var botaoConfirmar = this.browser.FindElement(By.XPath("/html/body/app-root/aslib/aslib-content/div/div[3]/app-instrutor-cadastrar/form/div[15]/div/button[1]"));
            botaoConfirmar.Click();
        }
        
    }
}
