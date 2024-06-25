using System.ComponentModel.DataAnnotations;

namespace Students.Contrcts;

public record class StudentSummaryDto(
    int Id,
    string Name,
    string Gender,
    [Required] string Department,
    int DepartmentId
);
