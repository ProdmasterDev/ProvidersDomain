using ProvidersDomain.Models;

namespace ProvidersDomain.Services
{
    public interface IUpdateProvidersService
    {
        Task LoadProvider(long customId, string? password);
        Task<User> LoadProvider(User user);

        Task LoadProviders();
    }
}
