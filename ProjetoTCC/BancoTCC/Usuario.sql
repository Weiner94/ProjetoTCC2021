CREATE TABLE [dbo].[Usuario]
(
	[IdUsuario] int IDENTITY(1,1) PRIMARY KEY,
    [nome] VARCHAR(30) NULL,
    [senha] VARCHAR(10) NULL,
    [permissoes] INT NULL

    
)
GO


