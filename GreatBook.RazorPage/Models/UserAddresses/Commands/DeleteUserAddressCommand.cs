

namespace GreatBook.RazorPage.Models.UserAddresses.Commands;

public class DeleteUserAddressCommand
{
    public long UserId { get; set; }
    public long AddressId { get; set; }
}