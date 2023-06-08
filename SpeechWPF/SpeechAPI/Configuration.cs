using Newtonsoft.Json;
using System;

namespace APISpeech
{
    public class Configuration
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("service_account")]
        public int ServiceAccount { get; set; }
        [JsonProperty("show_word_confidences")]
        public bool ShowWordConfidences { get; set; }
        [JsonProperty("telegram_english")]
        public bool TelegramEnglish { get; set; }
        [JsonProperty("save_transcriptions")]
        public bool SaveTranscriptions { get; set; }
        [JsonProperty("convert_punctuations")]
        public bool ConvertPunctuations { get; set; }
        [JsonProperty("convert_numbers")]
        public bool ConvertNumbers { get; set; }
        [JsonProperty("show_digits_in_english")]
        public bool ShowDigitsInEnglish { get; set; }
        [JsonProperty("add_number_separator")]
        public bool AddNumberSeparator { get; set; }
    }
}
