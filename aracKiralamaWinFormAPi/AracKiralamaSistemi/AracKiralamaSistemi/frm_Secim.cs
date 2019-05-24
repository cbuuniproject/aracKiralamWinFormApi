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
    public partial class frm_SecimEkrani : Form
    {
        public frm_SecimEkrani()
        {
            InitializeComponent();
        }

        private void btn_Sirket_Click(object sender, EventArgs e)
        {
            frm_SirketLogin srkt = new frm_SirketLogin();
            srkt.Show();
            this.Hide();
        }

        private void btn_Musteri_Click(object sender, EventArgs e)
        {
            frm_Musteri musteri = new frm_Musteri();
            musteri.Show();
            this.Hide();
        }
    }
}
