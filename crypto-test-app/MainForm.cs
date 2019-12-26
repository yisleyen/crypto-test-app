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
            GetCoinList();
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

            label1.Text = "Finished";
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

                    CoinDetails coinDetails = JsonConvert.DeserializeObject<CoinDetails>(content);

                    #region details

                    Functions.InsertCoinDetails(coinid, coinDetails);

                    #endregion

                    #region links

                    Functions.InsertCoinDetailLinks(coinid, coinDetails.links.twitter_screen_name, coinDetails.links.facebook_username, coinDetails.links.bitcointalk_thread_identifier, coinDetails.links.telegram_channel_identifier, coinDetails.links.subreddit_url);

                    foreach (var page in coinDetails.links.homepage) // type = 1
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 1, page);
                        }
                    }

                    foreach (var page in coinDetails.links.blockchain_site) // type = 2
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 2, page);
                        }
                    }

                    foreach (var page in coinDetails.links.official_forum_url) // type = 3
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 3, page);
                        }
                    }

                    foreach (var page in coinDetails.links.chat_url) // type = 4
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 4, page);
                        }
                    }

                    foreach (var page in coinDetails.links.announcement_url) // type = 5
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 5, page);
                        }
                    }

                    foreach (var page in coinDetails.links.repos_url.github) // type = 6
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 6, page);
                        }
                    }

                    foreach (var page in coinDetails.links.repos_url.bitbucket) // type = 7
                    {
                        if (!string.IsNullOrEmpty(page))
                        {
                            Functions.InsertCoinDetailUrls(coinid, 7, page);
                        }
                    }

                    #endregion

                    #region community_data

                    Functions.InsertCoinCommunity(coinid, coinDetails.community_data.facebook_likes, coinDetails.community_data.twitter_followers, coinDetails.community_data.reddit_average_posts_48h, coinDetails.community_data.reddit_average_comments_48h, coinDetails.community_data.reddit_subscribers, coinDetails.community_data.reddit_accounts_active_48h, coinDetails.community_data.telegram_channel_user_count);

                    #endregion

                    #region markets

                    Functions.InsertCoinMarkets(coinid, coinDetails.market_data.price_change_percentage_24h, coinDetails.market_data.price_change_percentage_7d, coinDetails.market_data.price_change_percentage_14d, coinDetails.market_data.price_change_percentage_30d, coinDetails.market_data.price_change_percentage_60d, coinDetails.market_data.price_change_percentage_200d, coinDetails.market_data.price_change_percentage_1y);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_prices", coinid, coinDetails.market_data.current_price.tl, coinDetails.market_data.current_price.eur, coinDetails.market_data.current_price.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_7dprices", coinid, coinDetails.market_data.price_change_percentage_1h_in_currency.tl, coinDetails.market_data.price_change_percentage_1h_in_currency.eur, coinDetails.market_data.price_change_percentage_1h_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_60dprices", coinid, coinDetails.market_data.price_change_percentage_24h_in_currency.tl, coinDetails.market_data.price_change_percentage_24h_in_currency.eur, coinDetails.market_data.price_change_percentage_24h_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_30dprices", coinid, coinDetails.market_data.price_change_percentage_7d_in_currency.tl, coinDetails.market_data.price_change_percentage_7d_in_currency.eur, coinDetails.market_data.price_change_percentage_7d_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_24hprices", coinid, coinDetails.market_data.price_change_percentage_14d_in_currency.tl, coinDetails.market_data.price_change_percentage_14d_in_currency.eur, coinDetails.market_data.price_change_percentage_14d_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_200dprices", coinid, coinDetails.market_data.price_change_percentage_30d_in_currency.tl, coinDetails.market_data.price_change_percentage_30d_in_currency.eur, coinDetails.market_data.price_change_percentage_30d_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_1yprices", coinid, coinDetails.market_data.price_change_percentage_60d_in_currency.tl, coinDetails.market_data.price_change_percentage_60d_in_currency.eur, coinDetails.market_data.price_change_percentage_60d_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_1hprices", coinid, coinDetails.market_data.price_change_percentage_200d_in_currency.tl, coinDetails.market_data.price_change_percentage_200d_in_currency.eur, coinDetails.market_data.price_change_percentage_200d_in_currency.usd);

                    Functions.InsertCoinMarketPrices("coin_detailmarket_14dprices", coinid, coinDetails.market_data.price_change_percentage_1y_in_currency.tl, coinDetails.market_data.price_change_percentage_1y_in_currency.eur, coinDetails.market_data.price_change_percentage_1y_in_currency.usd);

                    #endregion
                }
            }
            catch (Exception ex)
            {
                Utils.WriteLog("GetCoinDetails() " + ex.Message);
            }
        }
    }
}
