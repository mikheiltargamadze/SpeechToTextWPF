using Newtonsoft.Json;

namespace APISpeech
{
    public class Service
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("deadline")]
        public int Deadline { get; set; }
        [JsonProperty("price_per_hour")]
        public int PricePerHour { get; set; }
        [JsonProperty("hour_limit")]
        public int HourLimit { get; set; }
        [JsonProperty("max_users")]
        public int MaxUsers { get; set; }
        [JsonProperty("actual_price")]
        public int ActualPrice { get; set; }
        [JsonProperty("is_for_telegram")]
        public bool IsForTelegram { get; set; }
        [JsonProperty("is_gift")]
        public bool IsGift { get; set; }
        [JsonProperty("is_infinite")]
        public bool IsInfinite { get; set; }
        [JsonProperty("is_for_enterprise")]
        public bool IsForEnterprise { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }

}
