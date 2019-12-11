using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Bebyggelser
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("kode")]
        public long? Kode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}