using AracKiralamaApp.Domains;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class frm_AdminEkran : Form
    {
        public frm_AdminEkran()
        {
            InitializeComponent();
        }

		private void şirketEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private async void btnListele_ClickAsync(object sender, EventArgs e)
		{
			dg_SirketListele.DataSource = null;

			try
			{
				// Create a HttpClient
				using (var client = new HttpClient())
				{
					// Setup basics
					client.BaseAddress = new Uri("http://localhost:49774");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					// Get Request from the URI
					using (var result = await client.GetAsync("api/Sirket"))
					{
						// Check the Result
						if (result.IsSuccessStatusCode)
						{
							// Take the Result as a json string
							var value = result.Content.ReadAsStringAsync().Result;

							// Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
							dg_SirketListele.DataSource =
								JsonConvert.DeserializeObject<ResponseContent<Sirket>>(value).Data.ToList();
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Inform user if an error occurs
				MessageBox.Show("Error happened: " + ex.Message);
			}
		}

		private void btnSrktEkle_Click(object sender, EventArgs e)
		{
			frm_SirketEkle sirketEkle = new frm_SirketEkle();
			sirketEkle.ShowDialog();
		}

		private void btnCalisanEkle_Click(object sender, EventArgs e)
		{
			frm_PersonelEkle frm_Personel = new frm_PersonelEkle();
			frm_Personel.ShowDialog();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private async void btnCalisanListele_ClickAsync(object sender, EventArgs e)
		{
			dg_SirketListele.DataSource = null;
			try
			{
				// Create a HttpClient
				using (var client = new HttpClient())
				{
					// Setup basics
					client.BaseAddress = new Uri("http://localhost:49774");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					// Get Request from the URI
					using (var result = await client.GetAsync("api/Calisan"))
					{
						// Check the Result
						if (result.IsSuccessStatusCode)
						{
							// Take the Result as a json string
							var value = result.Content.ReadAsStringAsync().Result;

							// Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
							dg_SirketListele.DataSource =
								JsonConvert.DeserializeObject<ResponseContent<Calisan>>(value).Data.ToList();
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Inform user if an error occurs
				MessageBox.Show("Error happened: " + ex.Message);
			}

		}

		private void frm_AdminEkran_Load(object sender, EventArgs e)
		{

		}
	}
}
