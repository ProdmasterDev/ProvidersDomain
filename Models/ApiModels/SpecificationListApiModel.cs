using ProvidersDomain.Models;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models.ApiModels
{
    public class SpecificationListApiModel
    {
        [Required]
        public List<Specification> Specifications { get; set; }
    }
}
