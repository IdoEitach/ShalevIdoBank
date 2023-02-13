CREATE PROCEDURE [dbo].[spGetTransactions]
	@accountId int 
AS BEGIN
	SELECT * From tblTransactions where PayingAccountId=@accountId or PayeeAccountId=@accountId;
END