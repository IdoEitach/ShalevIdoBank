-- Tables
DROP TABLE [dbo].[Workers]
CREATE TABLE [dbo].[Workers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL
)


-- Examples
SET IDENTITY_INSERT [dbo].[Workers] ON
INSERT INTO [dbo].[Workers] ([Id], [Username], [Password]) VALUES (1, N'Worker', N'111')
SET IDENTITY_INSERT [dbo].[Workers] OFF


-- Stored Procedures
go--at
DROP PROCEDURE [dbo].[spValidLogin]
go--at
CREATE PROCEDURE [dbo].[spValidLogin]
	@username NVARCHAR(50),
	@password NVARCHAR(50)
AS
	SELECT * FROM Workers WHERE Username = @username AND Password = @password
RETURN 0

