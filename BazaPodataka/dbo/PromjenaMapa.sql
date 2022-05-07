CREATE PROCEDURE [dbo].[PromjenaMapa]
	@KorisnikID int,
	@Title varchar(50),
	@Username varchar(50),
	@Password VARCHAR (MAX),
	@URL VARCHAR (MAX),
	@Notes VARCHAR (MAX)
	
AS
begin
	update Mapa
	set 
		Title=@Title,
		Username=@Username,
		Password=@Password,
		URL=@URL,
		Notes=@Notes
		
	where
		KorisnikID=@KorisnikID;

end		
	 
RETURN 0
