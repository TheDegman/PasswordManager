using PasswordManager.ModelBaze;

namespace PasswordManager.Forms
{
    public partial class registracijaForm : Form
    {
        List<Korisnik> ljudi = new List<Korisnik>();
        int user_id=0;
        public registracijaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            ljudi = db.prijava();
            if (ljudi.Exists(x => x.Username == usernameTB.Text) == true)
            {
                string message = "Username already exists";
                string title = "Error";
                usernameTB.Text = null;
                passwordTB1.Text = null;
                passwordTB2.Text = null;
                MessageBox.Show(message, title);
            }
            else {

                if (passwordTB1.Text == passwordTB2.Text && passwordTB1.Text != "" && passwordTB2.Text != "")
                {



                    db.unosNoviUser(usernameTB.Text, passwordTB1.Text);
                    ljudi = db.prijava();
                    user_id = ljudi.FindIndex(x => x.Username == usernameTB.Text);
                    db.unosNoviMapa(ljudi[user_id].KorisnikID, "First Entry", "Username", "Password", "https://www.google.hr/", "Notes");
                    this.Hide();
                    loginForm glavna = new loginForm();
                    glavna.ShowDialog();
                    this.Close();




                }
                

                
                else
                {
                    string message = "Passwords don't match";
                    string title = "Error";
                    passwordTB1.Text = null;
                    passwordTB2.Text = null;
                    MessageBox.Show(message, title);

                }
            }
        }
    }
}
