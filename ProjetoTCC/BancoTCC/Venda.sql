CREATE TABLE [dbo].[Venda]
(
	[IdVenda] INT IDENTITY(1,1) PRIMARY KEY,
    [produto] VARCHAR(200) NULL, 
    [quantidade] FLOAT NULL, 
    [total] FLOAT NULL, 
    [data_venda] DATETIME NULL, 
    [valor_un_g] FLOAT NULL, 
    [fk_venda_usuario] INT NULL,
    [cod_venda] INT NULL, 
)
GO