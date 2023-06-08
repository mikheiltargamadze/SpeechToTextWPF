using Newtonsoft.Json;
using System;

namespace APISpeech
{
    public class CurrentServiceRecord
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }
        [JsonProperty("service")]
        public Service Service { get; set; }
    }
}
