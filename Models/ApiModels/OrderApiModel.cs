using ProvidersDomain.Models.Base;

namespace ProvidersDomain.Models.ApiModels
{
    public class OrderApiModel : OrderBase
    {
        public List<OrderProductApiModel>? ProductPart { get; set; } = new List<OrderProductApiModel>();
    }
}
