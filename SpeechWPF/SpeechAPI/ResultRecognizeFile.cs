using Newtonsoft.Json;
using System;

namespace APISpeech
{
    internal class ResultRecognizeFile
    {
        [JsonProperty("progress_url")]
        public string ProgressUrl { get; set; }
        [JsonProperty("task_id")]
        public Guid TaskId { get; set; }

    }
}
