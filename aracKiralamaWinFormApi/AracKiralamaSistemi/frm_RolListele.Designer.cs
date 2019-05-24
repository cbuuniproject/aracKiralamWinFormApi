namespace AracKiralamaSistemi
{
	partial class frm_RolListele
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
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).BeginInit();
			this.SuspendLayout();
			// 
			// dg_Listele
			// 
			this.dg_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_Listele.Location = new System.Drawing.Point(135, 59);
			this.dg_Listele.Name = "dg_Listele";
			this.dg_Listele.RowTemplate.Height = 24;
			this.dg_Listele.Size = new System.Drawing.Size(531, 198);
			this.dg_Listele.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 295);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Rol Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
			// 
			// frm_RolListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dg_Listele);
			this.Name = "frm_RolListele";
			this.Text = "Rol Listele";
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dg_Listele;
		private System.Windows.Forms.Button button1;
	}
}