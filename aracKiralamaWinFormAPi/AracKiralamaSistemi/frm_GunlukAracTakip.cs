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
    public partial class frm_GunlukAracTakip : Form
    {
        public frm_GunlukAracTakip()
        {
            InitializeComponent();
        }

		private async void button1_ClickAsync(object sender, EventArgs e)
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

					dateTimePickerTarih.Format = DateTimePickerFormat.Custom;
					dateTimePickerTarih.CustomFormat = "d/M/yyyy h:mm";

					// Create post body object
					GunlukAracTakip gunlukAracTakip = new GunlukAracTakip();
					gunlukAracTakip.aracId = Convert.ToInt32(cmbAracId.Text);
					gunlukAracTakip.gunlukGidilenKm = Convert.ToInt32(txtGunlukKM.Text);
					gunlukAracTakip.kiralamaId = Convert.ToInt32(cmbKiralamaId.Text);
					gunlukAracTakip.tarih = dateTimePickerTarih.Value;
					// Serialize C# object to Json Object
					var serializedProduct = JsonConvert.SerializeObject(gunlukAracTakip);
					// Json object to System.Net.Http content type
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var result = await client.PostAsync("api/GunlukAracTakip", content);
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
