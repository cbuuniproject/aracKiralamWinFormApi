namespace AracKiralamaSistemi
{
    partial class frm_RezervasyonGoruntule
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
			this.btnRezervasyonSil = new System.Windows.Forms.Button();
			this.dgwRezervasyonListesi = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonListesi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRezervasyonSil
			// 
			this.btnRezervasyonSil.Location = new System.Drawing.Point(824, 442);
			this.btnRezervasyonSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRezervasyonSil.Name = "btnRezervasyonSil";
			this.btnRezervasyonSil.Size = new System.Drawing.Size(227, 97);
			this.btnRezervasyonSil.TabIndex = 3;
			this.btnRezervasyonSil.Text = "Rezervasyon Sil";
			this.btnRezervasyonSil.UseVisualStyleBackColor = true;
			// 
			// dgwRezervasyonListesi
			// 
			this.dgwRezervasyonListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwRezervasyonListesi.Location = new System.Drawing.Point(16, 15);
			this.dgwRezervasyonListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgwRezervasyonListesi.Name = "dgwRezervasyonListesi";
			this.dgwRezervasyonListesi.Size = new System.Drawing.Size(1035, 420);
			this.dgwRezervasyonListesi.TabIndex = 2;
			// 
			// frm_RezervasyonGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnRezervasyonSil);
			this.Controls.Add(this.dgwRezervasyonListesi);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_RezervasyonGoruntule";
			this.Text = "Rezervasyon Göruntule";
			this.Load += new System.EventHandler(this.frm_RezervasyonGoruntule_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonListesi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonSil;
        private System.Windows.Forms.DataGridView dgwRezervasyonListesi;
    }
}