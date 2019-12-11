using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Historik
    {
        [JsonProperty("oprettet")]
        public DateTimeOffset Oprettet { get; set; }

        [JsonProperty("ændret")]
        public DateTimeOffset Ændret { get; set; }

        [JsonProperty("ikrafttrædelse")]
        public DateTimeOffset Ikrafttrædelse { get; set; }

        [JsonProperty("nedlagt")]
        public object Nedlagt { get; set; }
    }
}