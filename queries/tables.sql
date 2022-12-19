CREATE TABLE [dbo].[tblAccounts] (
    [AccountId] INT           NOT NULL,
    [Balance]   FLOAT (53)    NULL,
    [UserId]    NVARCHAR (50) NULL,
    [UserName]  NVARCHAR (50) NULL,
    [Password]  NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AccountId] ASC)
);

CREATE TABLE [dbo].[tblCities] (
    [CityId]   INT           NOT NULL,
    [CityName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CityId] ASC)
);

CREATE TABLE [dbo].[tblTransactions] (
    [TransactionId] INT           NOT NULL IDENTITY,
    [DatePosted]    NVARCHAR (50) NULL,
    [Amount]        FLOAT (53)    NULL,
    [Payee]         NVARCHAR (50) NULL,
    [CheckNumber]   INT           NULL,
    [AccountId]     INT           NULL,
    PRIMARY KEY CLUSTERED ([TransactionId] ASC)
);

CREATE TABLE [dbo].[tblUsers] (
    [UserId]    NVARCHAR (50) NOT NULL,
    [FirstName] NVARCHAR (50) NULL,
    [LastName]  NVARCHAR (50) NULL,
    [Phone]     NVARCHAR (50) NULL,
    [Address]   NVARCHAR (50) NULL,
    [CityId]    INT           NULL,
    [Zip]       NVARCHAR (50) NULL,
    [Email]     NVARCHAR(100) NULL, 
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);
