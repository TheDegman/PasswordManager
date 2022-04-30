using PasswordManager.ModelBaze;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Forms;


namespace PasswordManager
{
    public partial class loginForm : Form
    {
        List<Korisnik> ljudi = new List<Korisnik>();
        public static int resultUsername = 0;
        public static int resultPassword = 0;
        public static string Username;
        public static int KorisnikID;
        public loginForm()
        {
            InitializeComponent();
            
           
        }
        

        public void button2_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            ljudi = db.prijava();

            resultUsername = ljudi.FindIndex(x => x.Username == usernameTB.Text);
            resultPassword = ljudi.FindIndex(x => x.Password == passwordTB.Text);

            

            label1.Text = ljudi[resultUsername].Username;
            label2.Text = ljudi[resultPassword].Password;
            

            

            if((resultUsername == resultPassword) && (resultUsername != -1) && (resultPassword != -1))
            {
                Username = usernameTB.Text;
                KorisnikID = ljudi[resultUsername].KorisnikID;


                this.Hide();
                mainForm glavna = new mainForm();
                glavna.ShowDialog();
                this.Close();
                



                

            }
            else
            {
                string message = "Krivi email ili lozinka";
                string title = "Greška";
                MessageBox.Show(message, title);

            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainForm glavna = new mainForm();
            glavna.ShowDialog();
            this.Close();

        }
    }
}