using ProvidersDomain.Models;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Models.ApiModels
{
    public class ProductApiModel
    {        
        public long Id { get; set; }        
        public long? DisanId { get; set; }        
        public double Price { get; set; }        
        public double Quantity { get; set; }        
        public long? StandartId { get; set; }
        public long? ManufacturerId { get; set; }
        public string? ManufacturerName { get; set; }
        public string? VendorCode { get; set; }
        public string Name { get; set; }
        public long? CountryId { get; set; }
        public string? Brand { get; set; }
        public string? Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
    }
}
