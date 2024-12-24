

namespace GreatBook.RazorPage.Models.Products;

public class ProductFilterParam : BaseFilterParam
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
}
