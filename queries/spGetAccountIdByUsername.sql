CREATE PROCEDURE [dbo].[spGetAccountIdByUsername]
	@accountUserName NvarChar(50)

AS
	SELECT AccountId from tblAccounts where UserName = @accountUserName  
RETURN 0
