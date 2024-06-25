using Microsoft.EntityFrameworkCore;
using Students.Contrcts;
using Students.Data;
using Students.Entities;
using Students.Mapping;
namespace Students.Endpoints;

public static class StudentsEndpoints
{
    private static readonly List<StudentSummaryDto> students = [
        new (1, "Mohamed", "Male", "CS", 1),
        new (2, "Mona", "Female", "IT",2),
        new (3, "Mostafa", "Male", "CS",1),
        new (4, "Esraa", "Female", "IT",2),
        new (5, "Hassan", "Male", "IT",2)
    ];

    // This called extension method.
    public static RouteGroupBuilder MapStudentsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("students")
            .WithParameterValidation();     // This line to validate all routes in the group.

        // GET /students
        group.MapGet("/", async (StudentStoreContext dbContext) =>
                await dbContext.Students
                    .Include(student => student.Department)
                    .Select(student => student.ToStudentSummaryDto())
                    .AsNoTracking()
                    .ToListAsync());

        // GET /students/1
        group.MapGet("/{id}", async (int id, StudentStoreContext dbContext) =>
        {
            Student? student = await dbContext.Students.FindAsync(id);

            return student is null ?
                Results.NotFound()
                : Results.Ok(student.ToStudentDetailsDto());
        }).WithName("GetStudent");    // Specify a name to the endpoint.

        // POST /students
        group.MapPost("/", async (CreateStudentDto newStudent, StudentStoreContext dbContext) =>
        {
            Student student = newStudent.ToEntity();

            dbContext.Students.Add(student);
            await dbContext.SaveChangesAsync();

            // IMPORTANT
            // We never return enternal entities to the client, instead we deal with the DTO!!
            //  Rememeber: DTO is a contaract between the clinet and the server.

            // Return 201 created status.
            return Results.CreatedAtRoute("GetStudent",
             new { id = student.Id },
              student.ToStudentDetailsDto());
        });

        // PUT /students/{id}
        group.MapPut("/{id}", async (int id, UpdateStudentDto updatedStudent, StudentStoreContext dbContext) =>
        {
            var existingStudent = await dbContext.Students.FindAsync(id);

            if (existingStudent is null)
                return Results.NotFound();


            dbContext.Entry(existingStudent)
                .CurrentValues
                .SetValues(updatedStudent.ToEntity(id));
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        // DELETE /students/{id}
        group.MapDelete("/{id}", async (int id, StudentStoreContext dbContext) =>
        {
            await dbContext.Students
                .Where(student => student.Id == id)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}