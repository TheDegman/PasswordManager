﻿using System;
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
        int user_id = 0;

        public MainForm()
        {
            InitializeComponent();
            PristupBazi db = new PristupBazi();
            mapa = db.IspisPasswords();

            dataGridView1.DataSource = mapa;

            user_id = loginForm.UserID;

            mapa.RemoveAll(x => x.KorisnikID != user_id);

            label7.Text=user_id.ToString();

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
            PristupBazi db = new PristupBazi();
            db.promjenaUnos(user_id, titleTB.Text, usernameTB.Text, passwordTB.Text, urlTB.Text,notesRTB.Text);

            mapa = db.IspisPasswords();

            dataGridView1.DataSource = mapa;

            user_id = loginForm.UserID;

            mapa.RemoveAll(x => x.KorisnikID != user_id);

            label7.Text = user_id.ToString();

            dataGridView1.Columns["BazaID"].Visible = false;
            dataGridView1.Columns["DateExpires"].Visible = false;

            titleTB.ReadOnly=true;
            usernameTB.ReadOnly=true;
            passwordTB.ReadOnly=true;
            urlTB.ReadOnly=true;
            notesRTB.ReadOnly=true;

        }
    }
}
