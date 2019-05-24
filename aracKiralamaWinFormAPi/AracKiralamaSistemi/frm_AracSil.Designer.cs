namespace AracKiralamaSistemi
{
    partial class frm_AracSil
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
            this.dgwAracListesi = new System.Windows.Forms.DataGridView();
            this.btnAracSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAracListesi
            // 
            this.dgwAracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAracListesi.Location = new System.Drawing.Point(12, 12);
            this.dgwAracListesi.Name = "dgwAracListesi";
            this.dgwAracListesi.Size = new System.Drawing.Size(776, 341);
            this.dgwAracListesi.TabIndex = 0;
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(618, 359);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(170, 79);
            this.btnAracSil.TabIndex = 1;
            this.btnAracSil.Text = "Arac Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            // 
            // frm_AracSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.dgwAracListesi);
            this.Name = "frm_AracSil";
            this.Text = "frm_AracSil";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAracListesi;
        private System.Windows.Forms.Button btnAracSil;
    }
}