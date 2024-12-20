

using GreatBook.RazorPage.Models;

namespace GreatBook.RazorPage.Services.Auth;

public interface IAuthService
{
    Task<ApiResult<LoginResponse>?> Login(LoginCommand command);
    Task<ApiResult?> Register(RegisterCommand command);
    Task<ApiResult<LoginResponse>?> RefreshToken();
    Task<ApiResult?> Logout();
}