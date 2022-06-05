using PasswordManager.Forms;
using PasswordManager.ModelBaze;


namespace PasswordManager
{
    public partial class loginForm : Form
    {
        List<Korisnik> ljudi = new List<Korisnik>();
        public static int UserID = 0;

        public loginForm()
        {
            InitializeComponent();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            ljudi = db.prijava();

            int resultUsername = ljudi.FindIndex(x => x.Username == usernameTB.Text);
            int resultLozinka = ljudi.FindIndex(x => x.Password == passwordTB.Text);

            label1.Text = resultUsername.ToString();
            label2.Text = resultLozinka.ToString();


            if ((resultUsername == resultLozinka && resultUsername >= 0) && (resultLozinka == resultUsername && resultLozinka >= 0))
            {
                UserID = ljudi[resultLozinka].KorisnikID;
                this.Hide();
                MainForm forma = new MainForm();
                forma.ShowDialog();
                this.Close();
                

            }
            else
            {
                string message = "Wrong username or password";
                string title = "Error";
                passwordTB.Text = null;
                MessageBox.Show(message, title);

            }
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            registracijaForm glavna = new registracijaForm();
            glavna.ShowDialog();
            this.Close();
        }

        private void revealBTN_Click(object sender, EventArgs e)
        {
            if (passwordTB.UseSystemPasswordChar==true)
            {
                passwordTB.UseSystemPasswordChar = false;
               
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
                
            }
        }
    }
}