using PasswordManager.ModelBaze;

namespace PasswordManager.Forms
{
    public partial class registracijaForm : Form
    {
        public registracijaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTB1.Text == passwordTB2.Text && passwordTB1.Text!="" && passwordTB2.Text!="")
            {
               
                PristupBazi db = new PristupBazi();
                db.unosNoviUser(usernameTB.Text, passwordTB1.Text);
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
