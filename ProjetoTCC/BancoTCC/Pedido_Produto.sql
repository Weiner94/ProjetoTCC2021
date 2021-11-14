CREATE TABLE [dbo].[Pedido_Produto]
(
	[IdPedidoProduto] INT IDENTITY(1,1) PRIMARY KEY,
    [data_recebimento] DATETIME NULL, 
    [estado] VARCHAR(15) NULL, 
    [data_pedido] DATETIME NULL, 
    [data_entrega] DATETIME NULL, 
    [FKPedidoProdutoUsuario] INT NULL,
    [FKPedidoProdutoFornecedor] INT NULL, 

  
)
GO


