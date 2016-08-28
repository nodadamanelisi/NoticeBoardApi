CREATE TABLE [dbo].[Login]
(
	[UserId] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserName] Varchar(30) NOT NULL, 
    [Password] VARCHAR(30) NOT NULL, 
    [RememberMe] BIT NULL
)
