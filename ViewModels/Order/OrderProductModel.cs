using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Order
{
    public class OrderProductModel
    {
        public long Id { get; set; }
        [DisplayName("Наименование")]
        public string? Name { get; set; } = string.Empty;
        [Range(0, double.MaxValue,ErrorMessage ="Значение количества должно быть не меньше 0!")]
        [DisplayName("Изначальное количество")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public double? OriginalQuantity { get; set; } = 0;
        [DisplayName("Количество")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public double? Quantity { get; set; } = 0;
        [DisplayName("Ед.изм.")]
        public string? UnitName { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [DisplayName("Цена")]
        public double? Price { get; set; } = 0;
    }
}