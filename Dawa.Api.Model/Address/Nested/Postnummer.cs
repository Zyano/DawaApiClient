using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Postnummer
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("nr")]
        public long Nr { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }
    }
}