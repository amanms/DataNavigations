
using DataNavigation.Model.DTO;
using DataNavigation.Model.Entities;
namespace DataNavigation.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task AddAsyncEmployee(Employee employee);
        Task AddAsynEmployeeDepartment(EmployeeDepartment employeeDepartment);

        Task<List<GetEmployeeDto>> GetEmployeesAsync();
    }
}
