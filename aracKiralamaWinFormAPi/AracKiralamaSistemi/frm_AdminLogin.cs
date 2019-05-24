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
	public partial class frm_AdminLogin : Form
	{
		public frm_AdminLogin()
		{
			InitializeComponent();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text=="admin"&&txtPass.Text=="123")
			{
				MessageBox.Show("Admin Girişi Başarılı");
				this.Hide();
				frm_AdminEkran frm_Admin = new frm_AdminEkran();
				frm_Admin.ShowDialog();
			}
			

		}

		private void frm_AdminLogin_Load(object sender, EventArgs e)
		{
			txtPass.PasswordChar = '*';

		}
	}
}
