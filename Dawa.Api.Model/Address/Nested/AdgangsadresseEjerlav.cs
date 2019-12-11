using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class AdgangsadresseEjerlav
    {
        [JsonProperty("kode")]
        public long Kode { get; set; }

        [JsonProperty("navn")]
        public string Navn { get; set; }
    }
}