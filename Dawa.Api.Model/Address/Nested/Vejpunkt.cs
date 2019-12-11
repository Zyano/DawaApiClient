using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Vejpunkt
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("kilde")]
        public string Kilde { get; set; }

        [JsonProperty("nøjagtighed")]
        public string Nøjagtighed { get; set; }

        [JsonProperty("tekniskstandard")]
        public string Tekniskstandard { get; set; }

        [JsonProperty("koordinater")]
        public List<decimal> Koordinater { get; set; }

        [JsonProperty("ændret")]
        public DateTimeOffset Ændret { get; set; }
    }
}