

namespace GreatBook.RazorPage.Models.Orders;

public class OrderItemDto : BaseDto
{
    public string ProductTtle { get; set; }
    public string ProductSlug { get; set; }
    public string ProductImageName { get; set; }
    public string ShopName { get; set; }
    public long OrderId { get; internal set; }
    public long InventoryId { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
    public int TotalPrice => Price * Count;
}
