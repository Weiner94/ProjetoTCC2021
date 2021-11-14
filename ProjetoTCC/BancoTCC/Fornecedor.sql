CREATE TABLE [dbo].[Fornecedor]
(
	[IdFornecedor] INT IDENTITY(1,1) PRIMARY KEY,
    [nome_fornecedor] VARCHAR(50) NULL, 
    [endereco] VARCHAR(60) NULL, 
    [contato] VARCHAR(15) NULL, 
    [representante_comercial] VARCHAR(30) NULL, 
    [descricao] VARCHAR(200) NULL
)
GO
