namespace AracKiralamaSistemi
{
    partial class frm_RolEkle
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
			this.txtRolAd = new System.Windows.Forms.TextBox();
			this.btnRolEkle = new System.Windows.Forms.Button();
			this.lblRolAd = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRolAd
			// 
			this.txtRolAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtRolAd.Location = new System.Drawing.Point(148, 90);
			this.txtRolAd.Margin = new System.Windows.Forms.Padding(4);
			this.txtRolAd.Name = "txtRolAd";
			this.txtRolAd.Size = new System.Drawing.Size(180, 26);
			this.txtRolAd.TabIndex = 0;
			// 
			// btnRolEkle
			// 
			this.btnRolEkle.Location = new System.Drawing.Point(181, 143);
			this.btnRolEkle.Margin = new System.Windows.Forms.Padding(4);
			this.btnRolEkle.Name = "btnRolEkle";
			this.btnRolEkle.Size = new System.Drawing.Size(103, 47);
			this.btnRolEkle.TabIndex = 1;
			this.btnRolEkle.Text = "Rol Ekle";
			this.btnRolEkle.UseVisualStyleBackColor = true;
			this.btnRolEkle.Click += new System.EventHandler(this.btnRolEkle_ClickAsync);
			// 
			// lblRolAd
			// 
			this.lblRolAd.AutoSize = true;
			this.lblRolAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblRolAd.Location = new System.Drawing.Point(40, 94);
			this.lblRolAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRolAd.Name = "lblRolAd";
			this.lblRolAd.Size = new System.Drawing.Size(88, 20);
			this.lblRolAd.TabIndex = 2;
			this.lblRolAd.Text = "Rol Adı : ";
			// 
			// frm_RolEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 261);
			this.Controls.Add(this.lblRolAd);
			this.Controls.Add(this.btnRolEkle);
			this.Controls.Add(this.txtRolAd);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_RolEkle";
			this.Text = "Rol Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRolAd;
        private System.Windows.Forms.Button btnRolEkle;
        private System.Windows.Forms.Label lblRolAd;
    }
}