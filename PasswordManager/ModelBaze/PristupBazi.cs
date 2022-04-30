﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void promjenaUnos(int KorisnikID,string Title, string Username, string Password, string URL, string Notes)
        {
            using IDbConnection connection = new SqlConnection("Server = 192.168.1.17; Database = BazaPodatakaPasswordManager; User Id = dorian; Password = lozinka;");
            List<Mapa> mapaList = new List<Mapa>();
            mapaList.Add(new Mapa {KorisnikID = KorisnikID ,Title = Title, Username = Username, Password = Password, URL = URL, Notes=Notes});
            connection.Execute("dbo.PromjenaMapa @KorisnikID, @Title, @Username, @Password, @URL, @Notes",mapaList);


        }
    }
}
