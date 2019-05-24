namespace AracKiralamaSistemi
{
    partial class frm_PersonelEkle
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
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblKulId = new System.Windows.Forms.Label();
			this.lblSirketId = new System.Windows.Forms.Label();
			this.cmbSirketId = new System.Windows.Forms.ComboBox();
			this.cmbKullaniciId = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(303, 176);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(160, 46);
			this.btnKaydet.TabIndex = 38;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_ClickAsync);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(303, 60);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(256, 22);
			this.txtSoyad.TabIndex = 30;
			this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(303, 28);
			this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(256, 22);
			this.txtAd.TabIndex = 29;
			this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(133, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Soyad";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(133, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Ad";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblKulId
			// 
			this.lblKulId.AutoSize = true;
			this.lblKulId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKulId.Location = new System.Drawing.Point(133, 135);
			this.lblKulId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKulId.Name = "lblKulId";
			this.lblKulId.Size = new System.Drawing.Size(102, 17);
			this.lblKulId.TabIndex = 40;
			this.lblKulId.Text = "Kullanıcı Id : ";
			this.lblKulId.Click += new System.EventHandler(this.label3_Click);
			// 
			// lblSirketId
			// 
			this.lblSirketId.AutoSize = true;
			this.lblSirketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSirketId.Location = new System.Drawing.Point(133, 107);
			this.lblSirketId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSirketId.Name = "lblSirketId";
			this.lblSirketId.Size = new System.Drawing.Size(83, 17);
			this.lblSirketId.TabIndex = 39;
			this.lblSirketId.Text = "Şirket Id : ";
			this.lblSirketId.Click += new System.EventHandler(this.label4_Click);
			// 
			// cmbSirketId
			// 
			this.cmbSirketId.FormattingEnabled = true;
			this.cmbSirketId.Location = new System.Drawing.Point(303, 92);
			this.cmbSirketId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbSirketId.Name = "cmbSirketId";
			this.cmbSirketId.Size = new System.Drawing.Size(256, 24);
			this.cmbSirketId.TabIndex = 43;
			// 
			// cmbKullaniciId
			// 
			this.cmbKullaniciId.FormattingEnabled = true;
			this.cmbKullaniciId.Location = new System.Drawing.Point(303, 126);
			this.cmbKullaniciId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbKullaniciId.Name = "cmbKullaniciId";
			this.cmbKullaniciId.Size = new System.Drawing.Size(256, 24);
			this.cmbKullaniciId.TabIndex = 44;
			// 
			// frm_PersonelEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 263);
			this.Controls.Add(this.cmbKullaniciId);
			this.Controls.Add(this.cmbSirketId);
			this.Controls.Add(this.lblKulId);
			this.Controls.Add(this.lblSirketId);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_PersonelEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Personel Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKulId;
        private System.Windows.Forms.Label lblSirketId;
        private System.Windows.Forms.ComboBox cmbSirketId;
        private System.Windows.Forms.ComboBox cmbKullaniciId;
    }
}