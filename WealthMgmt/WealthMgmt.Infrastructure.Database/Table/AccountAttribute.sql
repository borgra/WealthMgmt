CREATE TABLE [dbo].[AccountAttribute]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AccountTypeId] INT NOT NULL,
    [Name] NVARCHAR(255) NOT NULL, 
    [Value] NVARCHAR(255) NOT NULL
)
