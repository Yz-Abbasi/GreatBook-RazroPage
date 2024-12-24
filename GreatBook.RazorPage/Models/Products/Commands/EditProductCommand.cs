

namespace GreatBook.RazorPage.Models.Products.Commands;

public class EditProductCommand
{
    public long ProductId { get; set; }
    public string Title { get; set; }
    public IFormFile? ImageFile { get; set; }
    public string Description { get; set; }
    public long Categoryid { get; set; }
    public long SubCategoryid { get; set; }
    public long SecondarySubCategoryid { get; set; }
    public string Slug { get; set; }
    public SeoData SeoData { get; set; }
    public Dictionary<string, string> Specifications { get; set; }
    
}
