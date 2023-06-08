using Newtonsoft.Json;
using System.Collections.Generic;

namespace APISpeech
{
    public class Transcription
    {
        [JsonProperty("result")]
        public List<Result> Result { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
