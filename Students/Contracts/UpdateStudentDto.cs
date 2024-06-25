using System.ComponentModel.DataAnnotations;

namespace Students.Contrcts;

public record class UpdateStudentDto(
    [Required][StringLength(30)] string Name,
    [Required][StringLength(6)] string Gender,
    int DepartmentId
);
