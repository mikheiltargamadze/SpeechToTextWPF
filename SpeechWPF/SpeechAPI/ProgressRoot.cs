using Newtonsoft.Json;

namespace APISpeech
{
    public class ProgressRoot
    {
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("complete")]
        public bool Complete { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("progress")]
        public Progress Progress { get; set; }
        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}
