namespace DataNavigation.Model.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Email { get; set; }
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<EmployeeDepartment> EmployeeDepartments { get; set; }= new List<EmployeeDepartment>();

    }
}
