using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Mini
{
    public class DawaAdresseMini
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("darstatus")]
        public int Darstatus { get; set; }

        [JsonProperty("vejkode")]
        public int Vejkode { get; set; }

        [JsonProperty("vejnavn")]
        public string Vejnavn { get; set; }

        [JsonProperty("adresseringsvejnavn")]
        public string Adresseringsvejnavn { get; set; }

        [JsonProperty("husnr")]
        public string Husnr { get; set; }

        [JsonProperty("etage")]
        public string Etage { get; set; }

        [JsonProperty("dør")]
        public string Dør { get; set; }

        [JsonProperty("supplerendebynavn")]
        public object Supplerendebynavn { get; set; }

        [JsonProperty("postnr")]
        public int Postnr { get; set; }

        [JsonProperty("postnrnavn")]
        public string Postnrnavn { get; set; }

        [JsonProperty("stormodtagerpostnr")]
        public int? Stormodtagerpostnr { get; set; }

        [JsonProperty("stormodtagerpostnrnavn")]
        public string Stormodtagerpostnrnavn { get; set; }

        [JsonProperty("kommunekode")]
        public string Kommunekode { get; set; }

        [JsonProperty("adgangsadresseid")]
        public Guid Adgangsadresseid { get; set; }

        [JsonProperty("x")]
        public decimal X { get; set; }

        [JsonProperty("y")]
        public decimal Y { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("betegnelse")]
        public string Betegnelse { get; set; }
    }
}
