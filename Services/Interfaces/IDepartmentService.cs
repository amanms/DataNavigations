using DataNavigation.Model.DTO;
namespace DataNavigation.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task RegisterDepartment(CreateDepartmentDto departmentDto);
    }
}
