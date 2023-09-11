using ProvidersDomain.Models;
using ProvidersDomain.ViewModels.Account;

namespace ProvidersDomain.Services
{
    public interface IUserService
    {
        Task<User> GetByEmail(string email);
        Task<User> GetByINN(string inn);
        Task<User> Get(string email, string password);
        Task<User> Add(string email, string password);
        Task<User> Add(RegisterModel model);
        Task<User> UpdateUser(User user);
        Task<UserModel> GetModelFromUser(User user);
        Task<bool> UserExists(RegisterModel model);
    }
}
