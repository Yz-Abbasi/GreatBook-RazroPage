

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
    public string? MetaTitle { get; private set; }
    public string? MetaDescription { get; private set; }
    public string? MetaKeyWords { get; private set; }
    public bool IndexPage { get; private set; }
    public string? Canonical { get; private set; }
    public string? Schema { get; private set; }
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