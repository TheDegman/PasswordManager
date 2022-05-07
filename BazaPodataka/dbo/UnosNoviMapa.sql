CREATE PROCEDURE [dbo].[UnosNoviMapa]
	@KorisnikID int,
	@Title varchar(50),
	@Username varchar(50),
	@Password VARCHAR (MAX),
	@URL VARCHAR (MAX),
	@Notes VARCHAR (MAX),
	@DateCreated datetime,
	@DateExpires datetime
	
AS
begin
	insert into dbo.[Mapa] (KorisnikID, Title, Username, Password, URL, Notes, DateCreated, DateExpires)
	values(@KorisnikID, @Title, @Username, @Password, @URL, @Notes, @DateCreated, @DateExpires)
	

end			 
RETURN 0
