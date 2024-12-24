namespace GreatBook.RazorPage.Models.Users.Commands;

public class EditUserCommand
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public IFormFile? Avatar { get; set; }
    public Gender Gender { get; set; }
}

public enum Gender
{
    None,
    Male,
    Female
}