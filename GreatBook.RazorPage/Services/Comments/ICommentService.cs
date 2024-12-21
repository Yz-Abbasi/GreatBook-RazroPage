using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Comments;

namespace GreatBook.RazorPage.Services.Comments;

public interface ICommentService
{
    Task<ApiResult> AddComment(AddCommentCommand command);
    Task<ApiResult> EditComment(EditCommentCommand command);
    Task<ApiResult> ChangeCommentStatus(long commentId, CommentStatus commentStatus);

    Task<CommentFilterResult> GetCommentByFilter(CommentFilterParam filterParam);
    Task<CommentDto?> GetCommentById(long commentId);
}