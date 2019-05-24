namespace AracKiralamaSistemi
{
    partial class frm_HarcamaTuru
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
			this.lblHrcmaTip = new System.Windows.Forms.Label();
			this.btnHarcamaTip = new System.Windows.Forms.Button();
			this.txtHarcamaTip = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblHrcmaTip
			// 
			this.lblHrcmaTip.AutoSize = true;
			this.lblHrcmaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblHrcmaTip.Location = new System.Drawing.Point(16, 101);
			this.lblHrcmaTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblHrcmaTip.Name = "lblHrcmaTip";
			this.lblHrcmaTip.Size = new System.Drawing.Size(208, 20);
			this.lblHrcmaTip.TabIndex = 5;
			this.lblHrcmaTip.Text = "Harcama tipini giriniz : ";
			// 
			// btnHarcamaTip
			// 
			this.btnHarcamaTip.Location = new System.Drawing.Point(275, 150);
			this.btnHarcamaTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnHarcamaTip.Name = "btnHarcamaTip";
			this.btnHarcamaTip.Size = new System.Drawing.Size(145, 36);
			this.btnHarcamaTip.TabIndex = 4;
			this.btnHarcamaTip.Text = "Harcama Tipi Ekle";
			this.btnHarcamaTip.UseVisualStyleBackColor = true;
			this.btnHarcamaTip.Click += new System.EventHandler(this.btnHarcamaTip_ClickAsync);
			// 
			// txtHarcamaTip
			// 
			this.txtHarcamaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtHarcamaTip.Location = new System.Drawing.Point(259, 94);
			this.txtHarcamaTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtHarcamaTip.Name = "txtHarcamaTip";
			this.txtHarcamaTip.Size = new System.Drawing.Size(180, 26);
			this.txtHarcamaTip.TabIndex = 3;
			// 
			// frm_HarcamaTuru
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 290);
			this.Controls.Add(this.lblHrcmaTip);
			this.Controls.Add(this.btnHarcamaTip);
			this.Controls.Add(this.txtHarcamaTip);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_HarcamaTuru";
			this.Text = "frm_HarcamaTuru";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHrcmaTip;
        private System.Windows.Forms.Button btnHarcamaTip;
        private System.Windows.Forms.TextBox txtHarcamaTip;
    }
}