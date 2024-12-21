using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Banners;

namespace GreatBook.RazorPage.Services.Banners;

public interface IBannerService
{
    Task<ApiResult> CreateBanner(CreateBannerCommand command);
    Task<ApiResult> EditBanner(EditBannerCommand command);
    Task<ApiResult> DeleteBanner(long bannerId);

    Task<BannerDto?> GetBannerById(long bannerId);
    Task<List<BannerDto>> GetBannersList();
}