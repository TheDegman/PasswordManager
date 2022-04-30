using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.ModelBaze
{
    class Korisnik
    {
        public int KorisnikID { get; set; }
        public string Username { get; set; }
        public string UsernameIspis
        {
            get { return $"{Username}"; }
        }
        public string Password { get; set; }
        public string Info
        {
            get { return $"{Username} {Password}"; }
        }
    }
}
