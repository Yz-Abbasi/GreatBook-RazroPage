using System.Reflection;
using GreatBook.RazorPage.Infrastructure;
using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Sellers;
using GreatBook.RazorPage.Models.Sellers.Commands;
using GreatBook.RazorPage.Services.Roles;

namespace GreatBook.RazorPage.Services.Sellers;

public class SellerService : ISellerService
{
    private readonly HttpClient _httpClient;
    private const string ModuleName = "Seller";

    public SellerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> AddSellerInventory(AddSellerInventoryCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync($"{ModuleName}/Inventory", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> CreateSeller(CreateSellerCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditSeller(EditSellerCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditSellerInventory(EditSellerInventoryCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync($"{ModuleName}/Inventory", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<SellerDto?> GetCurrentSeller()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<SellerDto?>>($"{ModuleName}/current");

        return result?.Data;
    }

    public async Task<SellerDto?> GetSellerById(long sellerId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<SellerDto?>>($"{ModuleName}/{sellerId}");

        return result?.Data;
    }

    public async Task<SellerFilterResult> GetSellersByFilter(SellerFilterParams filterParams)
    {
        var url = filterParams.GeneratebaseFilterUrl(ModuleName) +
                $"&shopName={filterParams.ShopName}&nationalCode={filterParams.NationalCode}";

        var result = await _httpClient.GetFromJsonAsync<ApiResult<SellerFilterResult>>(url);

        return result.Data;
    }

    public async Task<InventoryDto?> GetSellerInventoryById(long inventoryId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<InventoryDto?>>($"{ModuleName}/Inventories/{inventoryId}");

        return result.Data;
    }

    public async Task<List<InventoryDto>> GetSellerInventories()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<InventoryDto>>>($"{ModuleName}/Inventories");

        return result.Data;
    }

}