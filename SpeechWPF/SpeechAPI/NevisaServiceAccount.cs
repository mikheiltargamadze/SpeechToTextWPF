using Newtonsoft.Json;

namespace APISpeech
{
    public class NevisaServiceAccount
    {
        [JsonProperty("current_charge")]
        public int CurrentCharge { get; set; }
        [JsonProperty("usage_remained")]
        public int UsageRemained { get; set; }
        [JsonProperty("is_usage_infinite")]
        public bool IsUsageInfinite { get; set; }
        [JsonProperty("has_service")]
        public bool HasService { get; set; }
        [JsonProperty("current_service_record")]
        public CurrentServiceRecord CurrentServiceRecord { get; set; }
        [JsonProperty("reserved_service_record")]
        public object ReservedServiceRecord { get; set; }
        [JsonProperty("configuration")]
        public Configuration Configuration { get; set; }
    }
}
