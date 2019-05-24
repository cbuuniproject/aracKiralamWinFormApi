namespace AracKiralamaSistemi
{
    partial class frm_AdminEkran
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dg_SirketListele = new System.Windows.Forms.DataGridView();
			this.btnListele = new System.Windows.Forms.Button();
			this.btnSrktEkle = new System.Windows.Forms.Button();
			this.btnCalisanEkle = new System.Windows.Forms.Button();
			this.btnCalisanListele = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg_SirketListele)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1331, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dg_SirketListele
			// 
			this.dg_SirketListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_SirketListele.Location = new System.Drawing.Point(331, 60);
			this.dg_SirketListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dg_SirketListele.Name = "dg_SirketListele";
			this.dg_SirketListele.RowTemplate.Height = 24;
			this.dg_SirketListele.Size = new System.Drawing.Size(963, 331);
			this.dg_SirketListele.TabIndex = 1;
			this.dg_SirketListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(717, 417);
			this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(173, 38);
			this.btnListele.TabIndex = 2;
			this.btnListele.Text = "Şirket Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_ClickAsync);
			// 
			// btnSrktEkle
			// 
			this.btnSrktEkle.Location = new System.Drawing.Point(49, 103);
			this.btnSrktEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSrktEkle.Name = "btnSrktEkle";
			this.btnSrktEkle.Size = new System.Drawing.Size(173, 38);
			this.btnSrktEkle.TabIndex = 3;
			this.btnSrktEkle.Text = "Şirket Ekle";
			this.btnSrktEkle.UseVisualStyleBackColor = true;
			this.btnSrktEkle.Click += new System.EventHandler(this.btnSrktEkle_Click);
			// 
			// btnCalisanEkle
			// 
			this.btnCalisanEkle.Location = new System.Drawing.Point(49, 166);
			this.btnCalisanEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCalisanEkle.Name = "btnCalisanEkle";
			this.btnCalisanEkle.Size = new System.Drawing.Size(173, 38);
			this.btnCalisanEkle.TabIndex = 4;
			this.btnCalisanEkle.Text = "Personel Ekle";
			this.btnCalisanEkle.UseVisualStyleBackColor = true;
			this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
			// 
			// btnCalisanListele
			// 
			this.btnCalisanListele.Location = new System.Drawing.Point(955, 417);
			this.btnCalisanListele.Name = "btnCalisanListele";
			this.btnCalisanListele.Size = new System.Drawing.Size(165, 38);
			this.btnCalisanListele.TabIndex = 5;
			this.btnCalisanListele.Text = "Personelleri Listele";
			this.btnCalisanListele.UseVisualStyleBackColor = true;
			this.btnCalisanListele.Click += new System.EventHandler(this.btnCalisanListele_ClickAsync);
			// 
			// frm_AdminEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1331, 565);
			this.Controls.Add(this.btnCalisanListele);
			this.Controls.Add(this.btnCalisanEkle);
			this.Controls.Add(this.btnSrktEkle);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.dg_SirketListele);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_AdminEkran";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Ekran";
			this.Load += new System.EventHandler(this.frm_AdminEkran_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg_SirketListele)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.DataGridView dg_SirketListele;
		private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSrktEkle;
        private System.Windows.Forms.Button btnCalisanEkle;
		private System.Windows.Forms.Button btnCalisanListele;
	}
}