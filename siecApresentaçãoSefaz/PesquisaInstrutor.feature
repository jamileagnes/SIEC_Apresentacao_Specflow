#language: pt

    Funcionalidade: Pesquisar instrutor

        Cenario: pesquisar instrutor com sucesso
            Quando escolho a seção Portal UCS
            E escolho a subseção Instrutoria interna
            E seleciono a opção Instrutor
			E preencho o Fazendario com "Não"
            E preencho a Situação com "Ativo"
            E preencho o Curso SAEB com "Sim"
            Então clico no botão Pesquisar
