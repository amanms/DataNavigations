using Microsoft.AspNetCore.Mvc;
using DataNavigation.Services;
using DataNavigation.Services.Interfaces;
using DataNavigation.Model.DTO;

namespace DataNavigation.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateEmployeeDto employeeDto)
        {
            await _employeeService.RegisterEmployee(employeeDto);
            return Ok("registered successfully");
        }

        [HttpPost("department")]

        public async Task<IActionResult> RegisterDepartment([FromBody] CreateDepartmentDto departmentDto)
        {
            await _departmentService.RegisterDepartment(departmentDto);
            return Ok("Department created");

        }
        [HttpPost("assign-department")]
        public async Task<IActionResult> AssignDepartment([FromBody] AssignDepartmentDto assignDepartmentDto)
        {
            await _employeeService.AssignDepartment(assignDepartmentDto);
            return Ok("Assigned successfully");
        }

        [HttpGet("employee")]

        public async Task<IActionResult> GetEmployess()
        {
            var response = await _employeeService.GetEmployees();
            return Ok(response);
        }

    }
}
