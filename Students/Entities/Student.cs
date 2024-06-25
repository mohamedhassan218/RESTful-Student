namespace Students.Entities;

public class Student
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Gender { get; set; }


    public int DepartmentId { get; set; }

    public Department? Department { get; set; }
}