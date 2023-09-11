using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Account
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан Email или ИНН")]
        public string EmailOrINN { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
