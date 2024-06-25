using System.ComponentModel.DataAnnotations;

namespace Students.Contrcts;

public record class CreateStudentDto(
    [Required][StringLength(30)] string Name,
    [Required][StringLength(6)] string Gender,
    string Department,
    int DepartmentId
);
