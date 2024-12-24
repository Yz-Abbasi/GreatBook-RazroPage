using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.UserAddresses;
using GreatBook.RazorPage.Models.UserAddresses.Commands;

namespace GreatBook.RazorPage.Services.UserAddresses;

public interface IUserAddresseService
{
    Task<ApiResult> AddUserAddress(AddUserAddressCommand command);
    Task<ApiResult> EditUserAddress(EditUserAddressCommand command);
    Task<ApiResult> DeleteUserAddress(long addressId);

    Task<UserAddressDto?> GetUserAddressById(long userAddressId);
    Task<List<UserAddressDto>> GetUserAddresses();
}