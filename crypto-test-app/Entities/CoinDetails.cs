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

        [JsonProperty("categories")]
        public string categories { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }


    }
}
