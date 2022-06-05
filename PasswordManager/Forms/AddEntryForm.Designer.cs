namespace PasswordManager.Forms
{
    partial class AddEntryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntryForm));
            this.okBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB1 = new System.Windows.Forms.TextBox();
            this.passwordTB2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.notesRTB = new System.Windows.Forms.RichTextBox();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.revealBTN = new System.Windows.Forms.Button();
            this.passwordsBTN = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hexKey40BitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexKey40BitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hexKey40BitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.randomMACAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(295, 389);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 23);
            this.okBTN.TabIndex = 0;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(376, 389);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 1;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Repeat:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(141, 63);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(246, 23);
            this.usernameTB.TabIndex = 7;
            // 
            // passwordTB1
            // 
            this.passwordTB1.Location = new System.Drawing.Point(141, 96);
            this.passwordTB1.Name = "passwordTB1";
            this.passwordTB1.Size = new System.Drawing.Size(246, 23);
            this.passwordTB1.TabIndex = 8;
            this.passwordTB1.UseSystemPasswordChar = true;
            this.passwordTB1.TextChanged += new System.EventHandler(this.passwordTB1_TextChanged);
            // 
            // passwordTB2
            // 
            this.passwordTB2.Location = new System.Drawing.Point(141, 135);
            this.passwordTB2.Name = "passwordTB2";
            this.passwordTB2.PasswordChar = '*';
            this.passwordTB2.ReadOnly = true;
            this.passwordTB2.Size = new System.Drawing.Size(246, 23);
            this.passwordTB2.TabIndex = 9;
            this.passwordTB2.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes:";
            // 
            // notesRTB
            // 
            this.notesRTB.Location = new System.Drawing.Point(141, 214);
            this.notesRTB.Name = "notesRTB";
            this.notesRTB.Size = new System.Drawing.Size(246, 137);
            this.notesRTB.TabIndex = 13;
            this.notesRTB.Text = "";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(141, 174);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(246, 23);
            this.urlTB.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(141, 30);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(246, 23);
            this.titleTB.TabIndex = 6;
            // 
            // revealBTN
            // 
            this.revealBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("revealBTN.BackgroundImage")));
            this.revealBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.revealBTN.Location = new System.Drawing.Point(400, 96);
            this.revealBTN.Name = "revealBTN";
            this.revealBTN.Size = new System.Drawing.Size(26, 23);
            this.revealBTN.TabIndex = 18;
            this.revealBTN.UseVisualStyleBackColor = true;
            this.revealBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordsBTN
            // 
            this.passwordsBTN.AllowDrop = true;
            this.passwordsBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordsBTN.BackgroundImage")));
            this.passwordsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passwordsBTN.ContextMenuStrip = this.contextMenuStrip1;
            this.passwordsBTN.Location = new System.Drawing.Point(400, 135);
            this.passwordsBTN.Name = "passwordsBTN";
            this.passwordsBTN.Size = new System.Drawing.Size(26, 23);
            this.passwordsBTN.TabIndex = 19;
            this.passwordsBTN.UseVisualStyleBackColor = true;
            this.passwordsBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.hexKey40BitToolStripMenuItem,
            this.hexKey40BitToolStripMenuItem1,
            this.hexKey40BitToolStripMenuItem2,
            this.randomMACAddressToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 98);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // hexKey40BitToolStripMenuItem
            // 
            this.hexKey40BitToolStripMenuItem.Name = "hexKey40BitToolStripMenuItem";
            this.hexKey40BitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.hexKey40BitToolStripMenuItem.Text = "Hex Key - 40-Bit";
            this.hexKey40BitToolStripMenuItem.Click += new System.EventHandler(this.hexKey40BitToolStripMenuItem_Click);
            // 
            // hexKey40BitToolStripMenuItem1
            // 
            this.hexKey40BitToolStripMenuItem1.Name = "hexKey40BitToolStripMenuItem1";
            this.hexKey40BitToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.hexKey40BitToolStripMenuItem1.Text = "Hex Key - 128-Bit";
            this.hexKey40BitToolStripMenuItem1.Click += new System.EventHandler(this.hexKey40BitToolStripMenuItem1_Click);
            // 
            // hexKey40BitToolStripMenuItem2
            // 
            this.hexKey40BitToolStripMenuItem2.Name = "hexKey40BitToolStripMenuItem2";
            this.hexKey40BitToolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.hexKey40BitToolStripMenuItem2.Text = "Hex Key - 256-Bit";
            this.hexKey40BitToolStripMenuItem2.Click += new System.EventHandler(this.hexKey40BitToolStripMenuItem2_Click);
            // 
            // randomMACAddressToolStripMenuItem
            // 
            this.randomMACAddressToolStripMenuItem.Name = "randomMACAddressToolStripMenuItem";
            this.randomMACAddressToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.randomMACAddressToolStripMenuItem.Text = "Random MAC Address";
            this.randomMACAddressToolStripMenuItem.Click += new System.EventHandler(this.randomMACAddressToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 414);
            this.ControlBox = false;
            this.Controls.Add(this.passwordsBTN);
            this.Controls.Add(this.revealBTN);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.notesRTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordTB2);
            this.Controls.Add(this.passwordTB1);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.AddEntryForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button okBTN;
        private Button cancelBTN;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox usernameTB;
        private TextBox passwordTB1;
        private TextBox passwordTB2;
        private Label label6;
        private Label label7;
        private RichTextBox notesRTB;
        private TextBox urlTB;
        private Label label1;
        private TextBox titleTB;
        private Button revealBTN;
        private Button passwordsBTN;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem hexKey40BitToolStripMenuItem;
        private ToolStripMenuItem hexKey40BitToolStripMenuItem1;
        private ToolStripMenuItem hexKey40BitToolStripMenuItem2;
        private ToolStripMenuItem randomMACAddressToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private ToolStripSeparator toolStripSeparator1;
    }
}