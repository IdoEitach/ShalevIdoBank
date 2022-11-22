CREATE PROCEDURE [dbo].[spRetrieveBalance]
	@accountId int
AS
	Select Balance FROM tblAccounts Where AccountId = @accountId
RETURN 0