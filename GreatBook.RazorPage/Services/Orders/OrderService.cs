

using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Orders;
using GreatBook.RazorPage.Models.Orders.Commands;

namespace GreatBook.RazorPage.Services.Orders;

public class OrderService : IOrderService
{
    private readonly HttpClient _httpClient;

    public OrderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> AddOrderItem(AddOrderItemCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Order", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> CheckoutOrder(CheckOutOrderCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Order", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> IncreaseOrderItem(IncreaseOrderItemCountCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync("Order/orderItem/increaseCount", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> DecreaseOrderItem(DecreaseOrderItemCountCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync("Order/orderItem/decreaseCount", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> DeleteOrderItem(DeleteOrderItemCommand command)
    {
        var result = await _httpClient.DeleteAsync($"Order/orderItem/{command.OrderItemId}");

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<OrderDto?> GetCurrentOrder()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<OrderDto?>>("Order/Current");

        return result?.Data;
    }

    public async Task<OrderDto?> GetOrderById(long orderId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<OrderDto?>>($"Order/{orderId}");

        return result?.Data;
    }

    public async Task<OrderFilterResult> GetOrders(OrderFilterParams filterParams)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<OrderFilterResult>>("Order");

        return result?.Data;
    }
}