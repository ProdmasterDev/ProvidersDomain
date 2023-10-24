using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class User : ITimeStampedModel
    {
        [Key]
        public long Id { get; set; }
        [Newtonsoft.Json.JsonProperty("number")]
        public long DisanId { get; set; }
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Newtonsoft.Json.JsonProperty("inn")]
        public string INN { get; set; }
        [Newtonsoft.Json.JsonProperty("phone")]
        public string Phone { get; set; }
        public virtual List<Product>? Products { get; set; }
        public virtual List<Specification>? Specifications { get; set; }
        public virtual List<Order> Orders { get; set; } = new List<Order>();
        [Newtonsoft.Json.JsonProperty("create")]
        public DateTime CreatedAt { get; set; }
        [Newtonsoft.Json.JsonProperty("modify")]
        public DateTime LastModified { get; set; }
    }
}
