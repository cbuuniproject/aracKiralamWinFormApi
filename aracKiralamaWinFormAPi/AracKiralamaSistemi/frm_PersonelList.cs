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
	public partial class frm_PersonelList : Form
	{
		public frm_PersonelList()
		{
			InitializeComponent();
		}

		private void frm_PersonelList_Load(object sender, EventArgs e)
		{/*
			using (var calisanSoapClient = new CalisanWebServiceSoapClient())
			{
				dataGridView1.DataSource = calisanSoapClient.SelectAllCalisans();
			}*/
		}

		private void button1_Click(object sender, EventArgs e)
		{/*
			using (var calisanSoapClient = new CalisanWebServiceSoapClient())
			{
				dataGridView1.DataSource = calisanSoapClient.SelectAllCalisans();
			}*/
		}
	}
}
