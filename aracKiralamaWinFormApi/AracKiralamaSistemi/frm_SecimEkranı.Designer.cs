namespace AracKiralamaSistemi
{
    partial class frm_SecimEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Sirket = new System.Windows.Forms.Button();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(177, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lütfen bir seçim yapınız.";
			// 
			// btn_Sirket
			// 
			this.btn_Sirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Sirket.Location = new System.Drawing.Point(257, 78);
			this.btn_Sirket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Sirket.Name = "btn_Sirket";
			this.btn_Sirket.Size = new System.Drawing.Size(116, 59);
			this.btn_Sirket.TabIndex = 1;
			this.btn_Sirket.Text = "Şirket";
			this.btn_Sirket.UseVisualStyleBackColor = true;
			this.btn_Sirket.Click += new System.EventHandler(this.btn_Sirket_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdmin.Location = new System.Drawing.Point(257, 160);
			this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(116, 59);
			this.btnAdmin.TabIndex = 2;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btn_Musteri_Click);
			// 
			// frm_SecimEkrani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(652, 305);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.btn_Sirket);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_SecimEkrani";
			this.Text = "Seçim Ekranı";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sirket;
        private System.Windows.Forms.Button btnAdmin;
    }
}

