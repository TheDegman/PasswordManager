namespace PasswordManager
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.newBTN = new System.Windows.Forms.Button();
            this.revealBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(116, 63);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(254, 23);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(206, 135);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(109, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "OK";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // usernameTB
            // 
            this.usernameTB.BackColor = System.Drawing.Color.White;
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTB.ForeColor = System.Drawing.Color.Black;
            this.usernameTB.Location = new System.Drawing.Point(116, 21);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(254, 23);
            this.usernameTB.TabIndex = 7;
            // 
            // newBTN
            // 
            this.newBTN.Location = new System.Drawing.Point(321, 135);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(109, 23);
            this.newBTN.TabIndex = 8;
            this.newBTN.Text = "Create User";
            this.newBTN.UseVisualStyleBackColor = true;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // revealBTN
            // 
            this.revealBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("revealBTN.BackgroundImage")));
            this.revealBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.revealBTN.Location = new System.Drawing.Point(393, 62);
            this.revealBTN.Name = "revealBTN";
            this.revealBTN.Size = new System.Drawing.Size(26, 23);
            this.revealBTN.TabIndex = 19;
            this.revealBTN.UseVisualStyleBackColor = true;
            this.revealBTN.Click += new System.EventHandler(this.revealBTN_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(0, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 1);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(442, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revealBTN);
            this.Controls.Add(this.newBTN);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Text = "PasswordManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox passwordTB;
        private Button loginBtn;
        private Label label1;
        private TextBox usernameTB;
        private Button newBTN;
        private Button revealBTN;
        private Label label3;
    }
}