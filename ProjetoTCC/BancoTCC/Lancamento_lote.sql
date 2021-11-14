CREATE TABLE [dbo].[Lancamento_lote]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
    [data_lote] DATETIME NULL, 
    [quantidade_recebida] INT NULL, 
    [FKLancamentoLoteUsuario] INT NOT NULL,
    [FKLancamentolotePedidoProduto] INT NOT NULL,
    [FKLancamentoLoteProduto] INT NOT NULL, 

)
GO
