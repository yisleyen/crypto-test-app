using crypto_test_app.Db;
using crypto_test_app.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace crypto_test_app
{
    public partial class MainForm : Form
    {
        public string apiLink = "https://api.coingecko.com/api/v3/";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            // GetCoinList();
        }


        private void GetCoinList()
        {
            var client = new RestClient(apiLink);
            var request = new RestRequest(txt_message.Text.Trim(), Method.GET);
            request.RequestFormat = DataFormat.Json;

            try
            {
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string content = response.Content.ToString();

                    var data = JsonConvert.DeserializeObject<List<Coins>>(content);

                    foreach (var item in data)
                    {
                        Coins coins = new Coins();
                        coins.id = item.id;
                        coins.name = item.name;
                        coins.symbol = item.symbol;

                        Functions.InsertCoin(coins);

                        list.Items.Add("Coin Name: " + item.name);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.WriteLog("GetCoinList() " + ex.Message);
            }
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            GetCoinDetails("bitcoin");
        }

        private void GetCoinDetails(string coinid)
        {
            var client = new RestClient(apiLink);
            var request = new RestRequest(txt_message_2.Text.Replace("{id}", coinid).Trim(), Method.GET);
            request.RequestFormat = DataFormat.Json;

            try
            {
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string content = response.Content.ToString();

                    // var data = JsonConvert.DeserializeObject<List<Coins>>(content);

                    
                }
            }
            catch (Exception ex)
            {
                Utils.WriteLog("GetCoinDetails() " + ex.Message);
            }
        }
    }
}
