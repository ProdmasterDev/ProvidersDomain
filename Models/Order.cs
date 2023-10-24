using Newtonsoft.Json;
using ProvidersDomain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Models
{
    public class Order : ITimeStampedModel
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("jridn")]
        public long JrId { get; set; }
        [JsonProperty("journalidn")]
        public long? JournalId { get; set; }
        [JsonProperty("object")]
        [ForeignKey("object")]
        public long Object { get; set; }
        [JsonProperty("token")]
        public string? Token { get; set; } = string.Empty;
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        public OrderState OrderState { get; set; } = OrderState.New;
        public string? DeclineNote { get; set; } = string.Empty;
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
