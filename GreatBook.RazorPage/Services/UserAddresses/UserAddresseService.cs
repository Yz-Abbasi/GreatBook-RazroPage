using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.UserAddresses;
using GreatBook.RazorPage.Models.UserAddresses.Commands;

namespace GreatBook.RazorPage.Services.UserAddresses;

public class UserAddresseService : IUserAddresseService
{
    private readonly HttpClient _httpClient;
    private const string ModuleName = "UserAddress";

    public UserAddresseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> AddUserAddress(AddUserAddressCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> DeleteUserAddress(long addressId)
    {
        var result = await _httpClient.DeleteAsync($"{ModuleName}/{addressId}");

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditUserAddress(EditUserAddressCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<UserAddressDto?> GetUserAddressById(long userAddressId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<UserAddressDto>>($"{ModuleName}/{userAddressId}");

        return result?.Data;
    }

    public async Task<List<UserAddressDto>> GetUserAddresses()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<UserAddressDto>>>($"{ModuleName}");

        return result?.Data;
    }
}