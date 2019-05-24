namespace AracKiralamaSistemi
{
    partial class frm_SirketLogin
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.btn_Giris = new System.Windows.Forms.Button();
			this.lbl_KayanMetin = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(161, 185);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı : ";
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciAdi.Location = new System.Drawing.Point(331, 181);
			this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(228, 30);
			this.txtKullaniciAdi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(161, 231);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre : ";
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(331, 228);
			this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(228, 30);
			this.txtSifre.TabIndex = 3;
			// 
			// btn_Giris
			// 
			this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Giris.Location = new System.Drawing.Point(167, 276);
			this.btn_Giris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Giris.Name = "btn_Giris";
			this.btn_Giris.Size = new System.Drawing.Size(393, 44);
			this.btn_Giris.TabIndex = 5;
			this.btn_Giris.Text = "GİRİŞ";
			this.btn_Giris.UseVisualStyleBackColor = true;
			this.btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
			// 
			// lbl_KayanMetin
			// 
			this.lbl_KayanMetin.AutoSize = true;
			this.lbl_KayanMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_KayanMetin.Location = new System.Drawing.Point(161, 95);
			this.lbl_KayanMetin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_KayanMetin.Name = "lbl_KayanMetin";
			this.lbl_KayanMetin.Size = new System.Drawing.Size(393, 25);
			this.lbl_KayanMetin.TabIndex = 6;
			this.lbl_KayanMetin.Text = " Lütfen kullanıcı adı ve şifrenizi giriniz... ";
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// frm_SirketLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(716, 465);
			this.Controls.Add(this.lbl_KayanMetin);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_SirketLogin";
			this.Text = "SirketLogin";
			this.Load += new System.EventHandler(this.frm_SirketLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label lbl_KayanMetin;
        private System.Windows.Forms.Timer timer1;
    }
}