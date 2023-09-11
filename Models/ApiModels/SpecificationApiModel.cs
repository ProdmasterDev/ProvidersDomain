using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models.ApiModels
{
    public class SpecificationApiModel : ITimeStampedModel
    {
        public long Id { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public long UserId { get; set; }
        public string ProvidersName { get; set; }
        public string INN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual List<ProductApiModel> Products { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
    }
}
