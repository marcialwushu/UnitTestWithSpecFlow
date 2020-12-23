#language: pt-br

Funcionalidade: Sendo que sou um consumidor da API 
	Gostaria de tesar as funcionalidades da API para Clientes

Cenario: Obter informação da API
	Dado que a url do endpoint é 'https://mock-api-collection.herokuapp.com/dados'
	E o metodo http é 'GET'
	Quando chamar o serviço