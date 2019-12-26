using crypto_test_app.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto_test_app.Db
{
    public class Functions
    {
        public static void InsertCoin(Coins coins)
        {
            string sql = "insert into coins (coin_id, coin_name, coin_symbol, is_listed) values (@coinid, @coinname, @coinsymbol, @islisted)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coinid", coins.id);
            keys.Add("@coinname", coins.name);
            keys.Add("@coinsymbol", coins.symbol);
            keys.Add("@islisted", DBNull.Value);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoin() " + ex.Message);
            }
        }

        public static void InsertCoinDetails(string coinid, CoinDetails coinDetails)
        {
            string sql = "insert into coin_details (coin_id, coin_name, coin_symbol, asset_platform_id, block_time_in_minutes, hashing_algorithm, categories, localization, description, image_thumb, image_small, image_large, country_origin, genesis_date, sentiment_votes_up_percentage, sentiment_votes_down_percentage, market_cap_rank, coingecko_rank, coingecko_score, developer_score, community_score, liquidity_score, public_interest_score, updated_date)" +
                " values" +
                " (@coin_id, @coin_name, @coin_symbol, @asset_platform_id, @block_time_in_minutes, @hashing_algorithm, @categories, @localization, @description, @image_thumb, @image_small, @image_large, @country_origin, @genesis_date, @sentiment_votes_up_percentage, @sentiment_votes_down_percentage, @market_cap_rank, @coingecko_rank, @coingecko_score, @developer_score, @community_score, @liquidity_score, @public_interest_score, @updated_date)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coin_id", coinid);
            keys.Add("@coin_name", coinDetails.name);
            keys.Add("@coin_symbol", coinDetails.symbol);
            keys.Add("@asset_platform_id", coinDetails.asset_platform_id == null ? DBNull.Value : (object)coinDetails.asset_platform_id);
            keys.Add("@block_time_in_minutes", coinDetails.block_time_in_minutes);
            keys.Add("@hashing_algorithm", coinDetails.hashing_algorithm);
            keys.Add("@categories", coinDetails.categories[0]);
            keys.Add("@localization", coinDetails.localization.tr);
            keys.Add("@description", coinDetails.description.tr);
            keys.Add("@image_thumb", coinDetails.image.thumb);
            keys.Add("@image_small", coinDetails.image.small);
            keys.Add("@image_large", coinDetails.image.large);
            keys.Add("@country_origin", coinDetails.country_origin == null ? DBNull.Value : (object)coinDetails.country_origin);
            keys.Add("@genesis_date", coinDetails.genesis_date);
            keys.Add("@sentiment_votes_up_percentage", coinDetails.sentiment_votes_up_percentage);
            keys.Add("@sentiment_votes_down_percentage", coinDetails.sentiment_votes_down_percentage);
            keys.Add("@market_cap_rank", coinDetails.market_cap_rank);
            keys.Add("@coingecko_rank", coinDetails.coingecko_rank);
            keys.Add("@coingecko_score", coinDetails.coingecko_score);
            keys.Add("@developer_score", coinDetails.developer_score);
            keys.Add("@community_score", coinDetails.community_score);
            keys.Add("@liquidity_score", coinDetails.liquidity_score);
            keys.Add("@public_interest_score", coinDetails.public_interest_score);
            keys.Add("@updated_date", DateTime.Now);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoinDetails() " + ex.Message);
            }
        }

        public static void InsertCoinDetailUrls(string coinid, int type, string url)
        {
            string sql = "insert into coin_detailurls (coin_id, type, url, created_date) values (@coinid, @type, @url, @createddate)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coinid", coinid);
            keys.Add("@type", type);
            keys.Add("@url", url);
            keys.Add("@createddate", DateTime.Now);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoinDetailUrls() " + ex.Message);
            }
        }

        public static void InsertCoinDetailLinks(string coinid, string twitter_screen_name, string facebook_username, string bitcointalk_thread_identifier, string telegram_channel_identifier, string subreddit_url)
        {
            string sql = "insert into coin_detaillinks (coin_id, twitter_screen_name, facebook_username, bitcointalk_thread_identifier, telegram_channel_identifier, subreddit_url, created_date)" +
                " values (@coinid, @twitter_screen_name, @facebook_username, @bitcointalk_thread_identifier, @telegram_channel_identifier, @subreddit_url, @createddate)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coinid", coinid);
            keys.Add("@twitter_screen_name", twitter_screen_name == null ? DBNull.Value : (object)twitter_screen_name);
            keys.Add("@facebook_username", facebook_username == null ? DBNull.Value : (object)facebook_username);
            keys.Add("@bitcointalk_thread_identifier", bitcointalk_thread_identifier == null ? DBNull.Value : (object)bitcointalk_thread_identifier);
            keys.Add("@telegram_channel_identifier", telegram_channel_identifier == null ? DBNull.Value : (object)telegram_channel_identifier);
            keys.Add("@subreddit_url", subreddit_url == null ? DBNull.Value : (object)subreddit_url);
            keys.Add("@createddate", DateTime.Now);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoinDetailLinks() " + ex.Message);
            }
        }

        public static void InsertCoinCommunity(string coinid, string facebook_likes, string twitter_followers, string reddit_average_posts_48h, string reddit_average_comments_48h, string reddit_subscribers, string reddit_accounts_active_48h, string telegram_channel_user_count)
        {
            string sql = "insert into coin_community (coin_id, facebook_likes, twitter_followers, reddit_average_posts_48h, reddit_average_comments_48h, reddit_subscribers, reddit_accounts_active_48h, telegram_channel_user_count, updated_date)" +
                " values" +
                " (@coinid, @facebook_likes, @twitter_followers, @reddit_average_posts_48h, @reddit_average_comments_48h, @reddit_subscribers, @reddit_accounts_active_48h, @telegram_channel_user_count, @updated_date)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coinid", coinid);
            keys.Add("@facebook_likes", facebook_likes == null ? DBNull.Value : (object)facebook_likes);
            keys.Add("@twitter_followers", twitter_followers == null ? DBNull.Value : (object)twitter_followers);
            keys.Add("@reddit_average_posts_48h", reddit_average_posts_48h == null ? DBNull.Value : (object)reddit_average_posts_48h);
            keys.Add("@reddit_average_comments_48h", reddit_average_comments_48h == null ? DBNull.Value : (object)reddit_average_comments_48h);
            keys.Add("@reddit_subscribers", reddit_subscribers == null ? DBNull.Value : (object)reddit_subscribers);
            keys.Add("@reddit_accounts_active_48h", reddit_accounts_active_48h == null ? DBNull.Value : (object)reddit_accounts_active_48h);
            keys.Add("@telegram_channel_user_count", telegram_channel_user_count == null ? DBNull.Value : (object)telegram_channel_user_count);
            keys.Add("@updated_date", DateTime.Now);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoinCommunity() " + ex.Message);
            }
        }

        public static void InsertCoinMarkets(string coinid, decimal price_change_percentage_24h, decimal price_change_percentage_7d, decimal price_change_percentage_14d, decimal price_change_percentage_30d, decimal price_change_percentage_60d, decimal price_change_percentage_200d, decimal price_change_percentage_1y)
        {
            string sql = "insert into coin_detailmarkets (coin_id, price_change_percentage_24h, price_change_percentage_7d, price_change_percentage_14d, price_change_percentage_30d, price_change_percentage_60d, price_change_percentage_200d, price_change_percentage_1y, updated_date)" +
                " values" +
                " (@coinid, @price_change_percentage_24h, @price_change_percentage_7d, @price_change_percentage_14d, @price_change_percentage_30d, @price_change_percentage_60d, @price_change_percentage_200d, @price_change_percentage_1y, @updated_date)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coinid", coinid);
            keys.Add("@price_change_percentage_24h", price_change_percentage_24h);
            keys.Add("@price_change_percentage_7d", price_change_percentage_7d);
            keys.Add("@price_change_percentage_14d", price_change_percentage_14d);
            keys.Add("@price_change_percentage_30d", price_change_percentage_30d);
            keys.Add("@price_change_percentage_60d", price_change_percentage_60d);
            keys.Add("@price_change_percentage_200d", price_change_percentage_200d);
            keys.Add("@price_change_percentage_1y", price_change_percentage_1y);
            keys.Add("@updated_date", DateTime.Now);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoinMarkets() " + ex.Message);
            }
        }

        public static void InsertCoinMarketPrices(string tablename, string coinid, decimal tl, decimal eur, decimal usd)
        {
            string sql = "insert into " + tablename + " (coin_id, try, eur, usd, updated_date)" +
                " values" +
                " (@coinid, @tl, @eur, @usd, @updated_date)" + Environment.NewLine;

            Dictionary<string, object> keys = new Dictionary<string, object>();
            keys.Add("@coinid", coinid);
            keys.Add("@tl", tl);
            keys.Add("@eur", eur);
            keys.Add("@usd", usd);
            keys.Add("@updated_date", DateTime.Now);

            try
            {
                SqlHelper.ExecuteSqlQuery(sql, keys);
            }
            catch (Exception ex)
            {
                Utils.WriteLog("InsertCoinMarketPrices() " + ex.Message);
            }
        }
    }

    public class Utils
    {
        public static void WriteLog(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = "Logs\\";
            logFilePath = logFilePath + "Log-" + DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(strLog);
            log.Close();
        }
    }
}
