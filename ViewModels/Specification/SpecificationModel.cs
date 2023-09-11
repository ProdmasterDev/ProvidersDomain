using ProvidersDomain.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Specification
{
    public class SpecificationModel
    {
        public long Id { get; set; }
        [DisplayName("Дата начала действия")]
        [Required(ErrorMessage = "Не указана дата начала")]
        public DateTime? StartsAt { get; set; }
        [DisplayName("Дата окончания действия")]
        [Required(ErrorMessage = "Не указана дата окончания")]
        public DateTime? ExpiresAt { get; set; }
        [DisplayName("Товары")]
        [Required, MinLength(1, ErrorMessage = "В спецификации должен быть хотя бы один товар")]
        public List<SpecificationProductModel> Products { get; set; } = new();
        [DisplayName("Создан")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Посл. изм.")]
        public DateTime LastModified { get; set; }
        [DisplayName("Статус")]
        public VerifyState? VerifyState { get; set; }
        public string? VerifyNote { get; set; }
    }
}
