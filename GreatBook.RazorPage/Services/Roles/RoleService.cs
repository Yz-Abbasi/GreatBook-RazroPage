using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Roles;
using GreatBook.RazorPage.Models.Roles.Commands;

namespace GreatBook.RazorPage.Services.Roles;

public class RoleService : IRoleService
{
    private readonly HttpClient _httpClient;

    public RoleService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> CreateRole(CreateRoleCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Role", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditRole(EditRoleCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync("Role", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<RoleDto?> GetRoleById(long roleId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<RoleDto>>($"Role/{roleId}");

        return result?.Data;
    }

    public async Task<List<RoleDto>> GetRoles()
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<List<RoleDto>>>($"Role");

        return result?.Data;
    }
}