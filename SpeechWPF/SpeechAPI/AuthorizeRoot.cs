using Newtonsoft.Json;

namespace APISpeech
{
    public class AuthorizeRoot
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
