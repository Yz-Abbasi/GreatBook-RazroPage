
namespace GreatBook.RazorPage.Models.Banners;

public class BannerDto
{
        public string Link { get; set; }
        public string ImageName { get; set; }
        public BannerPosition Position { get; set; }
}

public enum BannerPosition
{
    under_slider,
    left_of_slider,
    right_of_slider,
    above_slider
}