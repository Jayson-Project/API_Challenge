Desenvolvimento nas seguintes tecnologias:

ChallengeAPI:
---Desenvolvida em ASP.NET Core

Checkout (formulários de cadastro para consumir a API)
---Desenvolvido em C# Windows Forms

Banco de Dados:
---SQL Server Express

Passos para executar o Fonte:

Tendo as tecnologias acima instaladas, abrir a solution Payment_API.sln

Antes de rodar o Fonte:
-> Alterar a stringConnection no arquivo appsettings.Development.json que se encontra na Payment_API, abaixo da aba appsettings.json, conforma abaixo:
"SqlServerConectionString": "Server=MeuServidorSQl; Database=ChallengeAPI; User ID=MeuUSER_ID; Password=Meu_User_Password;"
->Substituir na string acima MeuServidorSQl pelo servidor do Banco de dados SQL
->Substituir na string acima MeuUSER_ID pelo ID do usuário do banco de dados SQL
->Substituir na string acima Meu_User_Password pelo senha do usuário do banco de Dados SQL

OBS. 1: O usuário do SQL tem que ter as permissões para Conexão, Create (Data Base e Tabelas), Insert, Delete e Select
OBS. 2: Ao rodar a aplicação, será criado uma base de dados com o nome que está na stringConection e serão criadas as tabelas necessárias nessa base, através das migrations.

Após o procedimento acima, rodar o fonte. O serviço Payment_API vai subir e logo em seguida subirá um formulário para cadastro do cliente.

Formulário cadastro do cliente:
-> Botão Novo vai limpar os campos e deixar disponível para gravar um novo cliente
-> Botão cadastrar vai inserir o novo cliente
-> Botão Alterar altera algum dado do cliente
-> Botão Deletar deleta o cliente cadastrado
-> Botão Realizar Pagamento vai realizar um pagamento para um cliente selecionado na Grid
-> Botão Visualizar Pagamentos para ver todos os pagamentos realizados
