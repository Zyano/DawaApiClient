using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Navngivenvej
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}