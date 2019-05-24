namespace AracKiralamaSistemi
{
    partial class frm_KiralamaGoruntule
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
			this.btnKiralamaListele = new System.Windows.Forms.Button();
			this.dg_Listele = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).BeginInit();
			this.SuspendLayout();
			// 
			// btnKiralamaListele
			// 
			this.btnKiralamaListele.Location = new System.Drawing.Point(442, 444);
			this.btnKiralamaListele.Margin = new System.Windows.Forms.Padding(4);
			this.btnKiralamaListele.Name = "btnKiralamaListele";
			this.btnKiralamaListele.Size = new System.Drawing.Size(227, 97);
			this.btnKiralamaListele.TabIndex = 3;
			this.btnKiralamaListele.Text = "Kiralama Listele";
			this.btnKiralamaListele.UseVisualStyleBackColor = true;
			this.btnKiralamaListele.Click += new System.EventHandler(this.btnKiralamaSil_ClickAsync);
			// 
			// dg_Listele
			// 
			this.dg_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_Listele.Location = new System.Drawing.Point(16, 15);
			this.dg_Listele.Margin = new System.Windows.Forms.Padding(4);
			this.dg_Listele.Name = "dg_Listele";
			this.dg_Listele.Size = new System.Drawing.Size(1035, 420);
			this.dg_Listele.TabIndex = 2;
			// 
			// frm_KiralamaGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnKiralamaListele);
			this.Controls.Add(this.dg_Listele);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_KiralamaGoruntule";
			this.Text = "Kiralama Goruntule";
			this.Load += new System.EventHandler(this.frm_KiralamaGoruntule_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg_Listele)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiralamaListele;
        private System.Windows.Forms.DataGridView dg_Listele;
    }
}