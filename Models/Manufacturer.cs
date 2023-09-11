using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class Manufacturer : ITimeStampedModel
    {
        [Key]
        [JsonProperty("number")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("create")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("modify")]
        public DateTime LastModified { get; set; }
    }
}
