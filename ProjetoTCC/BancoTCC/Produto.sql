CREATE TABLE [dbo].[Produto]
(
	[IdProduto] INT IDENTITY(1,1) PRIMARY KEY,
    [nome] VARCHAR(200) NULL, 
    [preco_compra] FLOAT NULL, 
    [preco_venda] FLOAT NULL, 
    [porcentagem_lucro] FLOAT NULL, 
    [quantidade] INT NULL, 
    [fk_produto_idFornecedor] int NULL, 
    [descricao] VARCHAR(500) NULL
)
GO
