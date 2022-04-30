using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.ModelBaze;

namespace PasswordManager.Forms
{
    public partial class mainForm : Form
    {
        List<Mapa> mapa = new List<Mapa>();
        List<Mapa> mapa1 = new List<Mapa>();
        List<Korisnik> korisnik = new List<Korisnik>();
        
        int index = 0;
        int korisnikID=0;
        


        public mainForm()
        {
            InitializeComponent();       
            Update();
            

            
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
           
            korisnikID = loginForm.KorisnikID;
        }
        public void Update()
        {
            PristupBazi db = new PristupBazi();
            mapa = db.IspisPasswords();

            //for (int i = 0; i < mapa.Count; i++)
            //{
            //    if (korisnikID == mapa[i].KorisnikID)
            //    {
            //        mapa.RemoveAt(i);
            //    }

            //}

            korisnikToolStripMenuItem.Text=korisnikID.ToString();

            dataGridView1.DataSource = mapa;
            
            dataGridView1.Columns["BazaID"].Visible = false;
            dataGridView1.Columns["DateExpires"].Visible = false;
            dataGridView1.Columns["KorisnikID"].Visible = false;

            

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
                datecreatedLB.Text = mapa[index].DateCreated.ToString();
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

       

        private void saveBTN_Click_1(object sender, EventArgs e)
        {
            titleTB.ReadOnly = true;
            usernameTB.ReadOnly = true;
            passwordTB.ReadOnly = true;
            urlTB.ReadOnly = true;
            notesRTB.ReadOnly=true;
            Update();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lockWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.ShowDialog();
            this.Close();
        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
