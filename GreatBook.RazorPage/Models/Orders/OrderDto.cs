

namespace GreatBook.RazorPage.Models.Orders;

public class OrderDto : BaseDto
{
    public long UserId { get; set; }
    public string UserFullName { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime LastUpdate { get; set; }
    public List<OrderItemDto> Items { get; set; }
    public ShippingMethod? ShippingMethod { get; set; }
    public OrderAddress? OrderAddress { get; set; }
    public OrderDiscount? Discount { get; set; }
    
}
