using System.Data;
using System.Text;
using System.Security.Cryptography;
using PasswordManager.ModelBaze;

namespace PasswordManager.Forms
{

    public partial class AddEntryForm : Form
    {
        
        /// Password generators

        public string GenerateToken(int length)
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer);
            }
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static string GetRandomMacAddress()
        {
            var random = new Random();
            var buffer = new byte[6];
            random.NextBytes(buffer);
            var result = String.Concat(buffer.Select(x => string.Format("{0}:", x.ToString("X2"))).ToArray());
            return result.TrimEnd(':');
        }

        ///


        public static int user_id = 0;
        public static int mapa_id = 0;



        public AddEntryForm()
        {
            InitializeComponent();
            user_id=MainForm.user_id;
            mapa_id=MainForm.mapa_id;
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            PristupBazi db=new PristupBazi();
            db.unosNoviMapa(user_id, titleTB.Text, usernameTB.Text, passwordTB1.Text, urlTB.Text, notesRTB.Text);
            this.Hide();
            MainForm glavna = new MainForm();
            glavna.ShowDialog();
            this.Close();

        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        

        private void AddEntryForm_Load(object sender, EventArgs e)
        {

            passwordTB1.Text = CreatePassword(20);
            passwordTB2.Text = passwordTB1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(passwordTB2.Enabled == false)
            {
                passwordTB1.UseSystemPasswordChar = true;
                label4.Enabled = true;
                passwordTB2.Enabled = true;
                passwordTB2.Text = passwordTB1.Text;
            }
            else
            {
                passwordTB1.UseSystemPasswordChar = false;
                label4.Enabled = false;
                passwordTB2.Enabled = false;
                passwordTB2.Text = null;
            }
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            contextMenuStrip1.Show(passwordsBTN, new Point(0,passwordsBTN.Height));
        }

        private void hexKey40BitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordTB1.Text=CreatePassword(10);
            passwordTB2.Text = passwordTB1.Text;
        }

        private void hexKey40BitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            passwordTB1.Text = CreatePassword(32);
            passwordTB2.Text = passwordTB1.Text;
        }

        private void hexKey40BitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            passwordTB1.Text = CreatePassword(64);
            passwordTB2.Text = passwordTB1.Text;

        }

        private void randomMACAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordTB1.Text=GetRandomMacAddress();
            passwordTB2.Text = passwordTB1.Text;
        }

        

        private void passwordTB1_TextChanged(object sender, EventArgs e)
        {
            passwordTB2.Text=passwordTB1.Text;
        }

        private void openPasswordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
