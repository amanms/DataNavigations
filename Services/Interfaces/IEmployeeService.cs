using DataNavigation.Model.DTO;
using DataNavigation.Model.Entities;
namespace DataNavigation.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task RegisterEmployee(CreateEmployeeDto Employee);
        Task AssignDepartment(AssignDepartmentDto assignDepartmentDto);

        Task<List<GetEmployeeDto>> GetEmployees();
    }
}
