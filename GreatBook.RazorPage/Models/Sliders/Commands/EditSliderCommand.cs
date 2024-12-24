

namespace GreatBook.RazorPage.Models.Sliders.Commands;

public class EditSliderCommand
{
    public long SliderId { get; set; }
    public string Title { get; set; }
    public string Link { get; set; }
    public IFormFile? ImageFile { get; set; }
}