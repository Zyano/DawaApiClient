using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Dawa.Api.ModelGenerator.models
{
    public class DataModelDescription
    {
        [JsonPropertyName("key")]
        public List<string> KeyAttributes { get; set; }

        [JsonPropertyName("attributes")]
        public List<DataModelAttribute> DataModelAttributes { get; set; }

        public IEnumerable<IEnumerable<string>> GetProperties()
        {
            return DataModelAttributes.Select(s => s.GenerateProperty());
        }

        public string GetKey()
        {
            return $"Key: {string.Join(",", KeyAttributes)}";
        }
    }
}