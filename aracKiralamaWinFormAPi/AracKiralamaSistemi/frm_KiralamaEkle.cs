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
    public partial class frm_KiralamaEkle : Form
    {
        public frm_KiralamaEkle()
        {
            InitializeComponent();
        }

		private async void btnKiralamaEkle_ClickAsync(object sender, EventArgs e)
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

					dateTimeVerilisTarih.Format = DateTimePickerFormat.Custom;
					dateTimeVerilisTarih.CustomFormat = "d/M/yyyy h:mm";

					dateTimeAlinisTarih.Format = DateTimePickerFormat.Custom;
					dateTimeAlinisTarih.CustomFormat = "d/M/yyyy h:mm";

					int verilisKm= Convert.ToInt32(txtVerilisKM.Text); 
					int alisKm= Convert.ToInt32(txtAlinisKM.Text);
					// Create post body object
					Kiralama kiralama = new Kiralama();
					kiralama.aracId = Convert.ToInt32(cmbAracId.Text);
					kiralama.musteriId = Convert.ToInt32(cmbMusteriId.Text);
					kiralama.sirketId = Convert.ToInt32(cmbSirketId.Text);
					kiralama.geriAlisTarihi = dateTimeAlinisTarih.Value;
					kiralama.verilisTarihi = dateTimeVerilisTarih.Value;
					kiralama.verilisKm = verilisKm;
					kiralama.sonKm = alisKm;
					kiralama.ucret = (alisKm-verilisKm);
					// Serialize C# object to Json Object
					var serializedProduct = JsonConvert.SerializeObject(kiralama);
					// Json object to System.Net.Http content type
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var result = await client.PostAsync("api/KiralamaBusiness", content);
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
