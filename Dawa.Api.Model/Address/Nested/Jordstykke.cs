using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Jordstykke
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("ejerlav")]
        public JordstykkeEjerlav Ejerlav { get; set; }

        [JsonProperty("matrikelnr")]
        public string Matrikelnr { get; set; }

        [JsonProperty("esrejendomsnr")]
        public long Esrejendomsnr { get; set; }
    }
}