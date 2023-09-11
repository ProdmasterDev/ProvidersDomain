using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    /// <summary>
    /// Specification
    /// </summary>
    public class Specification : ITimeStampedModel
    {
        [Key]
        public long Id { get; set; }
        [Newtonsoft.Json.JsonProperty("disanId")]
        public long? DisanId { get; set; }
        [Newtonsoft.Json.JsonProperty("startsAt")]
        public DateTime StartsAt { get; set; }
        [Newtonsoft.Json.JsonProperty("expiresAt")]
        public DateTime ExpiresAt { get; set; }
        public long UserId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual User User { get; set; }
        public virtual List<Product> Products { get; set; } = new();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<ProductSpecification> ProductSpecifications { get; set; } = new();
        /// <summary>
        /// Verify state
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]        
        public VerifyState VerifyState { get; set; } = VerifyState.NotSended;
        [Newtonsoft.Json.JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Newtonsoft.Json.JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }
        public string? VerifyNote { get; set; }
    }
}
