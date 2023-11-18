namespace MarkovićBudićProjektRP
{
    partial class Main
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
            this.btBlagajna = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btObracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBlagajna
            // 
            this.btBlagajna.Location = new System.Drawing.Point(30, 91);
            this.btBlagajna.Name = "btBlagajna";
            this.btBlagajna.Size = new System.Drawing.Size(75, 44);
            this.btBlagajna.TabIndex = 0;
            this.btBlagajna.Text = "Blagajna";
            this.btBlagajna.UseVisualStyleBackColor = true;
            this.btBlagajna.Click += new System.EventHandler(this.btBlagajna_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.Location = new System.Drawing.Point(159, 88);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(75, 47);
            this.btAdmin.TabIndex = 1;
            this.btAdmin.Text = "Admin";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btObracun
            // 
            this.btObracun.Location = new System.Drawing.Point(285, 91);
            this.btObracun.Name = "btObracun";
            this.btObracun.Size = new System.Drawing.Size(75, 44);
            this.btObracun.TabIndex = 2;
            this.btObracun.Text = "Obracun";
            this.btObracun.UseVisualStyleBackColor = true;
            this.btObracun.Click += new System.EventHandler(this.btObracun_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.btObracun);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.btBlagajna);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBlagajna;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btObracun;
    }
}

