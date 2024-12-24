namespace GreatBook.RazorPage.Models.Users.Commands;

public class CreateUserCommand
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; } 
}