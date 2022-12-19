CREATE PROCEDURE [dbo].[spGetAccountEmail]
	@accountId int
AS
	Select Email FROM tblUsers Where UserId = (Select UserId FROM tblAccounts Where AccountId = @accountId)
RETURN 0
