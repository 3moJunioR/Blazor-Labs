using BlazorApp1.Models;

namespace BlazorApp1.Services;

public interface IProductService
{
    Task<List<Category>> GetCategories();
    Task<List<Product>> GetProducts();
    // void UpdateProduct(Product updatedProduct); 
    Task UpdateProduct(Product updatedProduct);
}
