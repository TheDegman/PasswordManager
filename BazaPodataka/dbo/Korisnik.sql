CREATE TABLE [dbo].[Korisnik] (
    [KorisnikID] INT          IDENTITY (0, 1) NOT NULL,
    [Username]   VARCHAR (50) NOT NULL,
    [Password]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED ([KorisnikID] ASC)
);


