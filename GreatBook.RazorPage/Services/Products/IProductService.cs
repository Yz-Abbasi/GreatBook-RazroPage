using GreatBook.RazorPage.Models;
using GreatBook.RazorPage.Models.Products.Commands;
using GreatBook.RazorPage.Models.Products;

namespace GreatBook.RazorPage.Services.Products;

public interface IProductService
{
    Task<ApiResult> CreateProduct(CreateProductCommand command);
    Task<ApiResult> EditProduct(EditProductCommand command);
    Task<ApiResult> AddProductImage(AddProductImageCommand command);
    Task<ApiResult> DeleteProductImage(DeleteProductImageCommand command);

    Task<ProductFilterResult> GetProducts(ProductFilterParam filterParam);
    Task<ProductDto?> GetProductById(long productId);
    Task<ProductDto?> GetProductBySlug(string slug);
    Task<ProductShopResult> GetProductsForShop(ProductShopFilterparam filterparam);
}