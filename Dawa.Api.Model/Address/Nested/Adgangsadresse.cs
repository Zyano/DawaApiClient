using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Nested
{
    public class Adgangsadresse
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("kvh")]
        public string Kvh { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("darstatus")]
        public long Darstatus { get; set; }

        [JsonProperty("vejstykke")]
        public Kommune Vejstykke { get; set; }

        [JsonProperty("husnr")]
        public long Husnr { get; set; }

        [JsonProperty("navngivenvej")]
        public Navngivenvej Navngivenvej { get; set; }

        [JsonProperty("supplerendebynavn")]
        public object Supplerendebynavn { get; set; }

        [JsonProperty("supplerendebynavn2")]
        public object Supplerendebynavn2 { get; set; }

        [JsonProperty("postnummer")]
        public Postnummer Postnummer { get; set; }

        [JsonProperty("stormodtagerpostnummer")]
        public object Stormodtagerpostnummer { get; set; }

        [JsonProperty("kommune")]
        public Kommune Kommune { get; set; }

        [JsonProperty("ejerlav")]
        public AdgangsadresseEjerlav Ejerlav { get; set; }

        [JsonProperty("esrejendomsnr")]
        public long Esrejendomsnr { get; set; }

        [JsonProperty("matrikelnr")]
        public string Matrikelnr { get; set; }

        [JsonProperty("historik")]
        public Historik Historik { get; set; }

        [JsonProperty("adgangspunkt")]
        public Adgangspunkt Adgangspunkt { get; set; }

        [JsonProperty("vejpunkt")]
        public Vejpunkt Vejpunkt { get; set; }

        [JsonProperty("DDKN")]
        public Ddkn Ddkn { get; set; }

        [JsonProperty("sogn")]
        public Kommune Sogn { get; set; }

        [JsonProperty("region")]
        public Kommune Region { get; set; }

        [JsonProperty("landsdel")]
        public Landsdel Landsdel { get; set; }

        [JsonProperty("retskreds")]
        public Kommune Retskreds { get; set; }

        [JsonProperty("politikreds")]
        public Kommune Politikreds { get; set; }

        [JsonProperty("opstillingskreds")]
        public Kommune Opstillingskreds { get; set; }

        [JsonProperty("afstemningsområde")]
        public Afstemningsområde Afstemningsområde { get; set; }

        [JsonProperty("storkreds")]
        public Afstemningsområde Storkreds { get; set; }

        [JsonProperty("valglandsdel")]
        public Valglandsdel Valglandsdel { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("jordstykke")]
        public Jordstykke Jordstykke { get; set; }

        [JsonProperty("bebyggelser")]
        public List<Bebyggelser> Bebyggelser { get; set; }

        [JsonProperty("brofast")]
        public bool Brofast { get; set; }
    }
}