

namespace GreatBook.RazorPage.Models.Categories;

public class CategoryDto : BaseDto
{
        public string Title { get; set; }
        public string Slug { get; set; }
        public SeoData SeoData { get; set; }
        public List<ChildCategoryDto> Childs { get; set; } 
}

public class SeoData
{
    public string? MetaTitle { get; set; }
    public string? MetaDescription { get; set; }
    public string? MetaKeyWords { get; set; }
    public bool IndexPage { get; set; }
    public string? Canonical { get; set; }
    public string? Schema { get; set; }
}

public class ChildCategoryDto : BaseDto
{
    public string Title { get;  set; }
    public string Slug { get;  set; }
    public SeoData SeoData { get;  set; }
    public long ParentId { get;  set; }
    public List<SecondChildCategoryDto> Childs { get;  set; }
}

public class SecondChildCategoryDto : BaseDto
{
    public string Title { get;  set; }
    public string Slug { get;  set; }
    public SeoData SeoData { get;  set; }
    public long ParentId { get;  set; }
}