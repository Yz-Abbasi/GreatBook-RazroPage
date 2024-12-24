

namespace GreatBook.RazorPage.Models.Products.Commands;

public class DeleteProductImageCommand
{
    public long ProductId { get; set; }
    public long ImageId { get; set; }
}
