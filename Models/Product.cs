using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class Product : ITimeStampedModel
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("number")]
        public long? DisanId { get; set; }
        [JsonProperty("article")]
        public string? VendorCode { get; set; }
        [JsonProperty("nameprod")]
        public string Name { get; set; }
        [JsonProperty("minkvant")]
        public double Quantity { get; set; }
        public string? ManufacturerName { get; set; }
        [JsonProperty("brand")]
        public string? Brand { get; set; }
        [JsonProperty("country")]
        public long? CountryId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Country? Country { get; set; }
        [JsonProperty("rem")]
        public string? Note { get; set; }
        public VerifyState VerifyState { get; set; } = VerifyState.NotSended;
        public string? VerifyNote { get; set; }
        [JsonProperty("parent")]
        public long StandartId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Standart Standart { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [JsonProperty("manufact")]
        public long? ManufacturerId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Manufacturer? Manufacturer { get; set; }
        [JsonProperty("custom")]
        public long UserId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual User User { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Specification> Specifications { get; set; } = new();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<ProductSpecification> ProductSpecifications { get; set; } = new ();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Order> Orders { get; set; } = new();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<OrderProductPart> OrderProductPart { get; set; } = new();
        [JsonProperty("create")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("modify")]
        public DateTime LastModified { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Product product) return Id == product.Id;
            return false;
        }
        public override int GetHashCode() => Id.GetHashCode();
    }
}
