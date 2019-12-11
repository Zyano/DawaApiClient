using System;
using Newtonsoft.Json;

namespace Dawa.Api.Model.Address.Flat
{
    public partial class DawaAdresseFlad
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("darstatus")]
        public long Darstatus { get; set; }

        [JsonProperty("oprettet")]
        public DateTimeOffset Oprettet { get; set; }

        [JsonProperty("ændret")]
        public DateTimeOffset Ændret { get; set; }

        [JsonProperty("ikrafttrædelse")]
        public DateTimeOffset Ikrafttrædelse { get; set; }

        [JsonProperty("nedlagt")]
        public object Nedlagt { get; set; }

        [JsonProperty("vejkode")]
        public long Vejkode { get; set; }

        [JsonProperty("vejnavn")]
        public string Vejnavn { get; set; }

        [JsonProperty("adresseringsvejnavn")]
        public string Adresseringsvejnavn { get; set; }

        [JsonProperty("husnr")]
        public long Husnr { get; set; }

        [JsonProperty("etage")]
        public string Etage { get; set; }

        [JsonProperty("dør")]
        public long Dør { get; set; }

        [JsonProperty("supplerendebynavn")]
        public object Supplerendebynavn { get; set; }

        [JsonProperty("postnr")]
        public long Postnr { get; set; }

        [JsonProperty("postnrnavn")]
        public string Postnrnavn { get; set; }

        [JsonProperty("stormodtagerpostnr")]
        public object Stormodtagerpostnr { get; set; }

        [JsonProperty("stormodtagerpostnrnavn")]
        public object Stormodtagerpostnrnavn { get; set; }

        [JsonProperty("kommunekode")]
        public string Kommunekode { get; set; }

        [JsonProperty("kommunenavn")]
        public string Kommunenavn { get; set; }

        [JsonProperty("ejerlavkode")]
        public long Ejerlavkode { get; set; }

        [JsonProperty("ejerlavnavn")]
        public string Ejerlavnavn { get; set; }

        [JsonProperty("matrikelnr")]
        public string Matrikelnr { get; set; }

        [JsonProperty("esrejendomsnr")]
        public long Esrejendomsnr { get; set; }

        [JsonProperty("etrs89koordinat_øst")]
        public decimal Etrs89KoordinatØst { get; set; }

        [JsonProperty("etrs89koordinat_nord")]
        public decimal Etrs89KoordinatNord { get; set; }

        [JsonProperty("wgs84koordinat_bredde")]
        public decimal Wgs84KoordinatBredde { get; set; }

        [JsonProperty("wgs84koordinat_længde")]
        public decimal Wgs84KoordinatLængde { get; set; }

        [JsonProperty("nøjagtighed")]
        public string Nøjagtighed { get; set; }

        [JsonProperty("kilde")]
        public long Kilde { get; set; }

        [JsonProperty("tekniskstandard")]
        public string Tekniskstandard { get; set; }

        [JsonProperty("tekstretning")]
        public long Tekstretning { get; set; }

        [JsonProperty("ddkn_m100")]
        public string DdknM100 { get; set; }

        [JsonProperty("ddkn_km1")]
        public string DdknKm1 { get; set; }

        [JsonProperty("ddkn_km10")]
        public string DdknKm10 { get; set; }

        [JsonProperty("adressepunktændringsdato")]
        public DateTimeOffset Adressepunktændringsdato { get; set; }

        [JsonProperty("adgangsadresseid")]
        public Guid Adgangsadresseid { get; set; }

        [JsonProperty("adgangsadresse_status")]
        public long AdgangsadresseStatus { get; set; }

        [JsonProperty("adgangsadresse_darstatus")]
        public long AdgangsadresseDarstatus { get; set; }

        [JsonProperty("adgangsadresse_oprettet")]
        public DateTimeOffset AdgangsadresseOprettet { get; set; }

        [JsonProperty("adgangsadresse_ændret")]
        public DateTimeOffset AdgangsadresseÆndret { get; set; }

        [JsonProperty("adgangsadresse_ikrafttrædelse")]
        public DateTimeOffset AdgangsadresseIkrafttrædelse { get; set; }

        [JsonProperty("adgangsadresse_nedlagt")]
        public object AdgangsadresseNedlagt { get; set; }

        [JsonProperty("regionskode")]
        public long Regionskode { get; set; }

        [JsonProperty("regionsnavn")]
        public string Regionsnavn { get; set; }

        [JsonProperty("jordstykke_ejerlavnavn")]
        public string JordstykkeEjerlavnavn { get; set; }

        [JsonProperty("jordstykke_ejerlavkode")]
        public long JordstykkeEjerlavkode { get; set; }

        [JsonProperty("jordstykke_matrikelnr")]
        public string JordstykkeMatrikelnr { get; set; }

        [JsonProperty("jordstykke_esrejendomsnr")]
        public long JordstykkeEsrejendomsnr { get; set; }

        [JsonProperty("højde")]
        public decimal Højde { get; set; }

        [JsonProperty("adgangspunktid")]
        public Guid Adgangspunktid { get; set; }

        [JsonProperty("vejpunkt_x")]
        public decimal VejpunktX { get; set; }

        [JsonProperty("vejpunkt_y")]
        public decimal VejpunktY { get; set; }

        [JsonProperty("vejpunkt_id")]
        public Guid VejpunktId { get; set; }

        [JsonProperty("vejpunkt_kilde")]
        public string VejpunktKilde { get; set; }

        [JsonProperty("vejpunkt_nøjagtighed")]
        public string VejpunktNøjagtighed { get; set; }

        [JsonProperty("vejpunkt_tekniskstandard")]
        public string VejpunktTekniskstandard { get; set; }

        [JsonProperty("vejpunkt_ændret")]
        public DateTimeOffset VejpunktÆndret { get; set; }

        [JsonProperty("sognekode")]
        public long Sognekode { get; set; }

        [JsonProperty("sognenavn")]
        public string Sognenavn { get; set; }

        [JsonProperty("politikredskode")]
        public long Politikredskode { get; set; }

        [JsonProperty("politikredsnavn")]
        public string Politikredsnavn { get; set; }

        [JsonProperty("retskredskode")]
        public long Retskredskode { get; set; }

        [JsonProperty("retskredsnavn")]
        public string Retskredsnavn { get; set; }

        [JsonProperty("opstillingskredskode")]
        public string Opstillingskredskode { get; set; }

        [JsonProperty("opstillingskredsnavn")]
        public string Opstillingskredsnavn { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }

        [JsonProperty("afstemningsområdenummer")]
        public long Afstemningsområdenummer { get; set; }

        [JsonProperty("afstemningsområdenavn")]
        public string Afstemningsområdenavn { get; set; }

        [JsonProperty("menighedsrådsafstemningsområdenummer")]
        public long Menighedsrådsafstemningsområdenummer { get; set; }

        [JsonProperty("menighedsrådsafstemningsområdenavn")]
        public string Menighedsrådsafstemningsområdenavn { get; set; }

        [JsonProperty("brofast")]
        public bool Brofast { get; set; }

        [JsonProperty("supplerendebynavn_dagi_id")]
        public object SupplerendebynavnDagiId { get; set; }

        [JsonProperty("navngivenvej_id")]
        public Guid NavngivenvejId { get; set; }

        [JsonProperty("storkredsnummer")]
        public long Storkredsnummer { get; set; }

        [JsonProperty("storkredsnavn")]
        public string Storkredsnavn { get; set; }

        [JsonProperty("valglandsdelsbogstav")]
        public string Valglandsdelsbogstav { get; set; }

        [JsonProperty("valglandsdelsnavn")]
        public string Valglandsdelsnavn { get; set; }

        [JsonProperty("landsdelsnuts3")]
        public string Landsdelsnuts3 { get; set; }

        [JsonProperty("landsdelsnavn")]
        public string Landsdelsnavn { get; set; }

        [JsonProperty("kvhx")]
        public string Kvhx { get; set; }

        [JsonProperty("kvh")]
        public string Kvh { get; set; }
    }
}
