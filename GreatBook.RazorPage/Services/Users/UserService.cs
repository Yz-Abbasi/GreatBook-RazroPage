using GreatBook.RazorPage.Infrastructure;
using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Users.Commands;
using Shop.Query.Users.DTOs;

namespace GreatBook.RazorPage.Services.Users;

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;
    private const string ModuleName = "User";

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> CreateUser(CreateUserCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditUser(EditUserCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync($"{ModuleName}", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<UserDto?> GetCurrentUser()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<UserDto?>>($"{ModuleName}/Current");

        return result?.Data;
    }

    public async Task<UserDto?> GetUserById(long userId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<UserDto?>>($"{ModuleName}/{userId}");

        return result?.Data;
    }

    public async Task<UserFilterResult> GetUsers(UserFilterParams filterParams)
    {
        var url = filterParams.GeneratebaseFilterUrl(ModuleName) +
                $"&email={filterParams.Email}&phoneNumber={filterParams.PhoneNumber}&id={filterParams.Id}";
        var result = await _httpClient.GetFromJsonAsync<ApiResult<UserFilterResult>>(url);

        return result?.Data;
    }
}