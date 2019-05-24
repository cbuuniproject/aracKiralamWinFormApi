namespace AracKiralamaSistemi
{
    partial class frm_SirketEkle
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
			this.tpSirketEkle = new System.Windows.Forms.TabPage();
			this.btnSirketKaydet = new System.Windows.Forms.Button();
			this.txtSirketAdres = new System.Windows.Forms.TextBox();
			this.txtSirketSehir = new System.Windows.Forms.TextBox();
			this.txtSirketAdi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tcSirketEkle = new System.Windows.Forms.TabControl();
			this.tpSirketEkle.SuspendLayout();
			this.tcSirketEkle.SuspendLayout();
			this.SuspendLayout();
			// 
			// tpSirketEkle
			// 
			this.tpSirketEkle.Controls.Add(this.btnSirketKaydet);
			this.tpSirketEkle.Controls.Add(this.txtSirketAdres);
			this.tpSirketEkle.Controls.Add(this.txtSirketSehir);
			this.tpSirketEkle.Controls.Add(this.txtSirketAdi);
			this.tpSirketEkle.Controls.Add(this.label7);
			this.tpSirketEkle.Controls.Add(this.label6);
			this.tpSirketEkle.Controls.Add(this.label5);
			this.tpSirketEkle.Location = new System.Drawing.Point(4, 25);
			this.tpSirketEkle.Margin = new System.Windows.Forms.Padding(4);
			this.tpSirketEkle.Name = "tpSirketEkle";
			this.tpSirketEkle.Padding = new System.Windows.Forms.Padding(4);
			this.tpSirketEkle.Size = new System.Drawing.Size(1027, 495);
			this.tpSirketEkle.TabIndex = 1;
			this.tpSirketEkle.Text = "Şirket Ekle";
			this.tpSirketEkle.UseVisualStyleBackColor = true;
			// 
			// btnSirketKaydet
			// 
			this.btnSirketKaydet.Location = new System.Drawing.Point(537, 355);
			this.btnSirketKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.btnSirketKaydet.Name = "btnSirketKaydet";
			this.btnSirketKaydet.Size = new System.Drawing.Size(175, 90);
			this.btnSirketKaydet.TabIndex = 6;
			this.btnSirketKaydet.Text = "Kaydet";
			this.btnSirketKaydet.UseVisualStyleBackColor = true;
			this.btnSirketKaydet.Click += new System.EventHandler(this.btnSirketKaydet_ClickAsync);
			// 
			// txtSirketAdres
			// 
			this.txtSirketAdres.Location = new System.Drawing.Point(476, 198);
			this.txtSirketAdres.Margin = new System.Windows.Forms.Padding(4);
			this.txtSirketAdres.Name = "txtSirketAdres";
			this.txtSirketAdres.Size = new System.Drawing.Size(295, 22);
			this.txtSirketAdres.TabIndex = 5;
			// 
			// txtSirketSehir
			// 
			this.txtSirketSehir.Location = new System.Drawing.Point(476, 166);
			this.txtSirketSehir.Margin = new System.Windows.Forms.Padding(4);
			this.txtSirketSehir.Name = "txtSirketSehir";
			this.txtSirketSehir.Size = new System.Drawing.Size(295, 22);
			this.txtSirketSehir.TabIndex = 4;
			// 
			// txtSirketAdi
			// 
			this.txtSirketAdi.Location = new System.Drawing.Point(476, 134);
			this.txtSirketAdi.Margin = new System.Windows.Forms.Padding(4);
			this.txtSirketAdi.Name = "txtSirketAdi";
			this.txtSirketAdi.Size = new System.Drawing.Size(295, 22);
			this.txtSirketAdi.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(280, 202);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Adres";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(280, 170);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Şehir";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(280, 138);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Şirket Adi";
			// 
			// tcSirketEkle
			// 
			this.tcSirketEkle.Controls.Add(this.tpSirketEkle);
			this.tcSirketEkle.Location = new System.Drawing.Point(19, 17);
			this.tcSirketEkle.Margin = new System.Windows.Forms.Padding(4);
			this.tcSirketEkle.Name = "tcSirketEkle";
			this.tcSirketEkle.SelectedIndex = 0;
			this.tcSirketEkle.Size = new System.Drawing.Size(1035, 524);
			this.tcSirketEkle.TabIndex = 0;
			this.tcSirketEkle.TabStop = false;
			// 
			// frm_SirketEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.tcSirketEkle);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_SirketEkle";
			this.Text = "Şirket Ekle";
			this.Load += new System.EventHandler(this.frm_Secim_Load);
			this.tpSirketEkle.ResumeLayout(false);
			this.tpSirketEkle.PerformLayout();
			this.tcSirketEkle.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TabPage tpSirketEkle;
		private System.Windows.Forms.Button btnSirketKaydet;
		private System.Windows.Forms.TextBox txtSirketAdres;
		private System.Windows.Forms.TextBox txtSirketSehir;
		private System.Windows.Forms.TextBox txtSirketAdi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabControl tcSirketEkle;
	}
}