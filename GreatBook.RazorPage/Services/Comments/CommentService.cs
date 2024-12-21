using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Comments;

namespace GreatBook.RazorPage.Services.Comments;

public class CommentService : ICommentService
{
    private readonly HttpClient _httpClient;

    public CommentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult> AddComment(AddCommentCommand command)
    {
        var result = await _httpClient.PostAsJsonAsync("Comment", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> ChangeCommentStatus(long commentId, CommentStatus commentStatus)
    {
        var result = await _httpClient.PutAsJsonAsync("CommentChangeStatus", new {id = commentId, commentStatus});

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<ApiResult> EditComment(EditCommentCommand command)
    {
        var result = await _httpClient.PutAsJsonAsync("Comment", command);

        return await result.Content.ReadFromJsonAsync<ApiResult>();
    }

    public async Task<CommentFilterResult> GetCommentByFilter(CommentFilterParam filterParam)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<CommentFilterResult>>("Comment");

        return result?.Data;
    }

    public async Task<CommentDto?> GetCommentById(long commentId)
    {
        var result = await _httpClient.GetFromJsonAsync<ApiResult<CommentDto>>($"Comment/{commentId}");

        return result?.Data;
    }
}