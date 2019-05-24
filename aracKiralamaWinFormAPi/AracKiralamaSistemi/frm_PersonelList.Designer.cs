namespace AracKiralamaSistemi
{
	partial class frm_PersonelList
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
			this.dg_Personel = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg_Personel)).BeginInit();
			this.SuspendLayout();
			// 
			// dg_Personel
			// 
			this.dg_Personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_Personel.Location = new System.Drawing.Point(21, 32);
			this.dg_Personel.Name = "dg_Personel";
			this.dg_Personel.RowTemplate.Height = 24;
			this.dg_Personel.Size = new System.Drawing.Size(743, 394);
			this.dg_Personel.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(311, 446);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
			// 
			// frm_PersonelList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 494);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dg_Personel);
			this.Name = "frm_PersonelList";
			this.Text = "Personel Listele";
			this.Load += new System.EventHandler(this.frm_PersonelList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg_Personel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dg_Personel;
		private System.Windows.Forms.Button button1;
	}
}