using System.Text;
using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Products;
using GreatBook.RazorPage.Models.Products.Commands;
using Newtonsoft.Json;

namespace GreatBook.RazorPage.Services.Products;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> CreateProduct(CreateProductCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Product", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> AddProductImage(AddProductImageCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Product/images", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }


    public async Task<ApiResult> DeleteProductImage(DeleteProductImageCommand command)
    {
        var json = JsonConvert.SerializeObject(command);
        var message = new HttpRequestMessage(HttpMethod.Delete, "Product/images")
        {
            Content = new StringContent(json, Encoding.UTF8, "applicationj/json")
        };
        var result = await _httpClient.SendAsync(message);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditProduct(EditProductCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync("Product/images", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ProductDto?> GetProductById(long productId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<ProductDto?>>($"Product/{productId}");

        return result?.Data;
    }

    public async Task<ProductDto?> GetProductBySlug(string slug)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<ProductDto?>>($"Product/BySlug/{slug}");

        return result?.Data;
    }

    public async Task<ProductFilterResult> GetProducts(ProductFilterParam filterParam)
    {
        var url = $"Product?pageId={filterParam.PageId}&take={filterParam.Take}" +
            $"&slug={filterParam.Slug}&title={filterParam.Title}";
        if (filterParam.Id != null)
            url += $"&Id={filterParam.Id}";
        var result = await _httpClient.GetFromJsonAsync<ApiResult<ProductFilterResult>>(url);

        return result?.Data;
    }

    public async Task<ProductShopResult> GetProductsForShop(ProductShopFilterparam filterParam)
    {
        var url = $"Product?pageId={filterParam.PageId}&take={filterParam.Take}" +
            $"&categorySlug={filterParam.CategorySlug}&onlyAvailableProducts={filterParam.OnlyAvailableProducts}" +
            $"&search={filterParam.Search}&productSearchOrderBy={filterParam.ProductSearchOrderBy}&onlyDiscountedProducts={filterParam.OnlyDiscountedProducts}";

        var result = await _httpClient.GetFromJsonAsync<ApiResult<ProductShopResult>>(url);

        return result?.Data;
    }
}