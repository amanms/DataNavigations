namespace DataNavigation.Model.DTO
{
    public class CreateEmployeeDto
    {
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public int? ManagerId { get; set; }
    }
}