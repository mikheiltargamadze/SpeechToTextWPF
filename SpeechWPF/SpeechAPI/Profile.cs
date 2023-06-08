using Newtonsoft.Json;

namespace APISpeech
{
    public class Profile
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("gender")]
        public object Gender { get; set; }
        [JsonProperty("birthday")]
        public object Birthday { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("province")]
        public string Province { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("avatar_url")]
        public object AvatarUrl { get; set; }
    }
}
