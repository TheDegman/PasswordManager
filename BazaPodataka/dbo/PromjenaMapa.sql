CREATE PROCEDURE [dbo].[PromjenaMapa]
	@BazaID int,
	@KorisnikID int,
	@Title varchar(50),
	@Username varchar(50),
	@Password VARCHAR (MAX),
	@URL VARCHAR (MAX),
	@Notes VARCHAR (MAX)
	
AS
begin
	SET ROWCOUNT 1
	update Mapa
	set 
		Title=@Title,
		Username=@Username,
		Password=@Password,
		URL=@URL,
		Notes=@Notes
		
	where
		KorisnikID=@KorisnikID And BazaID=@BazaID;
		
		

end		
	 
RETURN 0
