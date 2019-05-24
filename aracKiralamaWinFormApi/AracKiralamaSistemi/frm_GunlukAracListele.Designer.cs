namespace AracKiralamaSistemi
{
	partial class frm_GunlukAracListele
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
			this.dg_Listele = new System.Windows.Forms.DataGridView();
			this.btn_Listele = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).BeginInit();
			this.SuspendLayout();
			// 
			// dg_Listele
			// 
			this.dg_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_Listele.Location = new System.Drawing.Point(76, 70);
			this.dg_Listele.Name = "dg_Listele";
			this.dg_Listele.RowTemplate.Height = 24;
			this.dg_Listele.Size = new System.Drawing.Size(670, 207);
			this.dg_Listele.TabIndex = 0;
			// 
			// btn_Listele
			// 
			this.btn_Listele.Location = new System.Drawing.Point(308, 305);
			this.btn_Listele.Name = "btn_Listele";
			this.btn_Listele.Size = new System.Drawing.Size(200, 27);
			this.btn_Listele.TabIndex = 1;
			this.btn_Listele.Text = "Günlük Araç Bilgisi Listele";
			this.btn_Listele.UseVisualStyleBackColor = true;
			this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_ClickAsync);
			// 
			// frm_GunlukAracListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_Listele);
			this.Controls.Add(this.dg_Listele);
			this.Name = "frm_GunlukAracListele";
			this.Text = "Günlük Araç Kiralam Bilgisi Listele";
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dg_Listele;
		private System.Windows.Forms.Button btn_Listele;
	}
}