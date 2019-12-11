using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class JordstykkeEjerlav
    {
        [JsonProperty("kode")]
        public long Kode { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }
    }
}