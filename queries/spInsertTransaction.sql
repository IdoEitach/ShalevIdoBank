CREATE PROCEDURE [dbo].[spInsertTransaction]
	@date Nvarchar(50),
	@amount float,
	@payee Nvarchar(50),
	@accountId int
AS
	insert into tblTransactions (DatePosted, Amount,Payee,AccountId)
	Values(@date , @amount, @payee , @accountId);
RETURN 0