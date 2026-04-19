namespace BlazorApp1.Models
{
    public class Employee
    {
        public int St_Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string SupervisorName { get; set; } = string.Empty;
    }
}
