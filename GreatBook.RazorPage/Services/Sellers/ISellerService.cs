using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Sellers;
using GreatBook.RazorPage.Models.Sellers.Commands;

namespace GreatBook.RazorPage.Services.Sellers;

public interface ISellerService
{
    Task<ApiResult> CreateSeller(CreateSellerCommand command);
    Task<ApiResult> EditSeller(EditSellerCommand command);
    Task<ApiResult> AddSellerInventory(AddSellerInventoryCommand command);
    Task<ApiResult> EditSellerInventory(EditSellerInventoryCommand command);

    Task<SellerDto?> GetSellerById(long sellerId);
    Task<SellerDto?> GetCurrentSeller();
    Task<SellerFilterResult> GetSellersByFilter(SellerFilterParams filterParams);
    
    Task<InventoryDto?> GetSellerInventoryById(long inventoryId);
    Task<List<InventoryDto>> GetSellerInventories();
}