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
	public partial class frm_AracGoruntule : Form
	{
		public frm_AracGoruntule()
		{
			InitializeComponent();
		}

		private void frm_AracGoruntule_Load(object sender, EventArgs e)
		{
		/*	using (var aracSoapClient = new AracWebServiceSoapClient())
			{
				dataGridView1.DataSource = aracSoapClient.SelectAllAracs();
			}*/
		}
	}
}
