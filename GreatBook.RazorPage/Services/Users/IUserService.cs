

using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Users.Commands;
using Shop.Query.Users.DTOs;

namespace GreatBook.RazorPage.Services.Users;

public interface IUserService
{
    Task<ApiResult> CreateUser(CreateUserCommand command);
    Task<ApiResult> EditUser(EditUserCommand command);

    Task<UserDto?> GetUserById(long userId);
    Task<UserDto?> GetCurrentUser();
    Task<UserFilterResult> GetUsers(UserFilterParams filterParams);
}