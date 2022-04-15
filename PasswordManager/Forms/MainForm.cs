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
    public partial class MainForm : Form
    {
        List<Mapa> mapa = new List<Mapa>();
        
        int index = 0;

        public MainForm()
        {
            InitializeComponent();
            PristupBazi db = new PristupBazi();
            mapa = db.IspisPasswords();
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

        }
    }
}
