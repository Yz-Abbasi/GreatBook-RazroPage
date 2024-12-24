

namespace GreatBook.RazorPage.Models.Products;

public class ProductCategoryDto // This is the category in the product and it doesn't have a child
{
    public long Id { get; set; }
    public long? ParentId { get;  set; }
    public string Title { get;  set; }
    public string Slug { get;  set; }
    public SeoData SeoData { get;  set; }

}