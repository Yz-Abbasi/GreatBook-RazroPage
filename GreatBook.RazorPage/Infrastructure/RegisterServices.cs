using GreatBook.RazorPage.Services.Auth;
using GreatBook.RazorPage.Services.Banners;
using GreatBook.RazorPage.Services.Categories;
using GreatBook.RazorPage.Services.Comments;
using GreatBook.RazorPage.Services.Orders;
using GreatBook.RazorPage.Services.Products;
using GreatBook.RazorPage.Services.Roles;
using GreatBook.RazorPage.Services.Sellers;
using GreatBook.RazorPage.Services.Sliders;
using GreatBook.RazorPage.Services.UserAddresses;
using GreatBook.RazorPage.Services.Users;

namespace GreatBook.RazorPage.Infrastructure;

public static class RegisterServices
{
    public static IServiceCollection RegisterApiServices(IServiceCollection services)
    {
        const string baseAddress = "http://localhost:5281";

        services.AddHttpClient<IAuthService, AuthService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IBannerService, BannerService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<ICategoryService, CategoryService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<ICommentService, CommentService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IOrderService, OrderService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IProductService, ProductService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IRoleService, RoleService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<ISellerService, SellerService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<ISliderService, SliderService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IUserAddresseService, UserAddresseService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });
        services.AddHttpClient<IUserService, UserService>(httpClient => 
        {
            httpClient.BaseAddress = new Uri(baseAddress);
        });

        return services;
    }
}