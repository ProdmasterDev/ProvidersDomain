using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models.ApiModels
{
    public class UpdateSpecificationApiModel
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long? DisanId { get; set; }
        public bool Verified { get; set; }
        public string? VerifyNote { get; set; }
        public virtual List<UpdateProductApiModel> Products { get; set; } = new();
    }
}