create table Payment
(
Id				bigint identity not null,
Id_Buyer		bigint not null, 
Id_Card			bigint null, 
Amount			decimal(12,2),
Type			varchar(100),
Card		    varchar(100),
Cod_Barras		varchar(500),
Status			varchar(100),
CONSTRAINT PK_Payment PRIMARY KEY NONCLUSTERED (ID)
      , CONSTRAINT FK_Buyer_Payment FOREIGN KEY (Id_Buyer)
        REFERENCES Buyer (Id)
	  , CONSTRAINT FK_Card_Payment FOREIGN KEY (Id_Card)
        REFERENCES Card (Id)		
)