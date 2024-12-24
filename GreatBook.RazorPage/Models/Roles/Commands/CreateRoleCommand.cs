

namespace GreatBook.RazorPage.Models.Roles.Commands;

public class CreateRoleCommand
{
    public string Title { get; set; }
    public List<Permission> Permissions { get; set; }
}
