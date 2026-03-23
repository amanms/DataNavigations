namespace DataNavigation.Model.Entities
{
    public class EmployeeDepartment
    {
        public int EmployeeId { get; set; }
        public int DepartmentId {  get; set; }
        public DateTime AssignedOn { get; set; }
        public string Role {  get; set; }

        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
