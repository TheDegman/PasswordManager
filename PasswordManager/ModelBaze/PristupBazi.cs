using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace PasswordManager.ModelBaze
{
    class PristupBazi
    {

        public List<Korisnik> prijava()
        {
            using (IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;"))
            {

                var a = connection.Query<Korisnik>("SELECT * FROM BazaPodatakaPasswordManager.dbo.Korisnik").ToList();

                return a;
            }
        }
        public List<Mapa> IspisPasswords()
        {
            using (IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;"))
            {

                var a = connection.Query<Mapa>("SELECT * FROM BazaPodatakaPasswordManager.dbo.Mapa").ToList();

                return a;
            }
        }

       

        public void promjenaUnos(int BazaID, int KorisnikID,string Title, string Username, string Password, string URL, string Notes)
        {
            using IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;");
            List<Mapa> mapaList = new List<Mapa>();
            mapaList.Add(new Mapa { BazaID=BazaID, KorisnikID = KorisnikID ,Title = Title, Username = Username, Password = Password, URL = URL, Notes=Notes});
            connection.Execute("dbo.PromjenaMapa @BazaID ,@KorisnikID, @Title, @Username, @Password, @URL, @Notes",mapaList);


        }

        //unos novi korisnik
        public void unosNoviUser(string Username, string Password)
        {
            using IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;");
            List<Korisnik> user = new List<Korisnik>();
            user.Add(new Korisnik { Username = Username, Password = Password });
            connection.Execute("dbo.UnosNoviUser @Username, @Password",user);

        }

        //unos novi mapa
        public void unosNoviMapa(int KorisnikID, string Title, string Username, string Password, string URL, string Notes)
        {
            using IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;");
            List<Mapa> polje = new List<Mapa>();
            polje.Add(new Mapa {KorisnikID=KorisnikID, Title=Title,Username=Username,Password=Password,URL=URL,Notes=Notes,DateCreated=DateTime.Now});
            connection.Execute("dbo.UnosNoviMapa @KorisnikID, @Title, @Username, @Password, @URL, @Notes, @DateCreated", polje);

        }

        public void deleteMapa(int BazaID, int KorisnikID)
        {
            using IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;");
            List<delete> polje = new List<delete>();
            polje.Add(new delete { BazaID=BazaID, KorisnikID=KorisnikID });
            connection.Execute("dbo.deleteMapa @BazaID, @KorisnikID", polje);

        }
    }
}
