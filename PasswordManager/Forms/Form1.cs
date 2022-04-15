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
        public loginForm()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            ljudi = db.prijava();

            int resultEmail = ljudi.FindIndex(x => x.Username == usernameTB.Text);
            int resultLozinka = ljudi.FindIndex(x => x.Password == passwordTB.Text);            

            label1.Text=resultEmail.ToString();
            label2.Text=resultLozinka.ToString();

            if((resultEmail == resultLozinka) && (resultEmail != -1) && (resultLozinka != -1))
            {
                this.Hide();
                MainForm glavna = new MainForm();
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
            MainForm glavna = new MainForm();
            glavna.ShowDialog();
            this.Close();

        }
    }
}