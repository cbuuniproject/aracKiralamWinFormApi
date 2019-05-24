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
	public partial class frm_MusteriEkle : Form
	{
		public frm_MusteriEkle()
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
					Kullanici kullanici = new Kullanici { kullaniciAd=txtKullaniciAdi.Text,parola=txtKullaniciSifre.Text,rolid=2};
					Musteri musteri = new Musteri { ad = txtAd.Text, soyad = txtSoyad.Text, kullaniciId = 2 };
					// Serialize C# object to Json Object

					var serializedProductKullanici = JsonConvert.SerializeObject(kullanici);
					// Json object to System.Net.Http content type
					var contentKullanici = new StringContent(serializedProductKullanici, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var resultKullanici = await client.PostAsync("api/Kullanici", contentKullanici);

					var serializedProductMusteri = JsonConvert.SerializeObject(musteri);
					// Json object to System.Net.Http content type
					var contentMusteri = new StringContent(serializedProductMusteri, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var resultMusteri = await client.PostAsync("api/Musteri", contentMusteri);
					// Check for result
					if (resultMusteri.IsSuccessStatusCode)
					{
						MessageBox.Show("Eklendi");
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
