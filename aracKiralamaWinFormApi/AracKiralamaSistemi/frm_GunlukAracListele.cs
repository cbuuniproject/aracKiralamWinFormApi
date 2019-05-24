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
	public partial class frm_GunlukAracListele : Form
	{
		public frm_GunlukAracListele()
		{
			InitializeComponent();
		}

		private async void btn_Listele_ClickAsync(object sender, EventArgs e)
		{
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
					using (var result = await client.GetAsync("api/GunlukAracTakip"))
					{
						// Check the Result
						if (result.IsSuccessStatusCode)
						{
							// Take the Result as a json string
							var value = result.Content.ReadAsStringAsync().Result;

							// Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
							dg_Listele.DataSource =
								JsonConvert.DeserializeObject<ResponseContent<GunlukAracTakip>>(value).Data.ToList();
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
	}
}
