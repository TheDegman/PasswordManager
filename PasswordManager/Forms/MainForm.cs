using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.ModelBaze;

namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        List<Mapa> mapa = new List<Mapa>();
        List<Korisnik> ljudi = new List<Korisnik>();

        int index = 0;
        int user_id = 0;

        public MainForm()
        {
            InitializeComponent();
            PristupBazi db = new PristupBazi();
            mapa = db.IspisPasswords();
            dataGridView1.DataSource = mapa;

            user_id = loginForm.UserID;
            mapa.RemoveAll(x => x.KorisnikID != user_id);
            label7.Text = user_id.ToString();


            ljudi =db.IspisUsers();            
            

            if (user_id >= 0)
            {
                
                korisnikToolStripMenuItem.Text = ljudi[user_id].Username;

            }

            

            dataGridView1.Columns["BazaID"].Visible = false;            
            dataGridView1.Columns["DateExpires"].Visible = false;
            
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
                label8.Text= mapa[index].DateCreated.ToString();
                notesRTB.Text = mapa[index].Notes;

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
            
                string message = "Krivi email ili lozinka";
                string title = "Greška";

            
                PristupBazi db = new PristupBazi();
                db.promjenaUnos(user_id, titleTB.Text, usernameTB.Text, passwordTB.Text, urlTB.Text, notesRTB.Text);

                mapa = db.IspisPasswords();

                dataGridView1.DataSource = mapa;

                user_id = loginForm.UserID;

                mapa.RemoveAll(x => x.KorisnikID != user_id);

                label7.Text = user_id.ToString();

                dataGridView1.Columns["BazaID"].Visible = false;
                dataGridView1.Columns["DateExpires"].Visible = false;

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

                    // Here you can do whatever you want with the cell
                    this.dataGridView1.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

                    // Show the context menu
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
            

            if (urlTB.Text != "")
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = urlTB.Text,
                    UseShellExecute = true
                };
                Process.Start(psInfo);

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

        }

        private void deleteEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
