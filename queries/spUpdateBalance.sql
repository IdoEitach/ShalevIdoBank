CREATE PROCEDURE [dbo].[spUpdateBalance]
	@accountId int,
	@newBalance float
AS
 	Update tblAccounts Set Balance = @newBalance where AccountId=@accountId;
RETURN 0