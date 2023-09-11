using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class Country
    {
        [Key]
        [JsonProperty("number")]
        public long Id { get; set; }        
        [JsonProperty("name")]
        public string? Name { get; set; }                
        [JsonProperty("fullname")]
        public string? FullName { get; set; }                
        [JsonProperty("engname")]
        public string? EngName { get; set; }
        [JsonProperty("code")]
        public string? Code { get; set; }
        [JsonProperty("code3")]
        public string? Code3 { get; set; }                
    }
}
