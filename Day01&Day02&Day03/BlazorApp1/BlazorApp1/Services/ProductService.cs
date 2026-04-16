using BlazorApp1.Models;
using System.Net.Http.Json;

namespace BlazorApp1.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _http;

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Category>> GetCategories()
    {
        return await _http.GetFromJsonAsync<List<Category>>("https://localhost:7019/api/Department") ?? new();
    }

    public async Task<List<Product>> GetProducts()
    {
        // هنستقبلها كـ dynamic مؤقتاً عشان نعرف المشكلة فين
        var response = await _http.GetFromJsonAsync<StudentResponse>("https://localhost:7019/api/Student");
        return response?.Data ?? new();
    }

    // ضيف الكلاس ده تحت في نفس الملف أو في فولدر الـ Models
    public class StudentResponse
    {
        public List<Product> Data { get; set; } = new();
    }

    public async Task UpdateProduct(Product updatedProduct)
    {
        // هنبعت الـ ID في الـ URL والـ Object في الـ Body
        await _http.PutAsJsonAsync($"https://localhost:7019/api/Student/{updatedProduct.Id}", updatedProduct);
    }
}