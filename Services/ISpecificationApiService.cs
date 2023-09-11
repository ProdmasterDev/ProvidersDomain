using ProvidersDomain.Models;
using ProvidersDomain.Models.ApiModels;
using ProvidersDomain.ViewModels.Specification;

namespace ProvidersDomain.Services
{
    public interface ISpecificationApiService
    {
        Task AddOrUpdateSpecifications(IEnumerable<UpdateSpecificationApiModel> specifications);
        Task<bool> SuccessSendingSpecifications(IEnumerable<long> specificationIds);
        Task<IEnumerable<SpecificationApiModel>> GetNewSpecifications();
    }
}
