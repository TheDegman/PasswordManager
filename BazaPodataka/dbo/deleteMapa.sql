CREATE PROCEDURE [dbo].[deleteMapa]
	@BazaID int,
	@KorisnikID int
AS
begin
	DELETE FROM Mapa WHERE BazaID=@BazaID and KorisnikID=@KorisnikID;
	
		

end		
	 
RETURN 0

