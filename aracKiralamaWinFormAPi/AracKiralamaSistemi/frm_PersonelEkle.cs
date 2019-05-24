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
    public partial class frm_PersonelEkle : Form
    {
        public frm_PersonelEkle()
        {
            InitializeComponent();
        }

		private async void btnKaydet_ClickAsync(object sender, EventArgs e)
		{
			try
			{
				bool success = false;
				// Create a HttpClient
				using (var client = new HttpClient())
				{
					// Setup basics
					client.BaseAddress = new Uri("http://localhost:49774/");
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(
						new MediaTypeWithQualityHeaderValue("application/json"));

					// Create post body object
					Calisan calisan = new Calisan { ad = txtAd.Text, kullaniciId = Convert.ToInt32(cmbKullaniciId.Text), sirketId=Convert.ToInt32(cmbSirketId.Text),soyad=txtSoyad.Text };
					// Serialize C# object to Json Object
					var serializedProduct = JsonConvert.SerializeObject(calisan);
					// Json object to System.Net.Http content type
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var result = await client.PostAsync("api/Calisan", content);
					// Check for result
					if (result.IsSuccessStatusCode)
					{
						success = true;
					}
				}
				// Set message depend on success info
				var message = success ? "başarılı" : "failed";
				// Inform user
				MessageBox.Show("Operation " + message);
			}
			catch (Exception ex)
			{
				// Inform user
				MessageBox.Show("Error happened: " + ex.Message);
			}
		}

		private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtKullaniciSifre_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSoyad_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAd_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
