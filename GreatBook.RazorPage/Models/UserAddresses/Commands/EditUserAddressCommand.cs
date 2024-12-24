

namespace GreatBook.RazorPage.Models.UserAddresses.Commands;

public class EditUserAddressCommand
{
    public long UserId { get; set; }
    public long Id { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string PostalAddress { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
    public string NationalCode { get; set; }
}