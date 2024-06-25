using Students.Contrcts;
using Students.Entities;

namespace Students.Mapping;

public static class DepartmentMapping
{
    public static DepartmentDto ToDto(this Department department)
    {
        return new DepartmentDto(department.Id, department.Name);
    }
}
