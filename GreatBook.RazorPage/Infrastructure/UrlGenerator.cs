

using GreatBook.RazorPage.Models;

namespace GreatBook.RazorPage.Infrastructure;

public static class UrlGenerator
{
    public static string GeneratebaseFilterUrl(this BaseFilterParam filterParam,string moduleName)
    {
        return $"{moduleName}?pageid={filterParam.PageId}&take={filterParam.Take}";
    }
}