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
