using Newtonsoft.Json;

namespace ProvidersDomain.Models.ApiModels
{
    public class OrderApiResponseModel
    {
        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;
        [JsonProperty("personalTempLink")]
        public string PersonalTempLink { get; set; } = string.Empty;
        [JsonProperty("linkExpirationTime")]
        public DateTime LinkExpirationTime { get; set; } = DateTime.Now;


        public OrderApiResponseModel() { }
        public OrderApiResponseModel(Order order)
        {
            if(order.Token != null)
            {
                Token = order.Token;
                PersonalTempLink = $"https://partner.prodmasterpro.ru/order/vieworderanonymous?token={order.Token}";
            }
            LinkExpirationTime = order.CreatedAt + TimeSpan.FromDays(1);
        }
    }
}