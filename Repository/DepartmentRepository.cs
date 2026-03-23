using DataNavigation.Data;
using DataNavigation.Repository.Interfaces;
using DataNavigation.Model.Entities;

namespace DataNavigation.Repository
{
    public class DepartmentRepository:IDepartmentRepository
    {
        private readonly ApplicationDbContext _Context;
        public DepartmentRepository(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task AddDepartmentAsync(Department department)
        {
            await _Context.AddAsync(department);
            await _Context.SaveChangesAsync();

        }
    }
}
