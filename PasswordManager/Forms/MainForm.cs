using PasswordManager.ModelBaze;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {


        List<Mapa> mapa = new List<Mapa>();
        List<Korisnik> ljudi = new List<Korisnik>();



        int index = 0;
        public static int user_id = 0;
        public static int mapa_id = 0;

        int user_id1 = 0;

        int korisnikID = 0;
        int bazaID = 0;

        int provjeraPostojanja = 0;

        public MainForm()
        {
            InitializeComponent();

            PristupBazi db = new PristupBazi();
            mapa = db.IspisPasswords();
            ljudi = db.prijava();            

            if (loginForm.UserID != -1)
            {
                user_id = loginForm.UserID;
                user_id1 = mapa.FindIndex(x => x.KorisnikID == user_id);
                
                mapa_id = mapa[user_id1].BazaID;
                korisnikToolStripMenuItem.Text = ljudi[user_id1].Username;
            }
            else
            {
                

                user_id = AddEntryForm.user_id;
                user_id1 = mapa.FindIndex(x => x.KorisnikID == user_id);
               
                mapa_id = mapa[user_id1].BazaID;
                korisnikToolStripMenuItem.Text = ljudi[user_id1].Username;

            }

            mapa.RemoveAll(x => x.KorisnikID != user_id);
            dataGridView1.DataSource = mapa;

            

            dataGridView1.Columns["BazaID"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                titleTB.Text = mapa[index].Title;
                usernameTB.Text = mapa[index].Username;
                passwordTB.Text = mapa[index].Password;
                urlTB.Text = mapa[index].URL;
                label8.Text = mapa[index].DateCreated.ToString();
                notesRTB.Text = mapa[index].Notes;
                korisnikID = mapa[index].KorisnikID;
                bazaID = mapa[index].BazaID;
            }
        }

        private void titleTB_DoubleClick(object sender, EventArgs e)
        {
            titleTB.ReadOnly = false;
        }

        private void usernameTB_DoubleClick(object sender, EventArgs e)
        {
            usernameTB.ReadOnly = false;
        }

        private void passwordTB_DoubleClick(object sender, EventArgs e)
        {
            passwordTB.ReadOnly = false;
        }

        private void urlTB_DoubleClick(object sender, EventArgs e)
        {
            urlTB.ReadOnly = false;
        }

        private void notesRTB_DoubleClick(object sender, EventArgs e)
        {
            notesRTB.ReadOnly = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            db.promjenaUnos(bazaID, user_id, titleTB.Text, usernameTB.Text, passwordTB.Text, urlTB.Text, notesRTB.Text);

            mapa = db.IspisPasswords();
            mapa.RemoveAll(x => x.KorisnikID != user_id);
            dataGridView1.DataSource = mapa;

            titleTB.ReadOnly = true;
            usernameTB.ReadOnly = true;
            passwordTB.ReadOnly = true;
            urlTB.ReadOnly = true;
            notesRTB.ReadOnly = true;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                    this.dataGridView1.CurrentCell = clickedCell;

                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

                    this.contextMenuStrip1.Show(dataGridView1, relativeMousePosition);
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lockWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm glavna = new loginForm();
            glavna.ShowDialog();
            this.Close();
        }

        private void copyUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text != "")
            {
                Clipboard.SetText(usernameTB.Text);
            }
        }

        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text != "")
            {
                Clipboard.SetText(passwordTB.Text);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urlTB.Text != "")
            {
                Clipboard.SetText(urlTB.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(urlTB.Text, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            string url = urlTB.Text;
            if (urlTB.Text != "" && result == true)
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = urlTB.Text,
                    UseShellExecute = true
                };
                Process.Start(psInfo);

            }
            else
            {
                string message = "Invalid URL";
                string title = "Error";
                passwordTB.Text = null;
                MessageBox.Show(message, title);
            }
        }
        private void copyUserNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text != "")
            {
                Clipboard.SetText(usernameTB.Text);
            }
        }

        private void copyPasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text != "")
            {
                Clipboard.SetText(passwordTB.Text);
            }
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(urlTB.Text, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            
            string url = urlTB.Text;
            if (urlTB.Text != "" && result==true)
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = urlTB.Text,
                    UseShellExecute = true
                };
                Process.Start(psInfo);

            }
            else
            {
                string message = "Invalid URL";
                string title = "Error";
                passwordTB.Text = null;
                MessageBox.Show(message, title);
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (urlTB.Text != "")
            {
                Clipboard.SetText(urlTB.Text);
            }
        }
        private void addEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEntryForm glavna = new AddEntryForm();
            glavna.ShowDialog();
            this.Close();
        }

        private void deleteEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PristupBazi db = new PristupBazi();
            db.deleteMapa(bazaID, user_id);

            mapa = db.IspisPasswords();
            mapa.RemoveAll(x => x.KorisnikID != user_id);
            dataGridView1.DataSource = mapa;
        }
        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEntryForm glavna = new AddEntryForm();
            glavna.ShowDialog();
            this.Close();
        }


    }
}
