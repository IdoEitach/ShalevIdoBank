CREATE PROCEDURE [dbo].[spGetAllAccountUsernames]
AS
	select AccountId, UserName from tblAccounts
RETURN 0
