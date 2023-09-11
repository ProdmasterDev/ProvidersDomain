using ProvidersDomain.Models;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models.ApiModels
{
    public class UpdateProductApiModel
    {        
        public long Id { get; set; }        
        public long? DisanId { get; set; }        
        public double Price { get; set; }        
        public long? StandartId { get; set; }
        public long? ManufacturerId { get; set; }
        public bool Verified { get; set; }
        public string? VerifyNote { get; set; }
    }
}
