namespace PasswordManager.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datecreatedLB = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.notesRTB = new System.Windows.Forms.RichTextBox();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.lockWorkspaceToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lockWorkspaceToolStripMenuItem
            // 
            this.lockWorkspaceToolStripMenuItem.Name = "lockWorkspaceToolStripMenuItem";
            this.lockWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.lockWorkspaceToolStripMenuItem.Text = "Lock Workspace";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.datecreatedLB);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.notesRTB);
            this.panel1.Controls.Add(this.urlTB);
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Controls.Add(this.usernameTB);
            this.panel1.Controls.Add(this.titleTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 435);
            this.panel1.TabIndex = 1;
            // 
            // datecreatedLB
            // 
            this.datecreatedLB.AutoSize = true;
            this.datecreatedLB.Location = new System.Drawing.Point(737, 146);
            this.datecreatedLB.Name = "datecreatedLB";
            this.datecreatedLB.Size = new System.Drawing.Size(38, 15);
            this.datecreatedLB.TabIndex = 14;
            this.datecreatedLB.Text = "label7";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(789, 307);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // notesRTB
            // 
            this.notesRTB.Location = new System.Drawing.Point(737, 176);
            this.notesRTB.Name = "notesRTB";
            this.notesRTB.ReadOnly = true;
            this.notesRTB.Size = new System.Drawing.Size(225, 96);
            this.notesRTB.TabIndex = 12;
            this.notesRTB.Text = "";
            this.notesRTB.DoubleClick += new System.EventHandler(this.notesRTB_DoubleClick);
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(737, 107);
            this.urlTB.Name = "urlTB";
            this.urlTB.ReadOnly = true;
            this.urlTB.Size = new System.Drawing.Size(225, 23);
            this.urlTB.TabIndex = 10;
            this.urlTB.DoubleClick += new System.EventHandler(this.urlTB_DoubleClick);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(737, 72);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.ReadOnly = true;
            this.passwordTB.Size = new System.Drawing.Size(225, 23);
            this.passwordTB.TabIndex = 9;
            this.passwordTB.DoubleClick += new System.EventHandler(this.passwordTB_DoubleClick);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(737, 44);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = true;
            this.usernameTB.Size = new System.Drawing.Size(225, 23);
            this.usernameTB.TabIndex = 8;
            this.usernameTB.DoubleClick += new System.EventHandler(this.usernameTB_DoubleClick);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(737, 10);
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(225, 23);
            this.titleTB.TabIndex = 7;
            this.titleTB.DoubleClick += new System.EventHandler(this.titleTB_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(644, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem korisnikToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem lockWorkspaceToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label datecreatedLB;
        private Button saveBtn;
        private RichTextBox notesRTB;
        private TextBox urlTB;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private TextBox titleTB;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
    }
}