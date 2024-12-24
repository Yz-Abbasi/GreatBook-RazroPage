

namespace GreatBook.RazorPage.Models.Sellers.Commands;

public class EditSellerCommand
{
    public long Sellerid { get; set; }
    public string ShopName { get; set; }
    public string NationalCode { get; set; }
}