namespace AracKiralamaSistemi
{
	partial class frm_HarcamaListesi
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
			this.btn_ = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).BeginInit();
			this.SuspendLayout();
			// 
			// dg_Listele
			// 
			this.dg_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_Listele.Location = new System.Drawing.Point(32, 34);
			this.dg_Listele.Name = "dg_Listele";
			this.dg_Listele.RowTemplate.Height = 24;
			this.dg_Listele.Size = new System.Drawing.Size(711, 182);
			this.dg_Listele.TabIndex = 0;
			// 
			// btn_
			// 
			this.btn_.Location = new System.Drawing.Point(250, 264);
			this.btn_.Name = "btn_";
			this.btn_.Size = new System.Drawing.Size(163, 31);
			this.btn_.TabIndex = 1;
			this.btn_.Text = "Harcamaları Listele";
			this.btn_.UseVisualStyleBackColor = true;
			this.btn_.Click += new System.EventHandler(this.button1_ClickAsync);
			// 
			// frm_HarcamaListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_);
			this.Controls.Add(this.dg_Listele);
			this.Name = "frm_HarcamaListesi";
			this.Text = "Harcama Listesi";
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dg_Listele;
		private System.Windows.Forms.Button btn_;
	}
}