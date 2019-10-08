create table Buyer
(
Id			bigint identity not null,
Id_Client	bigint not null, 
Name		varchar(500),
Email		varchar(500),
CPF			varchar(500),
CONSTRAINT PK_Buyer PRIMARY KEY NONCLUSTERED (ID)
      , CONSTRAINT FK_Client_Buyer FOREIGN KEY (Id_Client)
        REFERENCES Client (Id)
)