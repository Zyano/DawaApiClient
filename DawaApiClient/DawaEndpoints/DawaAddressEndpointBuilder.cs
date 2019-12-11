using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dawa.Api.Client.DawaEndpoints
{
    public class DawaAddressEndpointBuilder
    {
        public static readonly string BaseUrl = "https://dawa.aws.dk/adresser";

        private readonly Dictionary<string, object> _requestParameters;

        public DawaAddressEndpointBuilder() : this(new Dictionary<string, object>()) { }

        public DawaAddressEndpointBuilder(Dictionary<string, object> requestParameters)
        {
            _requestParameters = requestParameters;
        }

        public IDictionary<string, object> GetParameters => _requestParameters.ToDictionary(g => g.Key, g => g.Value);

        public string GenerateUrl()
        {
            string url = BaseUrl;
            var kvList = _requestParameters.ToList();

            for (int i = 0; i < kvList.Count; i++)
            {
                var kv = kvList[i];
                if (i == 0)
                {
                    url += $"?{kv.Key}={HttpUtility.UrlEncode(kv.Value.ToString())}";
                }
                else
                {
                    url += $"&{kv.Key}={HttpUtility.UrlEncode(kv.Value.ToString())}";
                }
            }

            return url;
        }

        internal void UseMini()
        {
            AddOrUpdate("struktur", "mini");
        }

        internal void UseNested()
        {
            AddOrUpdate("struktur", "nestet");
        }

        internal void UseFlat()
        {
            AddOrUpdate("struktur", "flad");
        }

        public void AddMunicipality(string municipality)
        {
            AddOrUpdate("kommunekode", municipality);
        }

        /// <summary>
        /// CASE SENSITIVE!
        /// </summary>
        /// <param name="street"></param>
        public void AddStreetName(int street)
        {
            AddOrUpdate("vejnavn", street);
        }

        /// <summary>
        /// 	Søgetekst. Der søges i vejnavn, husnr, etage, dør, supplerende bynavn, postnr og postnummerets navn. Alle ord i søgeteksten skal matche adressebetegnelsen. Wildcard * er tilladt i slutningen af hvert ord. Der skelnes ikke mellem store og små bogstaver. Der returneres højst 1000 resultater ved anvendelse af parameteren.
        /// </summary>
        /// <param name="q"></param>
        public void AddFreeTextQuery(string q)
        {
            AddOrUpdate("q", q);
        }

        public void AddZipCode(int zipCode)
        {
            if (zipCode < 0 || zipCode > 9999)
            {
                throw new ArgumentException("Input most not exceed 4 characters and by larger than zero", nameof(zipCode));
            }
            AddOrUpdate("postnr", zipCode);
        }

        public void AddHouseNumber(int houseNumber, string letter)
        {
            if (houseNumber < 0 || houseNumber > 999)
            {
                throw new ArgumentException("Input most not exceed 3 characters and by larger than zero", nameof(houseNumber));
            }

            if (letter.Length > 1)
            {
                throw new ArgumentException("Input most not exceed 1 characters ", nameof(letter));
            }
            AddOrUpdate("husnr", houseNumber.ToString() + letter ?? "");
        }

        public void AddStreetCode(int streetCode)
        {
            if (streetCode < 0 || streetCode > 9999)
            {
                throw new ArgumentException("Input most not exceed 4 characters and by larger than zero", nameof(streetCode));
            }
            AddOrUpdate("vejkode", streetCode);
        }

        private void AddOrUpdate(string key, object value)
        {
            _requestParameters[key] = value;
        }
    }
}
