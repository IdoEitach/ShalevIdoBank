CREATE PROCEDURE [dbo].[spInsertTransaction]
	@date Nvarchar(50),
	@amount float,
	@description Nvarchar(50),
	@payingAccountId int,
	@payeeAccountId int 
AS
	insert into tblTransactions (DatePosted, Amount,Description,PayingAccountId,PayeeAccountId)
	Values(@date , @amount, @description , @payingAccountId,@payeeAccountId);
RETURN 0