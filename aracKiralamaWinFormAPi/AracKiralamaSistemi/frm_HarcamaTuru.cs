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
    public partial class frm_HarcamaTuru : Form
    {
        public frm_HarcamaTuru()
        {
            InitializeComponent();
        }

		private async void btnHarcamaTip_ClickAsync(object sender, EventArgs e)
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
					HarcamaTuru rol = new HarcamaTuru { harcamaTuru=txtHarcamaTip.Text };

					// Serialize C# object to Json Object
					var serializedProduct = JsonConvert.SerializeObject(rol);
					// Json object to System.Net.Http content type
					var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
					// Post Request to the URI
					var result = await client.PostAsync("api/HarcamaTuru", content);
					// Check for result
					if (result.IsSuccessStatusCode)
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
