using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Dawa.Api.ModelGenerator.models
{
    public class DataModelAttribute
    {
        private Dictionary<string, Type> mapping = new Dictionary<string, Type>()
        {
            { "uuid", typeof(Guid) },
            { "string", typeof(string) },
            { "integer", typeof(int) },
            { "localdatetime", typeof(DateTime) },
            { "real", typeof(string) },
            { "geometry", typeof(string) },
            { "geometry3d", typeof(string) },
        };

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("nullable")]
        public bool Nullable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        public IEnumerable<string> GenerateProperty()
        {
            if (!IsTypeMappingKnown)
            {
                return Enumerable.Empty<string>();
            }

            var desc = Description.Split(new[] { "\r\n", "\t", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(s => "/// " + s).ToArray();

            var props = new List<string>();
            props.Add($"/// <summary>");
            props.AddRange(desc);
            props.Add($"/// Nullable: {Nullable} ");
            props.Add($"/// </summary>");
            props.Add($"[Newtonsoft.Json.JsonProperty(\"{Name}\")]");
            props.Add($"public {GetDataType()} {Name}" + " {get;set;}");

            return props;
        }

        public string GetDataType()
        {
            return mapping[Type].FullName;
        }

        public bool IsTypeMappingKnown => mapping.ContainsKey(Type);
    }
}
