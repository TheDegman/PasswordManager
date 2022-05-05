CREATE PROCEDURE [dbo].[UnosNoviUser]
	@Username varchar(50),
	@Password varchar(50)
	
AS
begin
	insert into dbo.[Korisnik] (Username, Password)
	values (@Username, @Password)
	

end			 
RETURN 0
