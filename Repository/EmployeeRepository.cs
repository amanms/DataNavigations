
using DataNavigation.Repository.Interfaces;
using DataNavigation.Data;
using DataNavigation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using DataNavigation.Model.DTO;


namespace DataNavigation.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsyncEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();

        }

        public async Task AddAsynEmployeeDepartment(EmployeeDepartment employeeDepartment)
        {
            var employee = await _context.Employees.FindAsync(employeeDepartment.EmployeeId);
            if (employee == null)
            {
                throw new Exception("Employee Not found");
            }

            var department = await _context.Departments.FindAsync(employeeDepartment.DepartmentId);
            if (department == null)
            {
                throw new Exception("Department Not found");
            }

            await _context.EmployeeDepartment.AddAsync(employeeDepartment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<GetEmployeeDto>> GetEmployeesAsync()
        {
            var joinResult = await _context.Employees
                    .Where(e => e.EmployeeDepartments.Any())
                    .Select(e => new GetEmployeeDto
                    {
                        EmployeeId = e.EmployeeId,
                        EmployeeName = e.EmployeeName,
                        Email = e.Email,

                        Manager = e.Manager == null ? null : new GetManagerDto
                        {
                            ManagerId = (int) e.ManagerId,
                            ManagerName = e.Manager.EmployeeName
                        },

                        Departments = e.EmployeeDepartments.Select(ed=>new GetEmployeeDepartmentDto
                        {
                            DepartmentId = ed.DepartmentId,
                            Name = ed.Department.Name,
                            Location = ed.Department.Location,
                            AssignedOn = ed.AssignedOn,
                            Role = ed.Role,
                        }).ToList()
                        
                    
                    }).ToListAsync();
            /*var result = await _context.Employees
                .Include(e=>e.Manager)
                .Include(e => e.EmployeeDepartments)
                    .ThenInclude(ed => ed.Department)
                .ToListAsync();*/
            return joinResult;
        }
    }
}
