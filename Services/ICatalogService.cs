using ProvidersDomain.Models;
using ProvidersDomain.ViewModels.Catalog;

namespace ProvidersDomain.Services
{
    public interface ICatalogService
    {
        Task<IEnumerable<Standart>> GetStandarts();
        Task<IEnumerable<Country>> GetCountries();
        Task<IEnumerable<Manufacturer>> GetManufacturers();
        Task<Product> AddOrUpdateProduct(User user, ProductModel product);
        Task<ProductModel> GetProductModel(User user, long id);
        Task<bool> DeleteProducts(User user, IEnumerable<long> idArray);
    }
}
