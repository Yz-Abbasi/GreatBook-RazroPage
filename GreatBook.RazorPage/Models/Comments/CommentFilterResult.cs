

namespace GreatBook.RazorPage.Models.Comments;

public class CommentFilterResult : BaseFilter<CommentDto, CommentFilterParam>
{
    
}

public class CommentFilterParam : BaseFilterParam
{
    public int UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int CommentStatus { get; set; }
}