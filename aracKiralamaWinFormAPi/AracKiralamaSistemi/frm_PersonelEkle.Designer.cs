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
            this.btnKaydet.Location = new System.Drawing.Point(227, 143);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 37);
            this.btnKaydet.TabIndex = 38;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(227, 49);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(193, 20);
            this.txtSoyad.TabIndex = 30;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(227, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(193, 20);
            this.txtAd.TabIndex = 29;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKulId
            // 
            this.lblKulId.AutoSize = true;
            this.lblKulId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulId.Location = new System.Drawing.Point(100, 110);
            this.lblKulId.Name = "lblKulId";
            this.lblKulId.Size = new System.Drawing.Size(82, 13);
            this.lblKulId.TabIndex = 40;
            this.lblKulId.Text = "Kullanıcı Id : ";
            this.lblKulId.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSirketId
            // 
            this.lblSirketId.AutoSize = true;
            this.lblSirketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketId.Location = new System.Drawing.Point(100, 87);
            this.lblSirketId.Name = "lblSirketId";
            this.lblSirketId.Size = new System.Drawing.Size(67, 13);
            this.lblSirketId.TabIndex = 39;
            this.lblSirketId.Text = "Şirket Id : ";
            this.lblSirketId.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbSirketId
            // 
            this.cmbSirketId.FormattingEnabled = true;
            this.cmbSirketId.Location = new System.Drawing.Point(227, 75);
            this.cmbSirketId.Name = "cmbSirketId";
            this.cmbSirketId.Size = new System.Drawing.Size(193, 21);
            this.cmbSirketId.TabIndex = 43;
            // 
            // cmbKullaniciId
            // 
            this.cmbKullaniciId.FormattingEnabled = true;
            this.cmbKullaniciId.Location = new System.Drawing.Point(227, 102);
            this.cmbKullaniciId.Name = "cmbKullaniciId";
            this.cmbKullaniciId.Size = new System.Drawing.Size(193, 21);
            this.cmbKullaniciId.TabIndex = 44;
            // 
            // frm_PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 214);
            this.Controls.Add(this.cmbKullaniciId);
            this.Controls.Add(this.cmbSirketId);
            this.Controls.Add(this.lblKulId);
            this.Controls.Add(this.lblSirketId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_PersonelEkle";
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