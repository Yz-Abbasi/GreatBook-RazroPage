

namespace GreatBook.RazorPage.Models.Orders;

public class OrderFilterData : BaseDto
{
    public long UserId { get; set; }
    public string UserFullName { get; set; }
    public OrderStatus Status { get; set; }
    public string? ShippimngType { get; set; }
    public string? Province { get; set; }
    public string? City { get; set; }
    public int TotalPrice { get; set; }
    public int TotalItemCount { get; set; }
}
