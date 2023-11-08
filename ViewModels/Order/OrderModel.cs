using ProvidersDomain.Models;
using System.ComponentModel;

namespace ProvidersDomain.ViewModels.Order
{
    public class OrderModel
    {
        public long Id { get; set; }
        [DisplayName("Наименование поставщика")]
        public string UserName { get; set; }
        [DisplayName("Статус заказа")]
        public OrderState OrderState { get; set; }
        [DisplayName("Причина")]
        public string? DeclineNote { get; set; } = string.Empty;
        [DisplayName("Выберите действие")]
        public OrderState UserResponse { get; set; } = OrderState.New;
        [DisplayName("Дата поставки")]
        public DateTime Date { get; set; }
        [DisplayName("Дата создания заказа")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Дата посл. изм.")]
        public DateTime LastModified { get; set; }
        public List<OrderProductModel> Products { get; set; } = new();
        public string? Action { get; set; } = string.Empty;
    }
}
