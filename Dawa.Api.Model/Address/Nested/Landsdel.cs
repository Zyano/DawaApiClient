using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Landsdel
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("nuts3")]
        public string Nuts3 { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }
    }
}