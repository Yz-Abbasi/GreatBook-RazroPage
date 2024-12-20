using System.Net;
using GreatBook.RazorPage.Models;

namespace GreatBook.RazorPage.Services.Auth;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly IHttpContextAccessor _accessor;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult<LoginResponse>?> Login(LoginCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("auth/Login", command);
        // if(result.StatusCode != HttpStatusCode.OK)
        //     return new ApiResult<LoginResponse>() {IsSuccessful = false};

        return await result.Content.ReadFromJsonAsync<ApiResult<LoginResponse>>();
    }

    public async Task<ApiResult?> Register(RegisterCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("auth/Register", command);
        // if(result.StatusCode != HttpStatusCode.OK)
        //     return new ApiResult<LoginResponse>() {IsSuccessful = false};

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult<LoginResponse>?> RefreshToken()
    {
        var refreshToken = _accessor.HttpContext.Request.Cookies["refreshToken"];
        var result = await _httpClient.PostAsync($"auth/RefreshToken?refreshToken={refreshToken}", null);

        return await result.Content.ReadFromJsonAsync<ApiResult<LoginResponse>>();
    }

    public async Task<ApiResult?> Logout()
    {
        var result = await _httpClient.DeleteAsync("auth/Login");

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }
}