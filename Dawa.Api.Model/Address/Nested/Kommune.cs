using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Kommune
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("kode")]
        public string Kode { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }

        [JsonProperty("adresseringsnavn", NullValueHandling = NullValueHandling.Ignore)]
        public string Adresseringsnavn { get; set; }
    }
}