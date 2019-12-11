using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Valglandsdel
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("bogstav")]
        public string Bogstav { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }
    }
}