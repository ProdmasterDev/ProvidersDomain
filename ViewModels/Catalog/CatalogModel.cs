using ProvidersDomain.Models;
using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.ViewModels.Catalog
{
    public class CatalogModel
    {
        public List<Product> Products { get; set; }
    }
}
