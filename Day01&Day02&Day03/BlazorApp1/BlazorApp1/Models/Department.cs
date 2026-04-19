namespace BlazorApp1.Models
{
    public class Department
    {
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; } = string.Empty;
        public string Dept_Desc { get; set; } = string.Empty;
        public int StudentsCount { get; set; }
        public List<string> StudentNames { get; set; } = new();
    }
}
