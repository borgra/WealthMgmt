CREATE TABLE [dbo].[User]
(
	[Id] INT PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [DateOfBirth] DATE NULL, 
    [Email] NVARCHAR(255) NULL, 
    [IsActive] BIT NULL DEFAULT 1
)
