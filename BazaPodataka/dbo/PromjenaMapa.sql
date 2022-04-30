CREATE PROCEDURE [dbo].[PromjenaMapa]
	@KorisnikID int,
	@Title varchar(50),
	@Username varchar(50),
	@Password varchar(50),
	@URL varchar(50),
	@Notes varchar(50)
	
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
