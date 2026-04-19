using BlazorApp1.Models;
using System.Net.Http.Json;
namespace BlazorApp1.Services;


    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _http;
        public EmployeeService(HttpClient http)
        {
            _http = http;
        }
         public async Task<List<Department>> GetDepartments()
         {
             return await _http.GetFromJsonAsync<List<Department>>("https://localhost:7019/api/Department") ?? new();
         }
    public async Task<List<Employee>> GetEmployees()
    {
        var response = await _http.GetFromJsonAsync<EmployeeResponse>(
            "https://localhost:7019/api/Student?page=1&pageSize=1000");
        return response?.Data ?? new();
    }

    public class EmployeeResponse
    {
        public List<Employee> Data { get; set; } = new();
    }

    public Task UpdateEmployee(Employee updatedEmployee)
          {
              throw new NotImplementedException();
          }
}