CREATE TABLE [dbo].[Cliente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nombre] NVARCHAR(50) NULL, 
    [direrccion] NVARCHAR(50) NULL, 
    [poblacion] NVARCHAR(50) NULL, 
    [telefonoº] NVARCHAR(50) NULL
)
