CREATE TABLE [dbo].[Relacao_Pedido_Produto]
(
	[IdRelacaoPP] INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
    [fk_idPedidoProduto] INT NULL, 
    [fk_idProduto] INT NULL,
    [quantidade] INT NULL,
    [totalProduto] float NULL,

  
)
GO
