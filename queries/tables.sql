-- Tables
DROP TABLE [dbo].[tblAccounts]
CREATE TABLE [dbo].[tblAccounts] (
    [AccountId] INT           IDENTITY (1, 1) NOT NULL,
    [Balance]   FLOAT (53)    NULL,
    [UserId]    NVARCHAR (50) NULL,
    [UserName]  NVARCHAR (50) NULL UNIQUE,
    [Password]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AccountId] ASC)
);


DROP TABLE [dbo].[tblCities]
CREATE TABLE [dbo].[tblCities] (
    [CityId]   INT           NOT NULL,
    [CityName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CityId] ASC)
);


DROP TABLE [dbo].[tblTransactions]
CREATE TABLE [dbo].[tblTransactions] (
    [TransactionId]   INT           IDENTITY (1, 1) NOT NULL,
    [DatePosted]      NVARCHAR (50) NULL,
    [Amount]          FLOAT (53)    NULL,
    [Description]     NVARCHAR (50) NULL,
    [CheckNumber]     NVARCHAR(50)           NULL,
    [PayingAccountId] INT           NULL,
    [PayeeAccountId]  INT           NULL,
    PRIMARY KEY CLUSTERED ([TransactionId] ASC)
);


DROP TABLE [dbo].[tblUsers]
CREATE TABLE [dbo].[tblUsers] (
    [UserId]    INT  NOT NULL IDENTITY,
    [FirstName] NVARCHAR (50)  NULL,
    [LastName]  NVARCHAR (50)  NULL,
    [Phone]     NVARCHAR (50)  NULL,
    [Address]   NVARCHAR (50)  NULL,
    [CityId]    INT            NULL,
    [Zip]       NVARCHAR (50)  NULL,
    [Email]     NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


-- Examples
SET IDENTITY_INSERT [dbo].[tblAccounts] ON
INSERT INTO [dbo].[tblAccounts] ([AccountId], [Balance], [UserId], [UserName], [Password]) VALUES (1, 4550, N'1', N'Ido', N'123a')
INSERT INTO [dbo].[tblAccounts] ([AccountId], [Balance], [UserId], [UserName], [Password]) VALUES (2, 350, N'2', N'EatPasta', N'13')
SET IDENTITY_INSERT [dbo].[tblAccounts] OFF
SET IDENTITY_INSERT [dbo].[tblUsers] ON
INSERT INTO [dbo].[tblUsers] ([UserId], [FirstName], [LastName], [Phone], [Address], [CityId], [Zip], [Email]) VALUES (1, N'Ido', N'Eitach', N'0583333333', N'Internet', 3, N'166532', N'ido@gmail.com')
INSERT INTO [dbo].[tblUsers] ([UserId], [FirstName], [LastName], [Phone], [Address], [CityId], [Zip], [Email]) VALUES (2, N'Eat', N'Pasta', N'054675757', N'internet', 3, N'12333', N'EatPasta@gmail.com')
SET IDENTITY_INSERT [dbo].[tblUsers] OFF


-- Stored Procedures
go--at
DROP PROCEDURE [dbo].[spValidateUser]
go--at
CREATE PROCEDURE [dbo].[spValidateUser]
	@UserName NVARCHAR(50),
	@Password NVARCHAR(50)
AS
	Select * FROM tblAccounts
	Where UserName = @UserName COLLATE SQL_Latin1_General_CP1_CS_AS
	And Password = @Password COLLATE SQL_Latin1_General_CP1_CS_AS
RETURN 0


go--at
DROP PROCEDURE [dbo].[spUpdateBalance]
go--at
CREATE PROCEDURE [dbo].[spUpdateBalance]
	@accountId int,
	@newBalance float
AS
 	Update tblAccounts Set Balance = @newBalance where AccountId=@accountId;
RETURN 0


go--at
DROP PROCEDURE [dbo].[spRetrieveBalance]
go--at
CREATE PROCEDURE [dbo].[spRetrieveBalance]
	@accountId int
AS
	Select Balance FROM tblAccounts Where AccountId = @accountId
RETURN 0


go--at
DROP PROCEDURE [dbo].[spInsertTransaction]
go--at
CREATE PROCEDURE [dbo].[spInsertTransaction]
	@date Nvarchar(50),
	@amount float,
	@description Nvarchar(50),
	@checkNumber Nvarchar(50),
	@payingAccountId int,
	@payeeAccountId int 
AS
	insert into tblTransactions (DatePosted, Amount,Description,CheckNumber,PayingAccountId,PayeeAccountId)
	Values(@date , @amount, @description, @checkNumber, @payingAccountId,@payeeAccountId);
RETURN 0


go--at
DROP PROCEDURE [dbo].[spGetTransactions]
go--at
CREATE PROCEDURE [dbo].[spGetTransactions]
	@accountId int 
AS BEGIN
	SELECT * From tblTransactions where PayingAccountId=@accountId or PayeeAccountId=@accountId;
END


go--at
DROP PROCEDURE [dbo].[spGetAllAccountUsernames]
go--at
CREATE PROCEDURE [dbo].[spGetAllAccountUsernames]
AS
	select AccountId, UserName from tblAccounts
RETURN 0


go--at
DROP PROCEDURE [dbo].[spGetAllAccountUsernames]
go--at
CREATE PROCEDURE [dbo].[spGetAllAccountUsernames]
AS
	select AccountId, UserName from tblAccounts
RETURN 0


go--at
DROP PROCEDURE [dbo].[spGetAccountIdByUsername]
go--at
CREATE PROCEDURE [dbo].[spGetAccountIdByUsername]
	@accountUserName NvarChar(50)

AS
	SELECT AccountId from tblAccounts where UserName = @accountUserName  
RETURN 0


go--at
DROP PROCEDURE [dbo].[spGetAccountEmail]
go--at
CREATE PROCEDURE [dbo].[spGetAccountEmail]
	@accountId int
AS
	Select Email FROM tblUsers Where UserId = (Select UserId FROM tblAccounts Where AccountId = @accountId)
RETURN 0

go--at
DROP PROCEDURE [dbo].[spChangeDescription]
go--at
CREATE PROCEDURE [dbo].[spChangeDescription]
	@transactionId int,
	@newDescription Nvarchar(50)
AS
 	Update tblTransactions Set Description = @newDescription where TransactionId=@transactionId;
RETURN 0