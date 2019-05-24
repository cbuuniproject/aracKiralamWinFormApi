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
    public partial class frm_AracEkle : Form
    {
        public frm_AracEkle()
        {
            InitializeComponent();
        }

		private async void btnKaydet_ClickAsync(object sender, EventArgs e)
		{
			Arac arac = new Arac() {
				airbagSayisi = Convert.ToByte(txtAirbagSayisi.Text),
				bagajHacmi = short.Parse(txtBagajHacmi.Text),
				anlikKm = Convert.ToInt32(txtAnlikKm.Text),
				gunlukFiyat = Convert.ToInt32(txtFiyat.Text),
				gunlukMaxKmSiniri = short.Parse(txtGunlukKmLimit.Text),
				koltukSayisi = Convert.ToByte(txtKoltukSayisi.Text),
				marka = txtMarka.Text,
				minEhliyetYasi=Convert.ToInt32(txtEhliyetYasi.Text),
				minYasSiniri=short.Parse(txtYasSiniri.Text),
				model=txtModel.Text,
				sirketId=5
			};

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
					var serializedProduct = JsonConvert.SerializeObject(arac);
					// Json object to System.Net.Http content type
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var result = await client.PostAsync("api/Arac", content);
					// Check for result
					if (result.IsSuccessStatusCode)
					{
						success = true;
					}
				}
				// Set message depend on success info
				var message = success ? "başarılı" : "başarısız!";
				// Inform user
				MessageBox.Show("İşlem " + message);
			}
			catch (Exception ex)
			{
				// Inform user
				MessageBox.Show("Error happened: " + ex.Message);
			}

		}
	}
}
