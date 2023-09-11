using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models
{
    public class Standart : ITimeStampedModel
    {
        [Key]
        [JsonProperty("number")]
        public long Id { get; set; }        
        [JsonProperty("stock")]
        public long StockId { get; set; }
        [JsonProperty("nameprod")]
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [JsonProperty("categoryname")]
        [DisplayName("Категория")]
        public string? CategoryName { get; set; }
        [JsonProperty("unitId")]
        public long? UnitId { get; set; }
        public virtual Unit? Unit { get; set; }
        [JsonProperty("taste")]
        [DisplayName("Вкус")]
        public string? Taste { get; set; }
        [JsonProperty("smell")]
        [DisplayName("Запах")]
        public string? Smell { get; set; }
        [JsonProperty("color")]
        [DisplayName("Цвет")]
        public string? Color { get; set; }
        [JsonProperty("structure")]
        [DisplayName("Структура")]
        public string? Structure { get; set; }
        [JsonProperty("consistenc")]
        [DisplayName("Консистенция")]
        public string? Consistenc { get; set; }
        [JsonProperty("create")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("modify")]
        public DateTime LastModified { get; set; }

        public Standart(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
