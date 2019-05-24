namespace AracKiralamaSistemi
{
    partial class frm_PersonelSil
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
			this.btnPersonelSil = new System.Windows.Forms.Button();
			this.dgwPersonelListesi = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPersonelSil
			// 
			this.btnPersonelSil.Location = new System.Drawing.Point(824, 442);
			this.btnPersonelSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPersonelSil.Name = "btnPersonelSil";
			this.btnPersonelSil.Size = new System.Drawing.Size(227, 97);
			this.btnPersonelSil.TabIndex = 3;
			this.btnPersonelSil.Text = "Personel Sil";
			this.btnPersonelSil.UseVisualStyleBackColor = true;
			this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
			// 
			// dgwPersonelListesi
			// 
			this.dgwPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPersonelListesi.Location = new System.Drawing.Point(16, 15);
			this.dgwPersonelListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgwPersonelListesi.Name = "dgwPersonelListesi";
			this.dgwPersonelListesi.Size = new System.Drawing.Size(1035, 420);
			this.dgwPersonelListesi.TabIndex = 2;
			// 
			// frm_PersonelSil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnPersonelSil);
			this.Controls.Add(this.dgwPersonelListesi);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_PersonelSil";
			this.Text = "frm_PersonelSil";
			((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.DataGridView dgwPersonelListesi;
    }
}