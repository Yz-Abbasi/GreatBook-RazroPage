using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Sliders;
using GreatBook.RazorPage.Models.Sliders.Commands;

namespace GreatBook.RazorPage.Services.Sliders;

public interface ISliderService
{
    Task<ApiResult> CreateSlider(CreateSliderCommand command);
    Task<ApiResult> EditSlider(EditSliderCommand command);
    Task<ApiResult> DeleteSlider(long sliderId);

    Task<SliderDto?> GetSliderById(long sliderId);
    Task<List<SliderDto>> GetSliders();
}