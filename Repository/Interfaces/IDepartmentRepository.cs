using DataNavigation.Model.Entities;
namespace DataNavigation.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        Task AddDepartmentAsync(Department department);
    }
}
