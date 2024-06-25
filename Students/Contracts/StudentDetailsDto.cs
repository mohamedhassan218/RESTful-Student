using System.ComponentModel.DataAnnotations;

namespace Students.Contrcts;

public record class StudentDetailsDto(
    int Id,
    string Name,
    string Gender,
    int DepartmentId
);
