using Newtonsoft.Json;
using System;

namespace APISpeech
{
    public class User
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("is_staff")]
        public bool IsStaff { get; set; }
        [JsonProperty("is_telegram_user")]
        public bool IsTelegramUser { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
        [JsonProperty("date_joined")]
        public DateTime DateJoined { get; set; }
        [JsonProperty("last_login")]
        public DateTime LastLogin { get; set; }
        [JsonProperty("invitation_link")]
        public string InvitationLink { get; set; }
        [JsonProperty("invitation_link_telegram")]
        public string InvitationLinkTelegram { get; set; }
        [JsonProperty("nevisa_service_account")]
        public NevisaServiceAccount NevisaServiceAccount { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("profile")]
        public Profile Profile { get; set; }
        [JsonProperty("new_messages_count")]
        public int NewMessagesCount { get; set; }
    }
}
