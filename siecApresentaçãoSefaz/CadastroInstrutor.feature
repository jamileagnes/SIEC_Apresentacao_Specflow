#language: pt

    
    Funcionalidade: Cadastrar novo instrutor

        Cenario: cadastrar instrutor com sucesso
        	Quando escolho a seção Portal UCS
            E escolho a subseção Instrutoria interna
            E seleciono a opção Instrutor
            E clico botão incluir
            E preenche o CPF com CPF "03160950522"
            E matricula "644654644"
            E preencho o Orgão com Bahia Pesca
            E regime de trabalho do tipo "ESPECIAL"
            E telefone "99999999999"
            E E-mail Institucional com "teste@sefaz.gov.ba.br"
            E Conclusão curso da SAEB como não.
            E Habilito para EAD
            E escolaridade de ensino superior completo
            Então clico em Confirmar