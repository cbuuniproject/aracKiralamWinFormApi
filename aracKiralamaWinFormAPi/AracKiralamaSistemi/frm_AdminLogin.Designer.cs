namespace AracKiralamaSistemi
{
    partial class frm_AdminLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 85);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanici Adi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(101, 117);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(259, 81);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(249, 22);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(259, 113);
			this.txtPass.Margin = new System.Windows.Forms.Padding(4);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(249, 22);
			this.txtPass.TabIndex = 3;
			// 
			// btnGiris
			// 
			this.btnGiris.Location = new System.Drawing.Point(355, 164);
			this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(155, 79);
			this.btnGiris.TabIndex = 4;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// frm_AdminLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 309);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_AdminLogin";
			this.Text = "Admin Girişi";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnGiris;
    }
}