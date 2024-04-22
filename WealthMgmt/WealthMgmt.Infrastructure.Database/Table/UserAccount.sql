CREATE TABLE [dbo].[UserAccount]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NOT NULL,
    [Balance] MONEY NOT NULL DEFAULT 0,
    [UserId] INT NOT NULL, 
    [AccountTypeId] INT NOT NULL
)
