using DataNavigation.Model.DTO;
namespace DataNavigation.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task RegisterEmployee(CreateEmployeeDto Employee);
        Task AssignDepartment(AssignDepartmentDto assignDepartmentDto);
    }
}
