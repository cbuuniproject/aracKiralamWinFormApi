namespace AracKiralamaSistemi
{
	partial class Frm_HarcamaEkle
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
			this.cmbTuru = new System.Windows.Forms.ComboBox();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnHarcamaEkle = new System.Windows.Forms.Button();
			this.txtUcret = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbTuru
			// 
			this.cmbTuru.FormattingEnabled = true;
			this.cmbTuru.Location = new System.Drawing.Point(270, 97);
			this.cmbTuru.Name = "cmbTuru";
			this.cmbTuru.Size = new System.Drawing.Size(214, 24);
			this.cmbTuru.TabIndex = 0;
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(270, 138);
			this.txtAciklama.Multiline = true;
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(214, 108);
			this.txtAciklama.TabIndex = 1;
			// 
			// dateTimePickerTarih
			// 
			this.dateTimePickerTarih.Location = new System.Drawing.Point(269, 288);
			this.dateTimePickerTarih.Name = "dateTimePickerTarih";
			this.dateTimePickerTarih.Size = new System.Drawing.Size(214, 22);
			this.dateTimePickerTarih.TabIndex = 2;
			this.dateTimePickerTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Harcama Türü";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(200, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Açıklama";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(161, 293);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Harcama Tarih";
			// 
			// btnHarcamaEkle
			// 
			this.btnHarcamaEkle.Location = new System.Drawing.Point(311, 335);
			this.btnHarcamaEkle.Name = "btnHarcamaEkle";
			this.btnHarcamaEkle.Size = new System.Drawing.Size(116, 34);
			this.btnHarcamaEkle.TabIndex = 6;
			this.btnHarcamaEkle.Text = "Harcama Ekle";
			this.btnHarcamaEkle.UseVisualStyleBackColor = true;
			this.btnHarcamaEkle.Click += new System.EventHandler(this.button1_ClickAsync);
			// 
			// txtUcret
			// 
			this.txtUcret.Location = new System.Drawing.Point(269, 252);
			this.txtUcret.Name = "txtUcret";
			this.txtUcret.Size = new System.Drawing.Size(214, 22);
			this.txtUcret.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(221, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ücret";
			// 
			// Frm_HarcamaEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUcret);
			this.Controls.Add(this.btnHarcamaEkle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerTarih);
			this.Controls.Add(this.txtAciklama);
			this.Controls.Add(this.cmbTuru);
			this.Name = "Frm_HarcamaEkle";
			this.Text = "Frm_HarcamaEkle";
			this.Load += new System.EventHandler(this.Frm_HarcamaEkle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbTuru;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnHarcamaEkle;
		private System.Windows.Forms.TextBox txtUcret;
		private System.Windows.Forms.Label label4;
	}
}