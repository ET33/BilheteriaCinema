LINK PARA O POWERPOINT
https://docs.google.com/presentation/d/1077y3RJ8tuaWZuZ-BdUEyOTOFOD79zgBESiJIwSJZ4Q/edit#slide=id.g6c3177c2a0_1_13
EXERCICIOS
Ingresso
	Lista todos os ingressos cadastrados

	Ingresso?dataInicio=2019-12-09&dataFim=2019-12-09&cpf=26555333057&sessao=4
	Lista os ingressos utilizando filtros opcionais para os seguintes campos:
		DataCompra
		CPF
		CodigoSessao

Sessao
	Cadastrar uma sess�o com os seguintes requisitos:
		O c�digo deve ser �nico
		Uma sess�o n�o pode ter uma Sala que j� est� sendo utilizada nesse per�odo

Sessao/{codigo}
	Buscar uma Sess�o pelo seu c�digo cadastrado
	Caso n�o exista nenhuma sess�o com esse c�digo retornar 404 (Not Found)
	

Sugest�es:
	Sigam os exemplos dos Endpoints Existentes 
	O Projeto esta divido da seguinte forma:
		Api  
		Application
		Infra.EF
	A Camada de API � a porta de entrada para acesso as informa��es
	A camada de Application tem todas a regras de neg�cio e manipula��o dos objetos
	A camada de Infra.EF � respons�vel apenas pelo acesso aos dados

	Todas as camadas devem conter algum c�digo
	Deve-se respeitar a estrutura do programa
	
	Todas as camadas devem ser utilizadas para a constru��o 
	O banco de dados esta rodando em um Docker (SQL) e ele ja tem alguns filmes cadastrados
	Para acesso ao banco caso seja necess�rio podera utilizar o DBeaver https://dbeaver.io/download/
	Todas as bases ja est�o criadas e pr� carregadas
	Rodar o Programa F5, Buildar o Programa CTRL+SHIFT+B, no Output voce consegue ver os erros
	Caso queira debugar basta colocar um BreakPoint na linha e rodar atrav�s do F5 ou apertar o Play
	no VSCode

	Qualquer d�vida � s� chamar!




docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Passw0rd" \
-p 1433:1433 --name MyDb \
-d mcr.microsoft.com/mssql/server:2019-GA-ubuntu-16.04;

