using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Afstemningsområde
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("nummer")]
        public long Nummer { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }
    }
}