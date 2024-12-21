

namespace GreatBook.RazorPage.Models.Comments;

public class CommentDto : BaseDto
{
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public string UserFullName { get; set; }
    public string ProductTitle { get; set; }
    public string Text { get; set; }
    public int Status { get; set; }
}

public enum CommentStatus
{
    Pending,
    Accepted,
    Rejected
}