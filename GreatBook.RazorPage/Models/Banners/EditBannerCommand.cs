
namespace GreatBook.RazorPage.Models.Banners;

public class EditBannerCommand : BaseDto
{
    public string Link { get; set; }
    public BannerPosition BannerPosition { get; set; }
    public IFormFile ImageFile { get; set; }
}