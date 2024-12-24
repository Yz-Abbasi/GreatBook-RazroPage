using GreatBook.RazorPage.Models;

namespace Shop.Query.Users.DTOs;

public class UserFilterData : BaseDto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string? Email { get; set; }
    public Gender Gender { get; set; }
    public string AvatarName { get; set; }
}