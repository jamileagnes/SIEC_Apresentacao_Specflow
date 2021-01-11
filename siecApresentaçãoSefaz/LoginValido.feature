#language: pt-br

Funcionalidade: Login válido
	Para que acesse o sistema SIEC
	Eu, como usuário
	Desejo informar usuário e senha


	Cenário: usuário e senha validos
		Dado que eu navego pela url
		E fecho o acesso inicial
		Quando informo o usuario
		E informo a senha valida
		E clico no botão Entrar
		Então acesso deve ser realizado com sucesso
