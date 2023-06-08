using Newtonsoft.Json;

namespace APISpeech
{
    public class Result
    {
        [JsonProperty("transcription")]
        public Transcription Transcription { get; set; }
        [JsonProperty("final")]
        public bool Final { get; set; }
        [JsonProperty("conf")]
        public double Conf { get; set; }
        [JsonProperty("end")]
        public double End { get; set; }
        [JsonProperty("start")]
        public double Start { get; set; }
        [JsonProperty("word")]
        public string Word { get; set; }
        [JsonProperty("space_after")]
        public bool SpaceAfter { get; set; }
    }
}
