using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IEmployeeService
    {
        Task<List<Department>> GetDepartments();
         Task<List<Employee>> GetEmployees();
         Task UpdateEmployee(Employee updatedEmployee);
    }
}
