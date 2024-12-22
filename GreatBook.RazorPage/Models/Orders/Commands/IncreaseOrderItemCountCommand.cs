

namespace GreatBook.RazorPage.Models.Orders.Commands;

public class IncreaseOrderItemCountCommand
{
    public long UserId { get; set; }
    public long OrderItemId { get; set; }
    public int Count { get; set; }
}
