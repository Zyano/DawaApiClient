using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Ddkn
    {
        [JsonProperty("m100")]
        public string M100 { get; set; }

        [JsonProperty("km1")]
        public string Km1 { get; set; }

        [JsonProperty("km10")]
        public string Km10 { get; set; }
    }
}