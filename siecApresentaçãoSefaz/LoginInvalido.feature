#language: pt-br

Funcionalidade: Login inválido
	Para que acesse o sistema SIEC
	Eu, como usuário valido
	Desejo informar a senha incorreta


	Cenário: realizar tentativa de acesso com senha invalida
		Dado que eu navego pela url
		E fecho o acesso inicial
		Quando informo o usuario invalido
		E informo a senha incorreta
		E clico no botão Entrar
		Então exibir mensagem de usuario e senha incorreto