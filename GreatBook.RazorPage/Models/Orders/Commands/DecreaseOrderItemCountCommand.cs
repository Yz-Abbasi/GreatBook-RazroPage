

namespace GreatBook.RazorPage.Models.Orders.Commands;

public class DecreaseOrderItemCountCommand
{
    public long UserId { get; set; }
    public long OrderItemId { get; set; }
    public int Count { get; set; }
}
