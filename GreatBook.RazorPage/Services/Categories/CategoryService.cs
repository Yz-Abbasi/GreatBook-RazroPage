using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Categories;

namespace GreatBook.RazorPage.Services.Categories;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;

    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> CreateCategory(CreateCategoryCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Category", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> AddChildCategory(AddChildCategoryCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Category/AddChild", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }


    public async Task<ApiResult> DeleteCategory(long categoryId)
    {
        var result = await _httpClient.DeleteAsync($"Category/{categoryId}");

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditCategory(EditCategoryCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync("Category", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<List<CategoryDto>> GetCategories()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<CategoryDto>>>("Category");

        return result?.Data;
    }

    public async Task<CategoryDto?> GetCatgoryById(long categoryId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<CategoryDto>>($"Category/{categoryId}");

        return result?.Data;
    }

    public async Task<List<ChildCategoryDto>> GetChildren(long parentCategoryId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<ChildCategoryDto>>>($"Category/getChilds/{parentCategoryId}");// Typo in the API URL

        return result?.Data;
    }
}