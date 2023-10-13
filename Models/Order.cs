using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [JsonProperty("date")]
        public long? Object { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified {  get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<Product> Products { get; set; } = new();
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual List<OrderProductPart> OrderProductPart { get; set; } = new();
    }
}
