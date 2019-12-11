using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Adgangspunkt
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("koordinater")]
        public List<decimal> Koordinater { get; set; }

        [JsonProperty("højde")]
        public decimal Højde { get; set; }

        [JsonProperty("nøjagtighed")]
        public string Nøjagtighed { get; set; }

        [JsonProperty("kilde")]
        public long Kilde { get; set; }

        [JsonProperty("tekniskstandard")]
        public string Tekniskstandard { get; set; }

        [JsonProperty("tekstretning")]
        public long Tekstretning { get; set; }

        [JsonProperty("ændret")]
        public DateTimeOffset Ændret { get; set; }
    }
}
