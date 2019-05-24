using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class frm_SirketLogin : Form
    {
        public frm_SirketLogin()
        {
            InitializeComponent();
        }

        private void frm_SirketLogin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_KayanMetin.Text = lbl_KayanMetin.Text.Substring(1) + lbl_KayanMetin.Text.Substring(0, 1);
        }

        private void btn_ScmEkrGeriDon_Click(object sender, EventArgs e)
        {
            frm_SecimEkrani secimEkrani = new frm_SecimEkrani();
            secimEkrani.Show();
			this.Hide();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
			if (txtKullaniciAdi.Text=="admin"&&txtSifre.Text=="123")
			{
				frm_SirketEkran frm_SirketEkran = new frm_SirketEkran();
				frm_SirketEkran.ShowDialog();
				this.Hide();
			}
        }
    }
}
