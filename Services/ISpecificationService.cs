using ProvidersDomain.Models;
using ProvidersDomain.Models.ApiModels;
using ProvidersDomain.ViewModels.Specification;

namespace ProvidersDomain.Services
{
    public interface ISpecificationService
    {
        Task<Specification> AddOrUpdateSpecification(User user, SpecificationModel specification, SpecificationSaveMode mode);        
        Task<SpecificationModel> GetSpecificationModel(User user, long id);
        Task<bool> DeleteSpecifications(User user, IEnumerable<long> idArray);
    }
}
