

namespace GreatBook.RazorPage.Models.Products;

public class ProductDto : BaseDto
{
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public ProductCategoryDto Category { get; set; }
        public ProductCategoryDto SubCategory { get; set; }
        public ProductCategoryDto? SecondSubCategory { get; set; }
        public string Slug { get; set; }
        public SeoData SeoData { get; set; }
        public List<ProductImageDto> Images { get; set; }
        public List<ProductSpecificationDto> Specifications { get; set; }
}
