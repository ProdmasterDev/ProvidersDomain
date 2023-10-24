using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Order
{
    public class OrderProductModel
    {
        public long Id { get; set; }
        [DisplayName("Наименование")]
        public string? Name { get; set; } = string.Empty;
        [DisplayName("Количество")]
        public double? Quantity { get; set; } = 0;
        [DisplayName("Ед.изм.")]
        public string? UnitName { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [DisplayName("Цена")]
        public double? Price { get; set; } = 0;
    }
}