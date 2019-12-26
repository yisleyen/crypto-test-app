using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto_test_app.Entities
{
    public class CoinDetails
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("symbol")]
        public string symbol { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("asset_platform_id")]
        public string asset_platform_id { get; set; }

        [JsonProperty("block_time_in_minutes")]
        public int block_time_in_minutes { get; set; }

        [JsonProperty("hashing_algorithm")]
        public string hashing_algorithm { get; set; }

        [JsonProperty("categories")]
        public List<string> categories { get; set; }

        [JsonProperty("localization")]
        public glocalization localization { get; set; }

        [JsonProperty("description")]
        public gdescription description { get; set; }

        [JsonProperty("links")]
        public glinks links { get; set; }

        [JsonProperty("image")]
        public gimage image { get; set; }

        [JsonProperty("country_origin")]
        public string country_origin { get; set; }

        [JsonProperty("genesis_date")]
        public DateTime genesis_date { get; set; }

        [JsonProperty("sentiment_votes_up_percentage")]
        public decimal sentiment_votes_up_percentage { get; set; }

        [JsonProperty("sentiment_votes_down_percentage")]
        public decimal sentiment_votes_down_percentage { get; set; }

        [JsonProperty("market_cap_rank")]
        public decimal market_cap_rank { get; set; }

        [JsonProperty("coingecko_rank")]
        public decimal coingecko_rank { get; set; }

        [JsonProperty("coingecko_score")]
        public decimal coingecko_score { get; set; }

        [JsonProperty("developer_score")]
        public decimal developer_score { get; set; }

        [JsonProperty("community_score")]
        public decimal community_score { get; set; }

        [JsonProperty("liquidity_score")]
        public decimal liquidity_score { get; set; }

        [JsonProperty("public_interest_score")]
        public decimal public_interest_score { get; set; }

        [JsonProperty("market_data")]
        public gmarket_data market_data { get; set; }

        [JsonProperty("community_data")]
        public gcommunity_data community_data { get; set; }
    }

    public class glocalization
    {
        [JsonProperty("tr")]
        public string tr { get; set; }
    }

    public class gdescription
    {
        [JsonProperty("tr")]
        public string tr { get; set; }
    }

    public class glinks
    {
        [JsonProperty("homepage")]
        public List<string> homepage { get; set; }

        [JsonProperty("blockchain_site")]
        public List<string> blockchain_site { get; set; }

        [JsonProperty("official_forum_url")]
        public List<string> official_forum_url { get; set; }

        [JsonProperty("chat_url")]
        public List<string> chat_url { get; set; }

        [JsonProperty("announcement_url")]
        public List<string> announcement_url { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string twitter_screen_name { get; set; }

        [JsonProperty("facebook_username")]
        public string facebook_username { get; set; }

        [JsonProperty("bitcointalk_thread_identifier")]
        public string bitcointalk_thread_identifier { get; set; }

        [JsonProperty("telegram_channel_identifier")]
        public string telegram_channel_identifier { get; set; }

        [JsonProperty("subreddit_url")]
        public string subreddit_url { get; set; }

        [JsonProperty("repos_url")]
        public grepos_url repos_url { get; set; }
    }
    
    public class grepos_url
    {
        [JsonProperty("github")]
        public List<string> github { get; set; }

        [JsonProperty("bitbucket")]
        public List<string> bitbucket { get; set; }
    }

    public class gimage
    {
        [JsonProperty("thumb")]
        public string thumb { get; set; }

        [JsonProperty("small")]
        public string small { get; set; }

        [JsonProperty("large")]
        public string large { get; set; }
    }

    public class gmarket_data
    {
        [JsonProperty("current_price")]
        public gcurrent_price current_price { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public decimal price_change_percentage_24h { get; set; }

        [JsonProperty("price_change_percentage_7d")]
        public decimal price_change_percentage_7d { get; set; }

        [JsonProperty("price_change_percentage_14d")]
        public decimal price_change_percentage_14d { get; set; }

        [JsonProperty("price_change_percentage_30d")]
        public decimal price_change_percentage_30d { get; set; }

        [JsonProperty("price_change_percentage_60d")]
        public decimal price_change_percentage_60d { get; set; }

        [JsonProperty("price_change_percentage_200d")]
        public decimal price_change_percentage_200d { get; set; }

        [JsonProperty("price_change_percentage_1y")]
        public decimal price_change_percentage_1y { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency")]
        public gprice_change_percentage_1h_in_currency price_change_percentage_1h_in_currency { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency")]
        public gprice_change_percentage_24h_in_currency price_change_percentage_24h_in_currency { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency")]
        public gprice_change_percentage_7d_in_currency price_change_percentage_7d_in_currency { get; set; }

        [JsonProperty("price_change_percentage_14d_in_currency")]
        public gprice_change_percentage_14d_in_currency price_change_percentage_14d_in_currency { get; set; }

        [JsonProperty("price_change_percentage_30d_in_currency")]
        public gprice_change_percentage_30d_in_currency price_change_percentage_30d_in_currency { get; set; }

        [JsonProperty("price_change_percentage_60d_in_currency")]
        public gprice_change_percentage_60d_in_currency price_change_percentage_60d_in_currency { get; set; }

        [JsonProperty("price_change_percentage_200d_in_currency")]
        public gprice_change_percentage_200d_in_currency price_change_percentage_200d_in_currency { get; set; }

        [JsonProperty("price_change_percentage_1y_in_currency")]
        public gprice_change_percentage_1y_in_currency price_change_percentage_1y_in_currency { get; set; }

        [JsonProperty("last_updated")]
        public DateTime last_updated { get; set; }
    }

    public class gcurrent_price
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_1h_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_24h_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_7d_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_14d_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_30d_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_60d_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_200d_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gprice_change_percentage_1y_in_currency
    {
        [JsonProperty("try")]
        public decimal tl { get; set; }

        [JsonProperty("eur")]
        public decimal eur { get; set; }

        [JsonProperty("usd")]
        public decimal usd { get; set; }
    }

    public class gcommunity_data
    {
        [JsonProperty("facebook_likes")]
        public string facebook_likes { get; set; }

        [JsonProperty("twitter_followers")]
        public string twitter_followers { get; set; }
        
        [JsonProperty("reddit_average_posts_48h")]
        public string reddit_average_posts_48h { get; set; }

        [JsonProperty("reddit_average_comments_48h")]
        public string reddit_average_comments_48h { get; set; }

        [JsonProperty("reddit_subscribers")]
        public string reddit_subscribers { get; set; }

        [JsonProperty("reddit_accounts_active_48h")]
        public string reddit_accounts_active_48h { get; set; }

        [JsonProperty("telegram_channel_user_count")]
        public string telegram_channel_user_count { get; set; }
    }
}