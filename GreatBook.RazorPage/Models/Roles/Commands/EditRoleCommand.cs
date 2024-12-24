

namespace GreatBook.RazorPage.Models.Roles.Commands;

public class EditRoleCommand
{
    public long RoleId { get; set; }
    public string Title { get; set; }
    public List<Permission> Permissions { get; set; }
}