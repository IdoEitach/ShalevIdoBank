CREATE TABLE [dbo].[tblAccounts] (
    [AccountId] INT           IDENTITY (1, 1) NOT NULL,
    [Balance]   FLOAT (53)    NULL,
    [UserId]    NVARCHAR (50) NULL,
    [UserName]  NVARCHAR (50) NULL UNIQUE,
    [Password]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AccountId] ASC)
);

CREATE TABLE [dbo].[tblCities] (
    [CityId]   INT           NOT NULL,
    [CityName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CityId] ASC)
);

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
INSERT INTO [dbo].[tblAccounts] ([AccountId], [Balance], [UserId], [UserName], [Password]) VALUES (1, 4550, N'1', N'Ido', N'123a')
INSERT INTO [dbo].[tblAccounts] ([AccountId], [Balance], [UserId], [UserName], [Password]) VALUES (2, 350, N'2', N'EatPasta', N'13')
INSERT INTO [dbo].[tblUsers] ([UserId], [FirstName], [LastName], [Phone], [Address], [CityId], [Zip], [Email]) VALUES (1, N'Ido', N'Eitach', N'0583333333', N'Internet', 3, N'166532', N'ido@gmail.com')
INSERT INTO [dbo].[tblUsers] ([UserId], [FirstName], [LastName], [Phone], [Address], [CityId], [Zip], [Email]) VALUES (2, N'Eat', N'Pasta', N'054675757', N'internet', 3, N'12333', N'EatPasta@gmail.com')
