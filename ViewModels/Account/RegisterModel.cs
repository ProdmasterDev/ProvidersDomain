using ProvidersDomain.Extensions.ValidationAttributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Account
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указано наименование поставщика")]
        [DisplayName("Наименование поставщика")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Не указан Email")]
        [EmailAddress(ErrorMessage = "Некорректный электронный адрес")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не заполнен ИНН")]
        [INN(ErrorMessage = "Некорректный ИНН")]
        [DisplayName("ИНН")]
        public string INN { get; set; }

        [Required(ErrorMessage = "Не заполнен номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        [DisplayName("Номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [DisplayName("Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Введите пароль повторно")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DisplayName("Повторите пароль")]
        public string ConfirmPassword { get; set; }
    }
}
