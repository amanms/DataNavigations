using DataNavigation.Model.DTO;
using DataNavigation.Model.Entities;
using DataNavigation.Repository.Interfaces;
using DataNavigation.Services.Interfaces;

namespace DataNavigation.Services
{
    public class DepartmentService:IDepartmentService

    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository) 
        { 
            _departmentRepository = departmentRepository;
        }

        public async Task RegisterDepartment(CreateDepartmentDto departmentDto)
        {
            var department = new Department
            {
                Name = departmentDto.Name,
                Location = departmentDto.Location,
            };
             await _departmentRepository.AddDepartmentAsync(department);

        }
    }
}
