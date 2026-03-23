namespace DataNavigation.Model.DTO
{
    public class AssignDepartmentDto
    {
        
            public int EmployeeId { get; set; }
            public int DepartmentId { get; set; }
            public DateTime AssignedOn { get; set; }
            public string Role { get; set; }
        
    }
}
