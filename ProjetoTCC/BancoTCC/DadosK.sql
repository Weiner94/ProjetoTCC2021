CREATE TABLE [dbo].[DadosK]
(
	[IdK] INT IDENTITY(1,1) PRIMARY KEY,
	[dadoK] FLOAT NOT NULL,
	[fk_produto] INT NOT NULL 
)
