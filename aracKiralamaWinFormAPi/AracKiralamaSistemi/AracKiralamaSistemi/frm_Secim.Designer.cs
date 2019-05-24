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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SecimEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sirket = new System.Windows.Forms.Button();
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen bir seçim yapınız.";
            // 
            // btn_Sirket
            // 
            this.btn_Sirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sirket.Location = new System.Drawing.Point(193, 63);
            this.btn_Sirket.Name = "btn_Sirket";
            this.btn_Sirket.Size = new System.Drawing.Size(87, 48);
            this.btn_Sirket.TabIndex = 1;
            this.btn_Sirket.Text = "Şirket";
            this.btn_Sirket.UseVisualStyleBackColor = true;
            this.btn_Sirket.Click += new System.EventHandler(this.btn_Sirket_Click);
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Musteri.Location = new System.Drawing.Point(193, 130);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(87, 48);
            this.btn_Musteri.TabIndex = 2;
            this.btn_Musteri.Text = "Müşteri";
            this.btn_Musteri.UseVisualStyleBackColor = true;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Musteri_Click);
            // 
            // frm_SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 248);
            this.Controls.Add(this.btn_Musteri);
            this.Controls.Add(this.btn_Sirket);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_SecimEkrani";
            this.Text = "SecimEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sirket;
        private System.Windows.Forms.Button btn_Musteri;
    }
}

