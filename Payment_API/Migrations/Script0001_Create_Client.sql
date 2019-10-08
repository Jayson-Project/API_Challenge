Create table Client
(
Id		bigint identity not null,
 CONSTRAINT PK_Client PRIMARY KEY NONCLUSTERED (ID),
Nome	varchar(500),
Email	varchar(500)
)