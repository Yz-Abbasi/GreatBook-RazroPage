

namespace GreatBook.RazorPage.Models.Products;

public class ProductFilterData : BaseDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
}