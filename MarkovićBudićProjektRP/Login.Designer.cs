namespace MarkovićBudićProjektRP
{
    partial class Login
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.cbBlagajna = new System.Windows.Forms.CheckBox();
            this.cbObracun = new System.Windows.Forms.CheckBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(122, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(122, 54);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(13, 13);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(13, 54);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // cbBlagajna
            // 
            this.cbBlagajna.AutoSize = true;
            this.cbBlagajna.Location = new System.Drawing.Point(16, 117);
            this.cbBlagajna.Name = "cbBlagajna";
            this.cbBlagajna.Size = new System.Drawing.Size(83, 20);
            this.cbBlagajna.TabIndex = 4;
            this.cbBlagajna.Text = "Blagajna";
            this.cbBlagajna.UseVisualStyleBackColor = true;
            // 
            // cbObracun
            // 
            this.cbObracun.AutoSize = true;
            this.cbObracun.Location = new System.Drawing.Point(105, 117);
            this.cbObracun.Name = "cbObracun";
            this.cbObracun.Size = new System.Drawing.Size(80, 20);
            this.cbObracun.TabIndex = 5;
            this.cbObracun.Text = "Obracun";
            this.cbObracun.UseVisualStyleBackColor = true;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(194, 117);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(67, 20);
            this.cbAdmin.TabIndex = 6;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(300, 108);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(97, 36);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 189);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.cbObracun);
            this.Controls.Add(this.cbBlagajna);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.CheckBox cbBlagajna;
        private System.Windows.Forms.CheckBox cbObracun;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Button btLogin;
    }
}