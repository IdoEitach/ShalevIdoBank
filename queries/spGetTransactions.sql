CREATE PROCEDURE [dbo].[spGetTransactions]
	@accountId int 
AS BEGIN
	SELECT * From tblTransactions where AccountId=@accountId;
END