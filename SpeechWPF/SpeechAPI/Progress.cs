using Newtonsoft.Json;

namespace APISpeech
{
    public class Progress
    {
        [JsonProperty("pending")]
        public bool Pending { get; set; }
        [JsonProperty("current")]
        public int Current { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("percent")]
        public int Percent { get; set; }
    }
}
