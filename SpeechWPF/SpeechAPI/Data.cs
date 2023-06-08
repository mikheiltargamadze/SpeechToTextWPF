using Newtonsoft.Json;

namespace APISpeech
{
    public class Data
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
