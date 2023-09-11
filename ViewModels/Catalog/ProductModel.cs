using ProvidersDomain.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Catalog
{
    public class ProductModel
    {
        [Required]
        public long Id { get; set; }
        [Required(ErrorMessage = "Не указан артикул")]        
        [DisplayName("Артикул")]
        public string? VendorCode { get; set; }
        [Required(ErrorMessage = "Не выбрана номенклатура")]
        [DisplayName("Номенклатура")]
        public long? StandartId { get; set; }
        public Standart? Standart { get; set; }
        [Required(ErrorMessage = "Не указано наименование сырья")]
        [DisplayName("Наименование сырья")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Не указан квант")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Неверное значение кванта")]
        [DisplayName("Квант")]
        public double? Quantity { get; set; }        
        [DisplayName("Производитель")]
        public long? ManufacturerId { get; set; }
        public long? SpecificationId { get; set; }
        [DisplayName("Производитель")]
        public Manufacturer? Manufacturer { get; set; }
        public string? ManufacturerName { get; set; }
        [DisplayName("Бренд")]
        public string? Brand { get; set; }
        [Required(ErrorMessage = "Не указана страна производства")]
        [DisplayName("Страна производства")]
        public long? CountryId { get; set; }
        public Country? Country { get; set; }
        [DisplayName("Примечание")]
        public string? Note { get; set; }
        [DisplayName("Последняя цена")]
        public string? LastPrice { get; set; }
        public VerifyState? VerifyState { get; set; }
        public string? VerifyNote { get; set; }
    }
}
