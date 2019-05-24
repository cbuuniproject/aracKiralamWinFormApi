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
	public partial class frm_MusteriListele : Form
	{
		public frm_MusteriListele()
		{
			InitializeComponent();
		}

		private void frm_MusteriListele_Load(object sender, EventArgs e)
		{
		/*	using (var musteriSoapClient = new MusteriWebServiceSoapClient())
			{
				dataGridView1.DataSource = musteriSoapClient.SelectAllMusteris();
			}*/
		}

		private void button1_Click(object sender, EventArgs e)
		{
		/*	using (var musteriSoapClient = new MusteriWebServiceSoapClient())
			{
				dataGridView1.DataSource = musteriSoapClient.SelectAllMusteris();
			}*/
		}
	}
}
