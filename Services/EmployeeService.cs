using DataNavigation.Services.Interfaces;
using DataNavigation.Model.DTO;
using DataNavigation.Repository.Interfaces;
using DataNavigation.Model.Entities;
using System.ComponentModel.DataAnnotations;

namespace DataNavigation.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task RegisterEmployee(CreateEmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                EmployeeName = employeeDto.EmployeeName,
                Email = employeeDto.Email,
                ManagerId = employeeDto.ManagerId
            };

            await _employeeRepository.AddAsyncEmployee(employee);

        }
        public async Task AssignDepartment(AssignDepartmentDto assignDepartmentDto)
        {
            var assignDepartment = new EmployeeDepartment
            {
                EmployeeId = assignDepartmentDto.EmployeeId,
                DepartmentId = assignDepartmentDto.DepartmentId,
                AssignedOn = assignDepartmentDto.AssignedOn,
                Role = assignDepartmentDto.Role
            };
            await _employeeRepository.AddAsynEmployeeDepartment(assignDepartment);

        }

        public async Task<List<GetEmployeeDto>> GetEmployees()
        {
            var employee = await _employeeRepository.GetEmployeesAsync();
            return employee;
        }
    }
}
