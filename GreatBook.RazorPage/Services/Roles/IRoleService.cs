using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Roles;
using GreatBook.RazorPage.Models.Roles.Commands;

namespace GreatBook.RazorPage.Services.Roles;

public interface IRoleService
{
    Task<ApiResult> CreateRole(CreateRoleCommand command);
    Task<ApiResult> EditRole(EditRoleCommand command);

    Task<RoleDto?> GetRoleById(long roleId);
    Task<List<RoleDto>> GetRoles();
}