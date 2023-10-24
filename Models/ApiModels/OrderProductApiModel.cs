namespace ProvidersDomain.Models.ApiModels
{
    public class OrderProductApiModel
    {
        public long? DisanId { get; set; }
        public long? StockId { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
