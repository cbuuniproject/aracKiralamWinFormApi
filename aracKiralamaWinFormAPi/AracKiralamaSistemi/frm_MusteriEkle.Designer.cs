namespace AracKiralamaSistemi
{
	partial class frm_MusteriEkle
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
			this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.Location = new System.Drawing.Point(361, 185);
			this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Size = new System.Drawing.Size(256, 22);
			this.txtKullaniciSifre.TabIndex = 51;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(361, 153);
			this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(256, 22);
			this.txtKullaniciAdi.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(113, 189);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 49;
			this.label3.Text = "Şifre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(113, 157);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 17);
			this.label4.TabIndex = 48;
			this.label4.Text = "Kullanici Adi";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(459, 236);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(160, 46);
			this.btnKaydet.TabIndex = 47;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_ClickAsync);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(361, 121);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(256, 22);
			this.txtSoyad.TabIndex = 46;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(361, 89);
			this.txtAd.Margin = new System.Windows.Forms.Padding(4);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(256, 22);
			this.txtAd.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 125);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 44;
			this.label2.Text = "Soyad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 93);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 43;
			this.label1.Text = "Ad";
			// 
			// frm_MusteriEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtKullaniciSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frm_MusteriEkle";
			this.Text = "Müşteri Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtKullaniciSifre;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}