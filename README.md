Desenvolvimento nas seguintes tecnologias:

ChallengeAPI:
---Desenvolvida em ASP.NET Core

Checkout (formul�rios de cadastro para consumir a API)
---Desenvolvido em C# Windows Forms

Banco de Dados:
---SQL Server Express

Passos para executar o Fonte:

Tendo as tecnologias acima instaladas, abrir a solution Payment_API.sln

Antes de rodar o Fonte:
-> Alterar a stringConnection no arquivo appsettings.Development.json que se encontra na Payment_API, abaixo da aba appsettings.json, conforma abaixo:
"SqlServerConectionString": "Server=MeuServidorSQl; Database=ChallengeAPI; User ID=MeuUSER_ID; Password=Meu_User_Password;"
->Substituir na string acima MeuServidorSQl pelo servidor do Banco de dados SQL
->Substituir na string acima MeuUSER_ID pelo ID do usu�rio do banco de dados SQL
->Substituir na string acima Meu_User_Password pelo senha do usu�rio do banco de Dados SQL

OBS. 1: O usu�rio do SQL tem que ter as permiss�es para Conex�o, Create (Data Base e Tabelas), Insert, Delete e Select
OBS. 2: Ao rodar a aplica��o, ser� criado uma base de dados com o nome que est� na stringConection e ser�o criadas as tabelas necess�rias nessa base, atrav�s das migrations.

Ap�s o procedimento acima, rodar o fonte. O servi�o Payment_API vai subir e logo em seguida subir� um formul�rio para cadastro do cliente.

Formul�rio cadastro do cliente:
-> Bot�o Novo vai limpar os campos e deixar dispon�vel para gravar um novo cliente
-> Bot�o cadastrar vai inserir o novo cliente
-> Bot�o Alterar altera algum dado do cliente
-> Bot�o Deletar deleta o cliente cadastrado
-> Bot�o Realizar Pagamento vai realizar um pagamento para um cliente selecionado na Grid
-> Bot�o Visualizar Pagamentos para ver todos os pagamentos realizados
