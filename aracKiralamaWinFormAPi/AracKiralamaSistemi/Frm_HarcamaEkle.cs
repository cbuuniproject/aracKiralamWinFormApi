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
	public partial class Frm_HarcamaEkle : Form
	{
		public Frm_HarcamaEkle()
		{
			InitializeComponent();
		}

		private void Frm_HarcamaEkle_Load(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private async void button1_ClickAsync(object sender, EventArgs e)
		{
			Harcamalar harcamalar = new Harcamalar { aciklama = txtAciklama.Text, harcamaTuruId = Convert.ToInt32(cmbTuru.Text), tarih = dateTimePickerTarih.Value,ucret=Convert.ToInt32(txtUcret.Text) };
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

					// Serialize C# object to Json Object
					var serializedProduct = JsonConvert.SerializeObject(harcamalar);
					// Json object to System.Net.Http content type
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var result = await client.PostAsync("api/Harcamalar", content);
					// Check for result
					if (result.IsSuccessStatusCode)
					{
						success = true;
					}
				}
				// Set message depend on success info
				var message = success ? "done" : "failed";
				// Inform user
				MessageBox.Show("Operation " + message);
			}
			catch (Exception ex)
			{
				// Inform user
				MessageBox.Show("Error happened: " + ex.Message);
			}

		}
	}
}
