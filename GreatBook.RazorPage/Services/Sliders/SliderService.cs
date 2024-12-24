using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Sliders;
using GreatBook.RazorPage.Models.Sliders.Commands;

namespace GreatBook.RazorPage.Services.Sliders;

public class SliderService : ISliderService
{
    private readonly HttpClient _httpClient;
    private const string ModuleName = "Slider";

    public SliderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> CreateSlider(CreateSliderCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditSlider(EditSliderCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> DeleteSlider(long sliderId)
    {
        var result = await _httpClient.DeleteAsync($"{ModuleName}/{sliderId}");

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<SliderDto?> GetSliderById(long sliderId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<SliderDto>>($"{ModuleName}/{sliderId}");

        return result?.Data;
    }

    public async Task<List<SliderDto>> GetSliders()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<SliderDto>>>($"{ModuleName}");

        return result?.Data;
    }
}