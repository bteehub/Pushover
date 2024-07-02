using Newtonsoft.Json;
using System;

namespace Pushover.Entity.Reponse
{
    public class RateLimit
    {
        [JsonProperty("limit")]
        public int Limit;

        [JsonProperty("remaining")]
        public int Remaining;

        [JsonProperty("reset")]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.UnixDateTimeConverter))]
        public DateTime Reset;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("request")]
        public string Request;
    }
}
