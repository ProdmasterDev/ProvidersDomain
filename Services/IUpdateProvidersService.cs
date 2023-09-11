namespace ProvidersDomain.Services
{
    public interface IUpdateProvidersService
    {
        Task LoadProvider(long customId, string? password);
    }
}
