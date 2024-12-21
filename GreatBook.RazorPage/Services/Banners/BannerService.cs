using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Banners;

namespace GreatBook.RazorPage.Services.Banners;

public class BannerService : IBannerService
{
    private readonly HttpClient _httpClient;

    public BannerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> CreateBanner(CreateBannerCommand command)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(command.Link), "Link");
        formData.Add(new StreamContent(command.ImageFile.OpenReadStream()), "ImageFile");
        formData.Add(new StringContent(command.BannerPosition.ToString()), "BannerPosition");

        var result = await _httpClient.PostAsync("Banner", formData);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditBanner(EditBannerCommand command)
    {
        var formData = new MultipartFormDataContent();
        formData.Add(new StringContent(command.Id.ToString()), "Id");
        formData.Add(new StringContent(command.Link), "Link");
        formData.Add(new StreamContent(command.ImageFile.OpenReadStream()), "ImageFile");
        formData.Add(new StringContent(command.BannerPosition.ToString()), "BannerPosition");

        var result = await _httpClient.PutAsync("Banner", formData);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> DeleteBanner(long bannerId)
    {
        var result = await _httpClient.DeleteAsync($"Banner/{bannerId}");

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<BannerDto?> GetBannerById(long bannerId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<BannerDto>>($"Banner/{bannerId}");

        return result?.Data;
    }

    public async Task<List<BannerDto>> GetBannersList()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<BannerDto>>>($"Banner");
        if(result?.Data == null)
            return new List<BannerDto>();

        return result?.Data;
    }
}