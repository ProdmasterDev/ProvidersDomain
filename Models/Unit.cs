using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class Unit
    {
        [Key]
        [JsonProperty("unitId")]
        public long Id { get; set; }
        [JsonProperty("unitName")]
        public string Name { get; set; }
        [JsonProperty("unitShort")]
        public string Short { get; set; }
    }
}
