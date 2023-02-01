CREATE PROCEDURE [dbo].[spGetTransactions]
	@payingAccountId int 
AS BEGIN
	SELECT * From tblTransactions where PayingAccountId=@payingAccountId;
END