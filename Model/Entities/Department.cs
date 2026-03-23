namespace DataNavigation.Model.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Name {  get; set; }
        public string? Location {  get; set; }

        public ICollection<EmployeeDepartment> EmployeeDepartments { get; set; } = new List<EmployeeDepartment>();

    }
}
