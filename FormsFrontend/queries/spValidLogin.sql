CREATE PROCEDURE [dbo].[spValidLogin]
	@username NVARCHAR(50),
	@password NVARCHAR(50)
AS
	SELECT * FROM Workers WHERE Username = @username AND Password = @password
RETURN 0
