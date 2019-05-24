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
    public partial class frm_SirketEkran : Form
    {
        public frm_SirketEkran()
        {
            InitializeComponent();
        }

		private void araçEklemeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frm_AracEkle frm_AracEkle = new frm_AracEkle();
			frm_AracEkle.ShowDialog();
		}

		private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_PersonelList frm_PersonelList = new frm_PersonelList();
			frm_PersonelList.ShowDialog();
		}

		private void araçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_AracGoruntule frm_AracGoruntule = new frm_AracGoruntule();
			frm_AracGoruntule.ShowDialog();
			this.Hide();
		}

		private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_PersonelEkle frm_PersonelEkle = new frm_PersonelEkle();
			frm_PersonelEkle.ShowDialog();
		}

		private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_MusteriEkle frm_MusteriEkle = new frm_MusteriEkle();
			frm_MusteriEkle.ShowDialog();
		}

		private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_MusteriListele frm_MusteriListele = new frm_MusteriListele();
			frm_MusteriListele.ShowDialog();
		}

		private void kiralamaGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_KiralamaGoruntule frm_KiralamaGoruntule = new frm_KiralamaGoruntule();
			frm_KiralamaGoruntule.ShowDialog();
		}
	}
}
