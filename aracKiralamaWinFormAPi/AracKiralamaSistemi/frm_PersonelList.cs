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
	public partial class frm_PersonelList : Form
	{
		public frm_PersonelList()
		{
			InitializeComponent();
		}

		private void frm_PersonelList_Load(object sender, EventArgs e)
		{/*
			using (var calisanSoapClient = new CalisanWebServiceSoapClient())
			{
				dataGridView1.DataSource = calisanSoapClient.SelectAllCalisans();
			}*/
		}

		private async void button1_ClickAsync(object sender, EventArgs e)
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
					using (var result = await client.GetAsync("api/Calisan"))
					{
						// Check the Result
						if (result.IsSuccessStatusCode)
						{
							// Take the Result as a json string
							var value = result.Content.ReadAsStringAsync().Result;

							// Deserialize the string with a Json Converter to ResponseContent object and fill the datagrid
							dg_Personel.DataSource =
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
	}
}
