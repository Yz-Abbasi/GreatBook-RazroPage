

using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Orders;
using GreatBook.RazorPage.Models.Orders.Commands;

namespace GreatBook.RazorPage.Services.Orders;

public interface IOrderService
{
    Task<ApiResult> AddOrderItem(AddOrderItemCommand command);
    Task<ApiResult> CheckoutOrder(CheckOutOrderCommand command);
    Task<ApiResult> IncreaseOrderItem(IncreaseOrderItemCountCommand command);
    Task<ApiResult> DecreaseOrderItem(DecreaseOrderItemCountCommand command);
    Task<ApiResult> DeleteOrderItem(DeleteOrderItemCommand command);

    Task<OrderDto?> GetOrderById(long orderId);
    Task<OrderDto?> GetCurrentOrder();
    Task<OrderFilterResult> GetOrders(OrderFilterParams filterParams);
}