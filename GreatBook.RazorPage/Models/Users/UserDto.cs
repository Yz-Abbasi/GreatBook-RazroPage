using GreatBook.RazorPage.Models;

namespace Shop.Query.Users.DTOs;

public class UserDto : BaseDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public bool IsActive { get; set; }
    public string AvatarName { get; set; }
    public List<UserRoleDto> Roles { get; set; }
}

public enum Gender
{
    None,
    Male,
    Female
}