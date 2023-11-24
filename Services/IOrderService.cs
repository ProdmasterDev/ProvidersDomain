using ProvidersDomain.Models;
using ProvidersDomain.Models.ApiModels;
using ProvidersDomain.ViewModels.Order;

namespace ProvidersDomain.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrder(OrderApiModel order);
        Task<Order> CreateOrRecreateOrder(OrderApiModel orderModel);
        Task ConfirmConfirmedOrDeclinedOrders(List<OrderApiModel> orders);
        Task DeclineOrderByRecipient(OrderApiModel orderModel);
        Task<List<Order>> GetOrdersForUser(long userId);
        Task<OrderModel?> GetOrderModelByToken(string token);
        Task<OrderModel?> GetOrderModel(User user, long id);
        Task ConfirmOrder(OrderModel orderModel);
        Task DeclineOrder(OrderModel orderModel);
        Task EditOrder(OrderModel orderModel);
        Task<OrderProductModel?> GetOriginalProductInOrder(OrderProductModel model, OrderModel order);
        Task<Order?> GetOrderByOrderModel(OrderModel model);
        Task<List<OrderApiModel>> GetConfirmedOrDeclinedOrders();
        Task<Order> GetOrderById(long id);
    }
}
