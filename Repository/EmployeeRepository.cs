
using DataNavigation.Repository.Interfaces;
using DataNavigation.Data;
using DataNavigation.Model.Entities;


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
    }
}
