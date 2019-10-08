create table Card
(
Id					bigint identity not null,
Id_Buyer			bigint not null,
Holder_name			varchar(500),
Number				varchar(500),
Expiration_date		Datetime,
CVV					int,
CONSTRAINT PK_Card PRIMARY KEY NONCLUSTERED (ID)
      , CONSTRAINT FK_Buyer_Card FOREIGN KEY (Id_Buyer)
        REFERENCES Buyer (Id)
)