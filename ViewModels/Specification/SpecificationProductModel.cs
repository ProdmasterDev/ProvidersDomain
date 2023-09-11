using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Specification
{
    public class SpecificationProductModel
    {
        [Required]
        public long Id { get; set; }
        [Required(ErrorMessage = "Не указана цена")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Неверное значение цены")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        [DisplayName("Цена")]
        public double? Price { get; set; }
        [DisplayName("Наименование")]
        public string? Name { get; set; }
    }
}
