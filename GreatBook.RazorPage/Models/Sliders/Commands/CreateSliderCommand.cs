

namespace GreatBook.RazorPage.Models.Sliders.Commands;

public class CreateSliderCommand
{
    public string Title { get; set; }
    public string Link { get; set; }
    public IFormFile ImageFile { get; set; }
}