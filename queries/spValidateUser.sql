CREATE PROCEDURE [dbo].[spValidateUser]
	@UserName NVARCHAR(50),
	@Password NVARCHAR(50)
AS
	Select * FROM tblAccounts Where UserName = @UserName And Password = @PassWord
RETURN 0