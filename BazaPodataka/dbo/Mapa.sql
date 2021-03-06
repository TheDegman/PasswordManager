CREATE TABLE [dbo].[Mapa] (
    [BazaID]      INT           IDENTITY (0, 1) NOT NULL,
    [KorisnikID]  INT           NOT NULL,
    [Title]       VARCHAR (50)  NOT NULL,
    [Username]    VARCHAR (50)  NOT NULL,
    [Password]    VARCHAR (MAX)  NOT NULL,
    [URL]         VARCHAR (MAX)  NOT NULL,
    [Notes]       VARCHAR (MAX) NOT NULL,
    [DateCreated] DATETIME      NOT NULL,
    CONSTRAINT [PK_Baza] PRIMARY KEY CLUSTERED ([BazaID] ASC),
    CONSTRAINT [FK_Baza_Korisnik] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnik] ([KorisnikID])
);

