namespace Students.Mapping;
using Students.Contrcts;
using Students.Entities;

public static class StudentMapping
{

    public static Student ToEntity(this CreateStudentDto student)
    {
        return new Student()
        {
            Name = student.Name,
            Gender = student.Gender,
            DepartmentId = student.DepartmentId,
        };
    }

    public static Student ToEntity(this UpdateStudentDto student, int id)
    {
        return new Student()
        {
            Id = id,
            Name = student.Name,
            Gender = student.Gender,
            DepartmentId = student.DepartmentId,
        };
    }

    public static StudentSummaryDto ToStudentSummaryDto(this Student student)
    {
        return new StudentSummaryDto(
                student.Id,
                student.Name,
                student.Gender,
                student.Department!.Name,
                student.DepartmentId
            );
    }

    public static StudentDetailsDto ToStudentDetailsDto(this Student student)
    {
        return new StudentDetailsDto(
                student.Id,
                student.Name,
                student.Gender,
                student.DepartmentId
            );
    }
}