

namespace GreatBook.RazorPage.Models.Orders.Commands;

public class DeleteOrderItemCommand
{
    public long UserId { get; set; }
    public long OrderItemId { get; set; }
}