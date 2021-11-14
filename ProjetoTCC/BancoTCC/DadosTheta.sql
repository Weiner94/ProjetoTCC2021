CREATE TABLE [dbo].[DadosTheta]
(
	[IdTheta] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [dadoTheta] FLOAT NOT NULL, 
    [fk_produto] INT NOT NULL
)
