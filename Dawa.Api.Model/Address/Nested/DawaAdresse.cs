using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class DawaAdresse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("kvhx")]
        public string Kvhx { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("darstatus")]
        public long Darstatus { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("historik")]
        public Historik Historik { get; set; }

        [JsonProperty("etage")]
        public string Etage { get; set; }

        [JsonProperty("dør")]
        public long Dør { get; set; }

        [JsonProperty("adressebetegnelse")]
        public string Adressebetegnelse { get; set; }

        [JsonProperty("adgangsadresse")]
        public Adgangsadresse Adgangsadresse { get; set; }
    }
}