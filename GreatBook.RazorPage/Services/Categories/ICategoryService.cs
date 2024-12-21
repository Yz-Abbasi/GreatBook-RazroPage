

using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Categories;

namespace GreatBook.RazorPage.Services.Categories;

public interface ICategoryService
{
    Task<ApiResult> CreateCategory(CreateCategoryCommand command);
    Task<ApiResult> EditCategory(EditCategoryCommand command);
    Task<ApiResult> DeleteCategory(long categoryId);
    Task<ApiResult> AddChildCategory(AddChildCategoryCommand command);

    Task<CategoryDto?> GetCatgoryById(long categoryId);
    Task<List<CategoryDto>> GetCategories();
    Task<List<ChildCategoryDto>> GetChildren(long parentCategoryId);
}