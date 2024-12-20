using GreatBook.RazorPage.Infrastructure;
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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();

RegisterServices.RegisterApiServices(builder.Services);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
