using Newtonsoft.Json;
using ProvidersDomain.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class Order : OrderBase, ITimeStampedModel
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("token")]
        public string? Token { get; set; } = string.Empty;
        [JsonProperty("date")]
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified {  get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Product> Products { get; set; } = new();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<OrderProductPart> OrderProductPart { get; set; } = new();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual User? User { get; set; }
    }
}
