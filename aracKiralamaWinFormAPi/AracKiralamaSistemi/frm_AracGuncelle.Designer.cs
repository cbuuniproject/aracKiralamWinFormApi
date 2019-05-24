namespace AracKiralamaSistemi
{
    partial class frm_AracGuncelle
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
            this.tcEkran = new System.Windows.Forms.TabControl();
            this.tpAracSec = new System.Windows.Forms.TabPage();
            this.tpAracGuncelle = new System.Windows.Forms.TabPage();
            this.btnAracSec = new System.Windows.Forms.Button();
            this.dgwAracListesi = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.txtBagajHacmi = new System.Windows.Forms.TextBox();
            this.txtAirbagSayisi = new System.Windows.Forms.TextBox();
            this.txtAnlikKm = new System.Windows.Forms.TextBox();
            this.txtGunlukKmLimit = new System.Windows.Forms.TextBox();
            this.txtYasSiniri = new System.Windows.Forms.TextBox();
            this.txtEhliyetYasi = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcEkran.SuspendLayout();
            this.tpAracSec.SuspendLayout();
            this.tpAracGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEkran
            // 
            this.tcEkran.Controls.Add(this.tpAracSec);
            this.tcEkran.Controls.Add(this.tpAracGuncelle);
            this.tcEkran.Enabled = false;
            this.tcEkran.Location = new System.Drawing.Point(12, 12);
            this.tcEkran.Name = "tcEkran";
            this.tcEkran.SelectedIndex = 0;
            this.tcEkran.Size = new System.Drawing.Size(776, 426);
            this.tcEkran.TabIndex = 0;
            // 
            // tpAracSec
            // 
            this.tpAracSec.Controls.Add(this.btnAracSec);
            this.tpAracSec.Controls.Add(this.dgwAracListesi);
            this.tpAracSec.Location = new System.Drawing.Point(4, 22);
            this.tpAracSec.Name = "tpAracSec";
            this.tpAracSec.Padding = new System.Windows.Forms.Padding(3);
            this.tpAracSec.Size = new System.Drawing.Size(768, 400);
            this.tpAracSec.TabIndex = 0;
            this.tpAracSec.Text = "Araç Seç";
            this.tpAracSec.UseVisualStyleBackColor = true;
            // 
            // tpAracGuncelle
            // 
            this.tpAracGuncelle.Controls.Add(this.btnGuncelle);
            this.tpAracGuncelle.Controls.Add(this.txtKoltukSayisi);
            this.tpAracGuncelle.Controls.Add(this.txtBagajHacmi);
            this.tpAracGuncelle.Controls.Add(this.txtAirbagSayisi);
            this.tpAracGuncelle.Controls.Add(this.txtAnlikKm);
            this.tpAracGuncelle.Controls.Add(this.txtGunlukKmLimit);
            this.tpAracGuncelle.Controls.Add(this.txtYasSiniri);
            this.tpAracGuncelle.Controls.Add(this.txtEhliyetYasi);
            this.tpAracGuncelle.Controls.Add(this.txtModel);
            this.tpAracGuncelle.Controls.Add(this.txtMarka);
            this.tpAracGuncelle.Controls.Add(this.label9);
            this.tpAracGuncelle.Controls.Add(this.label8);
            this.tpAracGuncelle.Controls.Add(this.label7);
            this.tpAracGuncelle.Controls.Add(this.label6);
            this.tpAracGuncelle.Controls.Add(this.label5);
            this.tpAracGuncelle.Controls.Add(this.label4);
            this.tpAracGuncelle.Controls.Add(this.label3);
            this.tpAracGuncelle.Controls.Add(this.label2);
            this.tpAracGuncelle.Controls.Add(this.label1);
            this.tpAracGuncelle.Location = new System.Drawing.Point(4, 22);
            this.tpAracGuncelle.Name = "tpAracGuncelle";
            this.tpAracGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tpAracGuncelle.Size = new System.Drawing.Size(768, 400);
            this.tpAracGuncelle.TabIndex = 1;
            this.tpAracGuncelle.Text = "Araç Güncelle";
            this.tpAracGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAracSec
            // 
            this.btnAracSec.Location = new System.Drawing.Point(656, 329);
            this.btnAracSec.Name = "btnAracSec";
            this.btnAracSec.Size = new System.Drawing.Size(106, 68);
            this.btnAracSec.TabIndex = 3;
            this.btnAracSec.Text = "İleri";
            this.btnAracSec.UseVisualStyleBackColor = true;
            // 
            // dgwAracListesi
            // 
            this.dgwAracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAracListesi.Location = new System.Drawing.Point(6, 6);
            this.dgwAracListesi.Name = "dgwAracListesi";
            this.dgwAracListesi.Size = new System.Drawing.Size(756, 317);
            this.dgwAracListesi.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(454, 303);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 37);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.Text = "Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(381, 268);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(193, 20);
            this.txtKoltukSayisi.TabIndex = 37;
            // 
            // txtBagajHacmi
            // 
            this.txtBagajHacmi.Location = new System.Drawing.Point(381, 242);
            this.txtBagajHacmi.Name = "txtBagajHacmi";
            this.txtBagajHacmi.Size = new System.Drawing.Size(193, 20);
            this.txtBagajHacmi.TabIndex = 36;
            // 
            // txtAirbagSayisi
            // 
            this.txtAirbagSayisi.Location = new System.Drawing.Point(381, 216);
            this.txtAirbagSayisi.Name = "txtAirbagSayisi";
            this.txtAirbagSayisi.Size = new System.Drawing.Size(193, 20);
            this.txtAirbagSayisi.TabIndex = 35;
            // 
            // txtAnlikKm
            // 
            this.txtAnlikKm.Location = new System.Drawing.Point(381, 190);
            this.txtAnlikKm.Name = "txtAnlikKm";
            this.txtAnlikKm.Size = new System.Drawing.Size(193, 20);
            this.txtAnlikKm.TabIndex = 34;
            // 
            // txtGunlukKmLimit
            // 
            this.txtGunlukKmLimit.Location = new System.Drawing.Point(381, 164);
            this.txtGunlukKmLimit.Name = "txtGunlukKmLimit";
            this.txtGunlukKmLimit.Size = new System.Drawing.Size(193, 20);
            this.txtGunlukKmLimit.TabIndex = 33;
            // 
            // txtYasSiniri
            // 
            this.txtYasSiniri.Location = new System.Drawing.Point(381, 138);
            this.txtYasSiniri.Name = "txtYasSiniri";
            this.txtYasSiniri.Size = new System.Drawing.Size(193, 20);
            this.txtYasSiniri.TabIndex = 32;
            // 
            // txtEhliyetYasi
            // 
            this.txtEhliyetYasi.Location = new System.Drawing.Point(381, 112);
            this.txtEhliyetYasi.Name = "txtEhliyetYasi";
            this.txtEhliyetYasi.Size = new System.Drawing.Size(193, 20);
            this.txtEhliyetYasi.TabIndex = 31;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(381, 86);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(193, 20);
            this.txtModel.TabIndex = 30;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(381, 60);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(193, 20);
            this.txtMarka.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Koltuk Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Bagaj Hacmi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Airbag Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Anlık Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Günlük Max Km Sınırı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Min Yaş Sınırı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Min Ehliyet Yaşı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Marka";
            // 
            // frm_AracGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcEkran);
            this.Name = "frm_AracGuncelle";
            this.Text = "frm_AracGuncelle";
            this.tcEkran.ResumeLayout(false);
            this.tpAracSec.ResumeLayout(false);
            this.tpAracGuncelle.ResumeLayout(false);
            this.tpAracGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEkran;
        private System.Windows.Forms.TabPage tpAracSec;
        private System.Windows.Forms.Button btnAracSec;
        private System.Windows.Forms.DataGridView dgwAracListesi;
        private System.Windows.Forms.TabPage tpAracGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.TextBox txtBagajHacmi;
        private System.Windows.Forms.TextBox txtAirbagSayisi;
        private System.Windows.Forms.TextBox txtAnlikKm;
        private System.Windows.Forms.TextBox txtGunlukKmLimit;
        private System.Windows.Forms.TextBox txtYasSiniri;
        private System.Windows.Forms.TextBox txtEhliyetYasi;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}